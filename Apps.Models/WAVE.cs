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
    
    public partial class WAVE
    {
        public decimal INTERNAL_WAVE_NUM { get; set; }
        public string WAREHOUSE { get; set; }
        public string WAVE_NAME { get; set; }
        public string WAVE_MASTER { get; set; }
        public decimal STATUS { get; set; }
        public string CURRENT_WAVE_STEP { get; set; }
        public string LAST_WAVE_STEP { get; set; }
        public Nullable<decimal> TOTAL_SHIPMENTS { get; set; }
        public Nullable<decimal> TOTAL_LINES { get; set; }
        public Nullable<decimal> TOTAL_QTY { get; set; }
        public string QUANTITY_UM { get; set; }
        public Nullable<System.DateTime> WAVE_DATE_TIME_STARTED { get; set; }
        public Nullable<System.DateTime> WAVE_DATE_TIME_ENDED { get; set; }
        public string USER_DEF1 { get; set; }
        public string USER_DEF2 { get; set; }
        public string USER_DEF3 { get; set; }
        public string USER_DEF4 { get; set; }
        public string USER_DEF5 { get; set; }
        public string USER_DEF6 { get; set; }
        public string USER_DEF7 { get; set; }
        public string USER_DEF8 { get; set; }
        public string USER_STAMP { get; set; }
        public System.DateTime DATE_TIME_STAMP { get; set; }
        public string WAVE_MODE { get; set; }
        public string ERROR_MESSAGE { get; set; }
        public string LOCKED { get; set; }
        public string REPLENISHMENT_REQD { get; set; }
        public string PROCESS_STAMP { get; set; }
        public string MESSAGE_ID { get; set; }
        public string RUN_USER { get; set; }
        public string RELESAE_USER { get; set; }
        public Nullable<System.DateTime> RELESAE_DATE_TIME { get; set; }
        public string PRINT { get; set; }
    
        public virtual WAREHOUSE WAREHOUSE1 { get; set; }
    }
}
