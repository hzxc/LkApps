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
	public partial class SysPosition
	{
		public Apps.Models.Sys.SysPositionModel ToPOCO(){
			return new Apps.Models.Sys.SysPositionModel(){
								Id=this.Id,
				Name=this.Name,
				Remark=this.Remark,
				Sort=this.Sort,
				CreateTime=this.CreateTime,
				Enable=this.Enable,
				MemberCount=this.MemberCount,
				DepId=this.DepId,
			};
		}
	}
}
