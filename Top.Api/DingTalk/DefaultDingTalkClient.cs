﻿using FastJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Top.Api.Parser;
using Top.Api.Util;
using Top.Api;

namespace DingTalk.Api
{
    /// <summary>
    /// 基于REST的TOP客户端。
    /// </summary>
    public class DefaultDingTalkClient : IDingTalkClient
    {
        internal string serverUrl;
        internal string format = Constants.FORMAT_XML;

        internal WebUtils webUtils;
        internal ITopLogger topLogger;
        internal bool disableParser = false; // 禁用响应结果解释
        internal bool disableTrace = false; // 禁用日志调试功能
        internal bool useSimplifyJson = false; // 是否采用精简化的JSON返回
        internal bool useGzipEncoding = true;  // 是否启用响应GZIP压缩
        internal IDictionary<string, string> systemParameters; // 设置所有请求共享的系统级参数

        #region DefaultDingTalkClient Constructors

        public DefaultDingTalkClient(string serverUrl)
        {
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
            this.topLogger = DefaultTopLogger.GetDefault();
        }

        public DefaultDingTalkClient(string serverUrl,string format)
            : this(serverUrl)
        {
            this.format = format;
        }

        #endregion

        public void SetTimeout(int timeout)
        {
            this.webUtils.Timeout = timeout;
        }

        public void SetReadWriteTimeout(int readWriteTimeout)
        {
            this.webUtils.ReadWriteTimeout = readWriteTimeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetUseSimplifyJson(bool useSimplifyJson)
        {
            this.useSimplifyJson = useSimplifyJson;
        }

        public void SetUseGzipEncoding(bool useGzipEncoding)
        {
            this.useGzipEncoding = useGzipEncoding;
        }

        public void SetIgnoreSSLCheck(bool ignore)
        {
            this.webUtils.IgnoreSSLCheck = ignore;
        }

        public void SetSystemParameters(IDictionary<string, string> systemParameters)
        {
            this.systemParameters = systemParameters;
        }

        #region IDingTalkClient Members

        public virtual T Execute<T>(IDingTalkRequest<T> request) where T : DingTalkResponse
        {
            return DoExecute<T>(request, null, DateTime.Now);
        }

        public virtual T Execute<T>(IDingTalkRequest<T> request, string session) where T : DingTalkResponse
        {
            return DoExecute<T>(request, session, DateTime.Now);
        }

        public virtual T Execute<T>(IDingTalkRequest<T> request, string session, DateTime timestamp) where T : DingTalkResponse
        {
            return DoExecute<T>(request, session, timestamp);
        }

        #endregion

        private T DoExecute<T>(IDingTalkRequest<T> request, string session, DateTime timestamp) where T : DingTalkResponse
        {
            long start = DateTime.Now.Ticks;

            // 提前检查业务参数
            try
            {
                request.Validate();
            }
            catch (TopException e)
            {
                return CreateErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
            }

            // 添加协议级请求参数
            TopDictionary txtParams = new TopDictionary(request.GetParameters());
            txtParams.Add(Constants.METHOD, request.GetApiName());
            txtParams.Add(Constants.VERSION, "2.0");
            txtParams.Add(Constants.FORMAT, format);
            txtParams.Add(Constants.PARTNER_ID, GetSdkVersion());
            txtParams.Add(Constants.TIMESTAMP, timestamp);
            txtParams.Add(Constants.SESSION, session);
            txtParams.AddAll(this.systemParameters);

            if (this.useSimplifyJson)
            {
                txtParams.Add(Constants.SIMPLIFY, "true");
            }
            // 添加头部参数
            if (this.useGzipEncoding)
            {
                request.GetHeaderParameters()[Constants.ACCEPT_ENCODING] = Constants.CONTENT_ENCODING_GZIP;
            }

            string realServerUrl = GetServerUrl(this.serverUrl, request.GetApiName(), session);
            string reqUrl = WebUtils.BuildRequestUrl(realServerUrl, txtParams);
            try
            {
                string body;
               
                body = webUtils.DoPost(realServerUrl, txtParams, request.GetHeaderParameters());

                // 解释响应结果
                T rsp;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                    rsp.Body = body;
                }
                else
                {
                    if (Constants.FORMAT_XML.Equals(format))
                    {
                        ITopParser<T> tp = new TopXmlParser<T>();
                        rsp = tp.Parse(body);
                    }
                    else
                    {
                        ITopParser<T> tp;
                        if (useSimplifyJson)
                        {
                            tp = new TopSimplifyJsonParser<T>();
                        }
                        else
                        {
                            tp = new TopJsonParser<T>();
                        }
                        rsp = tp.Parse(body);
                    }
                }

                // 追踪错误的请求
                if (rsp.IsError)
                {
                    TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                    TraceApiError(request.GetApiName(), serverUrl, txtParams, latency.TotalMilliseconds, rsp.Body);
                }
                return rsp;
            }
            catch (Exception e)
            {
                TimeSpan latency = new TimeSpan(DateTime.Now.Ticks - start);
                TraceApiError(request.GetApiName(), serverUrl, txtParams, latency.TotalMilliseconds, e.GetType() + ": " + e.Message);
                throw e;
            }
        }

        internal virtual string GetServerUrl(string serverUrl, string apiName, string session)
        {
            return serverUrl;
        }

        internal virtual string GetSdkVersion()
        {
            return Constants.SDK_VERSION;
        }

        internal T CreateErrorResponse<T>(string errCode, string errMsg) where T : DingTalkResponse
        {
            T rsp = Activator.CreateInstance<T>();
            rsp.ErrCode = errCode;
            rsp.ErrMsg = errMsg;

            if (Constants.FORMAT_XML.Equals(format))
            {
                XmlDocument root = new XmlDocument();
                XmlElement bodyE = root.CreateElement(Constants.ERROR_RESPONSE);
                XmlElement codeE = root.CreateElement(Constants.ERROR_CODE);
                codeE.InnerText = errCode;
                bodyE.AppendChild(codeE);
                XmlElement msgE = root.CreateElement(Constants.ERROR_MSG);
                msgE.InnerText = errMsg;
                bodyE.AppendChild(msgE);
                root.AppendChild(bodyE);
                rsp.Body = root.OuterXml;
            }
            else
            {
                IDictionary<string, object> errObj = new Dictionary<string, object>();
                errObj.Add(Constants.ERROR_CODE, errCode);
                errObj.Add(Constants.ERROR_MSG, errMsg);
                IDictionary<string, object> root = new Dictionary<string, object>();
                root.Add(Constants.ERROR_RESPONSE, errObj);

                string body = JSON.ToJSON(root);
                rsp.Body = body;
            }
            return rsp;
        }

        internal void TraceApiError(string apiName, string url, Dictionary<string, string> parameters, double latency, string errorMessage)
        {
            if (!disableTrace)
            {
                this.topLogger.TraceApiError("dingtalk",apiName, url, parameters, latency, errorMessage);
            }
        }
    }
}
