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
namespace Apps.Service.SCV.Sys
{
	public class Virtual_AREAS_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.Sys.IAREAS_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.AREAS;
			}
		}
		

		public virtual List<Apps.Models.SCV.Sys.AREAS_MODEL> GetList(Expression<Func<Apps.Models.AREAS, bool>> where = null){
		
				IQueryable<Apps.Models.AREAS> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.AREAS_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.AREAS, bool>> where,Expression<Func<Apps.Models.AREAS, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.AREAS> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.Sys.AREAS_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.AREAS, bool>> where = null)
		{

			IQueryable<Apps.Models.AREAS> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.ID.Contains(queryStr)
								|| a.PARENT_ID.Contains(queryStr)
								|| a.TYPE.Contains(queryStr)
								|| a.ZIP.Contains(queryStr)
								|| a.NAME.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.Sys.AREAS_MODEL> CreateModelList(ref IQueryable<Apps.Models.AREAS> queryData)
		{

			List<Apps.Models.SCV.Sys.AREAS_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.Sys.AREAS_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													ID = r.ID,
													PARENT_ID = r.PARENT_ID,
													TYPE = r.TYPE,
													ZIP = r.ZIP,
													NAME = r.NAME,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.Sys.AREAS_MODEL model)
		{
				Apps.Models.AREAS entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.AREAS();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.ID = model.ID;
				entity.PARENT_ID = model.PARENT_ID;
				entity.TYPE = model.TYPE;
				entity.ZIP = model.ZIP;
				entity.NAME = model.NAME;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.Sys.AREAS_MODEL model,params string[] updateProperties)
		{
				Apps.Models.AREAS entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.ID = model.ID;
											entity.PARENT_ID = model.PARENT_ID;
											entity.TYPE = model.TYPE;
											entity.ZIP = model.ZIP;
											entity.NAME = model.NAME;
									}else{
					
						Type type = typeof(Apps.Models.SCV.Sys.AREAS_MODEL);
						Type typeE = typeof(Apps.Models.AREAS);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.Sys.AREAS_MODEL GetById(string id)
		{
			Apps.Models.AREAS entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//AREAS entity = m_Rep.GetById(id);
				Apps.Models.SCV.Sys.AREAS_MODEL model = new Apps.Models.SCV.Sys.AREAS_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.ID = entity.ID;
				model.PARENT_ID = entity.PARENT_ID;
				model.TYPE = entity.TYPE;
				model.ZIP = entity.ZIP;
				model.NAME = entity.NAME;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
