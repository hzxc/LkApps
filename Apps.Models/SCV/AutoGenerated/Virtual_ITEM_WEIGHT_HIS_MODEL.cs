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
namespace Apps.Models.SCV.ITEM
{
	public class Virtual_ITEM_WEIGHT_HIS_MODEL
	{
			public virtual int ID { get; set; }
			public virtual string ITEM { get; set; }
			public virtual Nullable<decimal> OLD_WEIGHT { get; set; }
			public virtual Nullable<decimal> NEW_WEIGHT { get; set; }
			public virtual System.DateTime DATE_TIME_STAMP { get; set; }
			public virtual string USER_STAMP { get; set; }
			public virtual string SHIPMENGT_ID { get; set; }
			public virtual string UPDATE_TYPE { get; set; }
		}
}
