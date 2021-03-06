﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomHttpClient.Request
{
    [XmlRoot("request")]
    public class ReturnorderConfirmRequest : CustomRequest<Response.ReturnorderConfirmResponse>
    {

        [XmlElement("returnOrder")]
        public ReturnOrderDomain ReturnOrder { get; set; }

        [XmlArray("orderLines"), XmlArrayItem("orderLine")]
        public List<OrderLineDomain> OrderLines { get; set; }

        [XmlElement("extendProps")]
        public string ExtendProps { get; set; }

        public override string GetApiName()
        {
            return "taobao.qimen.returnorder.confirm";
        }

        #region ReturnOrderDomain
        [Serializable]

        public class ReturnOrderDomain
        {
            /// <summary>
            /// ERP的退货入库单编码
            /// </summary>
            [XmlElement("returnOrderCode")]
            public string ReturnOrderCode { get; set; }

            /// <summary>
            /// 仓库系统订单编码
            /// </summary>
            [XmlElement("returnOrderId")]
            public string ReturnOrderId { get; set; }

            /// <summary>
            /// 仓库编码(统仓统配等无需ERP指定仓储编码的情况填OTHER)
            /// </summary>
            [XmlElement("warehouseCode")]
            public string WarehouseCode { get; set; }

            /// <summary>
            /// 外部业务编码(消息ID;用于去重;ISV对于同一请求;分配一个唯一性的编码。用来保证因为网络等原因导致重复传输;请求不会 被重复处理)
            /// </summary>
            [XmlElement("outBizCode")]
            public string OutBizCode { get; set; }

            /// <summary>
            /// 单据类型(THRK=退货入库;HHRK=换货入库;只传英文编码)
            /// </summary>
            [XmlElement("orderType")]
            public string OrderType { get; set; }

            /// <summary>
            /// 确认入库时间(YYYY-MM-DD HH:MM:SS)
            /// </summary>
            [XmlElement("orderConfirmTime")]
            public string OrderConfirmTime { get; set; }

            /// <summary>
            /// 物流公司编码(SF=顺丰、EMS=标准快递、EYB=经济快件、ZJS=宅急送、YTO=圆通、ZTO=中通(ZTO)、HTKY=百世汇通、 UC=优速、STO=申通、TTKDEX=天天快递、QFKD=全峰、FAST=快捷、POSTB=邮政小包、GTO=国通、YUNDA=韵达、JD=京东配送、DD=当当宅配、 AMAZON=亚马逊物流、OTHER=其他;只传英文编码)
            /// </summary>
            [XmlElement("logisticsCode"),DefaultValue("")]
            public string LogisticsCode { get; set; }

            /// <summary>
            /// 物流公司名称
            /// </summary>
            [XmlElement("logisticsName")]
            public string LogisticsName { get; set; }

            /// <summary>
            /// 运单号
            /// </summary>
            [XmlElement("expressCode")]
            public string ExpressCode { get; set; }

            /// <summary>
            /// 退货原因
            /// </summary>
            [XmlElement("returnReason")]
            public string ReturnReason { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// 发件人信息
            /// </summary>
            [XmlElement("senderInfo")]
            public SenderInfoDomain SenderInfo { get; set; }

        }

        [Serializable]
        public class SenderInfoDomain
        {
            /// <summary>
            /// 姓名
            /// </summary>
            [XmlElement("name")]
            public string Name { get; set; }
            /// <summary>
            /// 公司名称
            /// </summary>
            [XmlElement("company")]
            public string Company { get; set; }

            /// <summary>
            /// 邮编
            /// </summary>
            [XmlElement("zipCode")]
            public string ZipCode { get; set; }

            /// <summary>
            /// 移动电话
            /// </summary>
            [XmlElement("mobile")]
            public string Mobile { get; set; }

            /// <summary>
            /// 固定电话
            /// </summary>
            [XmlElement("tel")]
            public string Tel { get; set; }

            /// <summary>
            /// 电子邮箱
            /// </summary>
            [XmlElement("email")]
            public string Email { get; set; }

            /// <summary>
            /// 国家二字码
            /// </summary>
            [XmlElement("countryCode")]
            public string CountryCode { get; set; }

            /// <summary>
            /// 省份
            /// </summary>
            [XmlElement("province")]
            public string Province { get; set; }


            /// <summary>
            /// 城市
            /// </summary>
            [XmlElement("city")]
            public string City { get; set; }


            /// <summary>
            /// 区域
            /// </summary>
            [XmlElement("area")]
            public string Area { get; set; }

            /// <summary>
            /// 村镇
            /// </summary>
            [XmlElement("town")]
            public string Town { get; set; }

            /// <summary>
            /// 详细地址
            /// </summary>
            [XmlElement("detailAddress")]
            public string DetailAddress { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

        }
        #endregion

        #region OrderLineDomain
        [Serializable]

        public class OrderLineDomain
        {

            /// <summary>
            /// 货主编码
            /// </summary>
            [XmlElement("ownerCode")]
            public string OwnerCode { get; set; }
            /// <summary>
            /// 商品编码
            /// </summary>
            [XmlElement("itemCode")]
            public string ItemCode { get; set; }
            /// <summary>
            /// 仓储系统商品编码(条件为提供后端（仓储系统）商品编码的仓储系统)
            /// </summary>
            [XmlElement("itemId")]
            public string ItemId { get; set; }
            /// <summary>
            /// 备注
            /// </summary>
            [XmlElement("remark")]
            public string Remark { get; set; }

            /// <summary>
            /// 单据行号
            /// </summary>
            [XmlElement("orderLineNo")]
            public string OrderLineNo { get; set; }

            /// <summary>
            /// 交易平台订单
            /// </summary>
            [XmlElement("sourceOrderCode")]
            public string SourceOrderCode { get; set; }

            /// <summary>
            /// 交易平台子订单编码
            /// </summary>
            [XmlElement("subSourceOrderCode")]
            public string SubSourceOrderCode { get; set; }

            /// <summary>
            /// 库存类型(ZP=正品;CC=残次;JS=机损;XS=箱损;默认为ZP)
            /// </summary>
            [XmlElement("inventoryType"),DefaultValue("ZP")]
            public string InventoryType { get; set; }

            /// <summary>
            /// 应收商品数量
            /// </summary>
            [XmlElement("planQty")]
            public Nullable<long> PlanQty { get; set; }
            public bool ShouldSerializePlanQty()
            {
                return PlanQty != null;
            }

            /// <summary>
            /// 实收商品数量
            /// </summary>
            [XmlElement("actualQty")]
            public string ActualQty { get; set; }

            /// <summary>
            /// 生产日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("productDate")]
            public string ProductDate { get; set; }

            /// <summary>
            /// 过期日期(YYYY-MM-DD)
            /// </summary>
            [XmlElement("expireDate")]
            public string ExpireDate { get; set; }

            /// <summary>
            /// 生产批号
            /// </summary>
            [XmlElement("produceCode")]
            public string ProduceCode { get; set; }

            /// <summary>
            /// 商品的二维码(类似电子产品的SN码;用来进行商品的溯源;多个二维码之间用分号;隔开)
            /// </summary>
            [XmlElement("qrCode")]
            public string QrCode { get; set; }

            #endregion
        }
    }
}
