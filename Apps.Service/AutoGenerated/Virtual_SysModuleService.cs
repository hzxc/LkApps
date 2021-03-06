//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Apps.Models;
using Apps.Common;
using Microsoft.Practices.Unity;
using System.Transactions;
using Apps.Locale;
using System.Linq.Expressions;
namespace Apps.Service.Sys
{
	public class Virtual_SysModuleService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysModuleRepository m_Rep{
			 get
			{
				return DBSession.SysModule;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysModuleModel> GetList(Expression<Func<Apps.Models.SysModule, bool>> where = null){
		
				IQueryable<SysModule> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysModuleModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysModule, bool>> where,Expression<Func<Apps.Models.SysModule, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysModule> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysModuleModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysModule, bool>> where = null)
		{

			IQueryable<SysModule> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.EnglishName.Contains(queryStr)
								|| a.ParentId.Contains(queryStr)
								|| a.AreasName.Contains(queryStr)
								|| a.ControllerName.Contains(queryStr)
								|| a.ActionName.Contains(queryStr)
								
								
								|| a.Iconic.Contains(queryStr)
								
								|| a.Remark.Contains(queryStr)
								
								|| a.CreatePerson.Contains(queryStr)
								
								
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.Sys.SysModuleModel> CreateModelList(ref IQueryable<SysModule> queryData)
		{

			List<Apps.Models.Sys.SysModuleModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysModuleModel
											  {
													Id = r.Id,
													Name = r.Name,
													EnglishName = r.EnglishName,
													ParentId = r.ParentId,
													AreasName = r.AreasName,
													ControllerName = r.ControllerName,
													ActionName = r.ActionName,
													FormMethod = r.FormMethod,
													OperationType = r.OperationType,
													Iconic = r.Iconic,
													Sort = r.Sort,
													Remark = r.Remark,
													Enable = r.Enable,
													CreatePerson = r.CreatePerson,
													CreateTime = r.CreateTime,
													IsLast = r.IsLast,
													Version = r.Version,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysModuleModel model)
		{
				SysModule entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysModule();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.EnglishName = model.EnglishName;
				entity.ParentId = model.ParentId;
				entity.AreasName = model.AreasName;
				entity.ControllerName = model.ControllerName;
				entity.ActionName = model.ActionName;
				entity.FormMethod = model.FormMethod;
				entity.OperationType = model.OperationType;
				entity.Iconic = model.Iconic;
				entity.Sort = model.Sort;
				entity.Remark = model.Remark;
				entity.Enable = model.Enable;
				entity.CreatePerson = model.CreatePerson;
				entity.CreateTime = model.CreateTime;
				entity.IsLast = model.IsLast;
				entity.Version = model.Version;
  
				m_Rep.Create(entity);
		}



		 public virtual void RemoveById(ref ValidationErrors errors, string id)
		{
			
				m_Rep.RemoveById(id);
			
		}

		public virtual void RemoveByIds(ref ValidationErrors errors, string[] deleteCollection)
		{
				if (deleteCollection != null)
				{
				   //事务批量删除
				   // using (TransactionScope transactionScope = new TransactionScope())
				   // {
				   //     if (m_Rep.Delete(deleteCollection) == deleteCollection.Length)
				   //     {
				   //         transactionScope.Complete();
				   //         return true;
				   //     }
				   //    else
				   //     {
				   //         Transaction.Current.Rollback();
				   //         return false;
				   //     }
				   // }
				   m_Rep.RemoveById(deleteCollection);
				}
		}

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysModuleModel model,params string[] updateProperties)
		{
				SysModule entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.Name = model.Name;
											entity.EnglishName = model.EnglishName;
											entity.ParentId = model.ParentId;
											entity.AreasName = model.AreasName;
											entity.ControllerName = model.ControllerName;
											entity.ActionName = model.ActionName;
											entity.FormMethod = model.FormMethod;
											entity.OperationType = model.OperationType;
											entity.Iconic = model.Iconic;
											entity.Sort = model.Sort;
											entity.Remark = model.Remark;
											entity.Enable = model.Enable;
											entity.CreatePerson = model.CreatePerson;
											entity.CreateTime = model.CreateTime;
											entity.IsLast = model.IsLast;
											entity.Version = model.Version;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysModuleModel);
						Type typeE = typeof(Apps.Models.SysModule);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysModuleModel GetById(string id)
		{
			SysModule entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysModule entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysModuleModel model = new Apps.Models.Sys.SysModuleModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.EnglishName = entity.EnglishName;
				model.ParentId = entity.ParentId;
				model.AreasName = entity.AreasName;
				model.ControllerName = entity.ControllerName;
				model.ActionName = entity.ActionName;
				model.FormMethod = entity.FormMethod;
				model.OperationType = entity.OperationType;
				model.Iconic = entity.Iconic;
				model.Sort = entity.Sort;
				model.Remark = entity.Remark;
				model.Enable = entity.Enable;
				model.CreatePerson = entity.CreatePerson;
				model.CreateTime = entity.CreateTime;
				model.IsLast = entity.IsLast;
				model.Version = entity.Version;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
