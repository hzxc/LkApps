//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
	public partial class CUSTOMER
	{
		public Apps.Models.SCV.Sys.CUSTOMER_MODEL ToPOCO(){
			return new Apps.Models.SCV.Sys.CUSTOMER_MODEL(){
								INTERNAL_CUSTOMER_NUM=this.INTERNAL_CUSTOMER_NUM,
				CUSTOMER_ID=this.CUSTOMER_ID,
				NAME=this.NAME,
				ADDRESS1=this.ADDRESS1,
				ADDRESS2=this.ADDRESS2,
				CITY=this.CITY,
				STATE=this.STATE,
				COUNTRY=this.COUNTRY,
				POSTAL_CODE=this.POSTAL_CODE,
				PARENT=this.PARENT,
				ATTENTION_TO=this.ATTENTION_TO,
				PHONE_NUM=this.PHONE_NUM,
				FAX_NUM=this.FAX_NUM,
				EMAIL=this.EMAIL,
				ACTIVE=this.ACTIVE,
				CARRIER=this.CARRIER,
				USER_STAMP=this.USER_STAMP,
				DATE_TIME_STAMP=this.DATE_TIME_STAMP,
			};
		}
	}
}
