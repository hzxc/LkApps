﻿using Apps.Common;
using Apps.Models;
using Apps.Web.Helper;

namespace Apps.Web.Core
{
    public static class LogHandler
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="oper">操作人</param>
        /// <param name="mes">操作信息</param>
        /// <param name="result">结果</param>
        /// <param name="type">类型</param>
        /// <param name="module">操作模块</param>
        public static void WriteServiceLog(string oper, string mes, string result, string type, string module)
        {
            SysConfigModel siteConfig = OperationContext.Current.ServiceSession.SysConfig.LoadConfig(Utils.GetXmlMapPath("Configpath"));
            //后台管理日志开启
            if (siteConfig.logstatus == 1)
            {
                ValidationErrors errors = new ValidationErrors();
                Apps.Models.Sys.SysLogModel entity = new Apps.Models.Sys.SysLogModel();
                entity.Id = ResultHelper.NewId;
                entity.Operator = oper;
                entity.Message = mes;
                entity.Result = result;
                entity.Type = type;
                entity.Module = module;
                entity.CreateTime = ResultHelper.NowTime;

                OperationContext.Current.ServiceSession.SysLog.Create(ref errors,entity);
            }
            else
            {
                return;
            }
        }

        //public static void WriteWeChatLog(WC_ResponseLogModel model)
        //{
        //    SysConfigModel siteConfig = new SysConfigBLL().loadConfig(Utils.GetXmlMapPath("Configpath"));
        //    //后台管理日志开启
        //    if (siteConfig.logstatus == 1)
        //    {
        //        WC_ResponseLog entity = new WC_ResponseLog();
        //    entity.Id = ResultHelper.NewId;
        //    entity.OpenId = model.OpenId;
        //    entity.RequestType = model.RequestType;
        //    entity.RequestContent = model.RequestContent;
        //    entity.ResponseType = model.ResponseType;
        //    entity.ResponseContent = model.ResponseContent;
        //    entity.CreateBy = "";
        //    entity.CreateTime = ResultHelper.NowTime;
        //    entity.ModifyBy = "";
        //    entity.ModifyTime = ResultHelper.NowTime;

        //    using (WC_ResponseLogRepository logRepository = new WC_ResponseLogRepository(new DBContainer()))
        //    {
        //        logRepository.Create(entity);
        //    }
        //}
        //    else
        //    {
        //        return;
        //    }
        //}

    }
}