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
namespace Apps.Service.SCV.DOCUMENT
{
	public class Virtual_DOCUMENT_ROUTING_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.DOCUMENT.IDOCUMENT_ROUTING_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.DOCUMENT_ROUTING;
			}
		}
		

		public virtual List<Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL> GetList(Expression<Func<Apps.Models.DOCUMENT_ROUTING, bool>> where = null){
		
				IQueryable<Apps.Models.DOCUMENT_ROUTING> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.DOCUMENT_ROUTING, bool>> where,Expression<Func<Apps.Models.DOCUMENT_ROUTING, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.DOCUMENT_ROUTING> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.DOCUMENT_ROUTING, bool>> where = null)
		{

			IQueryable<Apps.Models.DOCUMENT_ROUTING> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								
								,a=>a.DOCUMENT_TYPE.Contains(queryStr)
								|| a.DOCUMENT_ID.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.CARRIER.Contains(queryStr)
								|| a.CONTAINER_TYPE.Contains(queryStr)
								
								|| a.DEVICE_NAME.Contains(queryStr)
								|| a.USER_ID.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.MACHINE_NAME.Contains(queryStr)
								|| a.CREATE_USER.Contains(queryStr)
								
								|| a.LAST_MODIFY_USER.Contains(queryStr)
								
								|| a.USER_DEF1.Contains(queryStr)
								|| a.USER_DEF2.Contains(queryStr)
								|| a.USER_DEF3.Contains(queryStr)
								|| a.USER_DEF4.Contains(queryStr)
								|| a.USER_DEF5.Contains(queryStr)
								|| a.USER_DEF6.Contains(queryStr)
								|| a.USER_DEF7.Contains(queryStr)
								|| a.USER_DEF8.Contains(queryStr)
								
								
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL> CreateModelList(ref IQueryable<Apps.Models.DOCUMENT_ROUTING> queryData)
		{

			List<Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL
											  {
													INTERNAL_NUM = r.INTERNAL_NUM,
													DOCUMENT_TYPE = r.DOCUMENT_TYPE,
													DOCUMENT_ID = r.DOCUMENT_ID,
													COMPANY = r.COMPANY,
													CARRIER = r.CARRIER,
													CONTAINER_TYPE = r.CONTAINER_TYPE,
													NUMBER_OF_COPIES = r.NUMBER_OF_COPIES,
													DEVICE_NAME = r.DEVICE_NAME,
													USER_ID = r.USER_ID,
													WAREHOUSE = r.WAREHOUSE,
													MACHINE_NAME = r.MACHINE_NAME,
													CREATE_USER = r.CREATE_USER,
													CREATE_DATE_TIME = r.CREATE_DATE_TIME,
													LAST_MODIFY_USER = r.LAST_MODIFY_USER,
													LAST_MODIFY_DATE_TIME = r.LAST_MODIFY_DATE_TIME,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													USER_DEF9 = r.USER_DEF9,
													USER_DEF10 = r.USER_DEF10,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL model)
		{
				Apps.Models.DOCUMENT_ROUTING entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.DOCUMENT_ROUTING();
			   				entity.INTERNAL_NUM = model.INTERNAL_NUM;
				entity.DOCUMENT_TYPE = model.DOCUMENT_TYPE;
				entity.DOCUMENT_ID = model.DOCUMENT_ID;
				entity.COMPANY = model.COMPANY;
				entity.CARRIER = model.CARRIER;
				entity.CONTAINER_TYPE = model.CONTAINER_TYPE;
				entity.NUMBER_OF_COPIES = model.NUMBER_OF_COPIES;
				entity.DEVICE_NAME = model.DEVICE_NAME;
				entity.USER_ID = model.USER_ID;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.MACHINE_NAME = model.MACHINE_NAME;
				entity.CREATE_USER = model.CREATE_USER;
				entity.CREATE_DATE_TIME = model.CREATE_DATE_TIME;
				entity.LAST_MODIFY_USER = model.LAST_MODIFY_USER;
				entity.LAST_MODIFY_DATE_TIME = model.LAST_MODIFY_DATE_TIME;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.USER_DEF9 = model.USER_DEF9;
				entity.USER_DEF10 = model.USER_DEF10;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL model,params string[] updateProperties)
		{
				Apps.Models.DOCUMENT_ROUTING entity = m_Rep.GetById(model.INTERNAL_NUM);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERNAL_NUM = model.INTERNAL_NUM;
											entity.DOCUMENT_TYPE = model.DOCUMENT_TYPE;
											entity.DOCUMENT_ID = model.DOCUMENT_ID;
											entity.COMPANY = model.COMPANY;
											entity.CARRIER = model.CARRIER;
											entity.CONTAINER_TYPE = model.CONTAINER_TYPE;
											entity.NUMBER_OF_COPIES = model.NUMBER_OF_COPIES;
											entity.DEVICE_NAME = model.DEVICE_NAME;
											entity.USER_ID = model.USER_ID;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.MACHINE_NAME = model.MACHINE_NAME;
											entity.CREATE_USER = model.CREATE_USER;
											entity.CREATE_DATE_TIME = model.CREATE_DATE_TIME;
											entity.LAST_MODIFY_USER = model.LAST_MODIFY_USER;
											entity.LAST_MODIFY_DATE_TIME = model.LAST_MODIFY_DATE_TIME;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.USER_DEF9 = model.USER_DEF9;
											entity.USER_DEF10 = model.USER_DEF10;
									}else{
					
						Type type = typeof(Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL);
						Type typeE = typeof(Apps.Models.DOCUMENT_ROUTING);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL GetById(string id)
		{
			Apps.Models.DOCUMENT_ROUTING entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//DOCUMENT_ROUTING entity = m_Rep.GetById(id);
				Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL model = new Apps.Models.SCV.DOCUMENT.DOCUMENT_ROUTING_MODEL();
							  				model.INTERNAL_NUM = entity.INTERNAL_NUM;
				model.DOCUMENT_TYPE = entity.DOCUMENT_TYPE;
				model.DOCUMENT_ID = entity.DOCUMENT_ID;
				model.COMPANY = entity.COMPANY;
				model.CARRIER = entity.CARRIER;
				model.CONTAINER_TYPE = entity.CONTAINER_TYPE;
				model.NUMBER_OF_COPIES = entity.NUMBER_OF_COPIES;
				model.DEVICE_NAME = entity.DEVICE_NAME;
				model.USER_ID = entity.USER_ID;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.MACHINE_NAME = entity.MACHINE_NAME;
				model.CREATE_USER = entity.CREATE_USER;
				model.CREATE_DATE_TIME = entity.CREATE_DATE_TIME;
				model.LAST_MODIFY_USER = entity.LAST_MODIFY_USER;
				model.LAST_MODIFY_DATE_TIME = entity.LAST_MODIFY_DATE_TIME;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.USER_DEF9 = entity.USER_DEF9;
				model.USER_DEF10 = entity.USER_DEF10;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
