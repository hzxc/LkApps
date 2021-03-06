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
	public class Virtual_SysRoleService
	{

		public Apps.IRepository.IDBSession DBSession{
			 get
			{
				return DBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.Sys.ISysRoleRepository m_Rep{
			 get
			{
				return DBSession.SysRole;
			}
		}
		

		public virtual List<Apps.Models.Sys.SysRoleModel> GetList(Expression<Func<Apps.Models.SysRole, bool>> where = null){
		
				IQueryable<SysRole> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysRoleModel> GetListSort<TKey>(Expression<Func<Apps.Models.SysRole, bool>> where,Expression<Func<Apps.Models.SysRole, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<SysRole> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.Sys.SysRoleModel> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.SysRole, bool>> where = null)
		{

			IQueryable<SysRole> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.Id.Contains(queryStr)
								|| a.Name.Contains(queryStr)
								|| a.Description.Contains(queryStr)
								
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
		public virtual List<Apps.Models.Sys.SysRoleModel> CreateModelList(ref IQueryable<SysRole> queryData)
		{

			List<Apps.Models.Sys.SysRoleModel> modelList = (from r in queryData
											  select new Apps.Models.Sys.SysRoleModel
											  {
													Id = r.Id,
													Name = r.Name,
													Description = r.Description,
													CreateTime = r.CreateTime,
													CreatePerson = r.CreatePerson,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.Sys.SysRoleModel model)
		{
				SysRole entity = m_Rep.GetById(model.Id);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new SysRole();
			   				entity.Id = model.Id;
				entity.Name = model.Name;
				entity.Description = model.Description;
				entity.CreateTime = model.CreateTime;
				entity.CreatePerson = model.CreatePerson;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.Sys.SysRoleModel model,params string[] updateProperties)
		{
				SysRole entity = m_Rep.GetById(model.Id);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							if (updateProperties.Count() <= 0){
										entity.Id = model.Id;
											entity.Name = model.Name;
											entity.Description = model.Description;
											entity.CreateTime = model.CreateTime;
											entity.CreatePerson = model.CreatePerson;
									}else{
					
						Type type = typeof(Apps.Models.Sys.SysRoleModel);
						Type typeE = typeof(Apps.Models.SysRole);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.Sys.SysRoleModel GetById(string id)
		{
			SysRole entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//SysRole entity = m_Rep.GetById(id);
				Apps.Models.Sys.SysRoleModel model = new Apps.Models.Sys.SysRoleModel();
							  				model.Id = entity.Id;
				model.Name = entity.Name;
				model.Description = entity.Description;
				model.CreateTime = entity.CreateTime;
				model.CreatePerson = entity.CreatePerson;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
