//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SHIPPING_CONTAINER_HIS
    {
        public string ID { get; set; }
        public decimal INTERNAL_CONTAINER_NUM { get; set; }
        public string CONTAINER_ID { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public string WEIGHT_NUM { get; set; }
        public string UPDATE_USER { get; set; }
        public System.DateTime UPDATE_DATATIME { get; set; }
        public string UPDATE_USERNAME { get; set; }
        public string UPDATE_USERTRUENAME { get; set; }
        public string TRACKING_NUMBER { get; set; }
    
        public virtual SHIPPING_CONTAINER SHIPPING_CONTAINER { get; set; }
    }
}
