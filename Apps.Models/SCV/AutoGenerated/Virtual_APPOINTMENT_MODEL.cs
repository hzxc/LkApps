//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.SCV.Sys
{
	public class Virtual_APPOINTMENT_MODEL
	{
			public virtual decimal INTERNAL_APPOINT_NUM { get; set; }
			public virtual Nullable<decimal> INTERNAL_RECEIPT_NUM { get; set; }
			public virtual string DOCK { get; set; }
			public virtual Nullable<System.DateTime> START_DATE_TIME { get; set; }
			public virtual Nullable<System.DateTime> END_DATE_TIME { get; set; }
			public virtual Nullable<decimal> STATUS { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual System.DateTime DATE_TIME_STAMP { get; set; }
		}
}
