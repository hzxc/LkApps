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
    
    public partial class ALLOCATION_RULE_DETAIL
    {
        public string ALLOCATION_RULE { get; set; }
        public string QUANTITY_UM { get; set; }
        public int SEQUENCE { get; set; }
        public string STRATEGY { get; set; }
        public Nullable<decimal> LOC_SEL_ID { get; set; }
        public string LOC_SEL_DESC { get; set; }
        public decimal OBJECT_ID { get; set; }
        public string ROLL_IN_NEXT_UM { get; set; }
        public Nullable<decimal> MAX_ALLOCATE_QTY { get; set; }
        public string MAX_ALLOCATE_QTY_UM { get; set; }
    }
}
