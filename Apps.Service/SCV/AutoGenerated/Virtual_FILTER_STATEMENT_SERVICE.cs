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
namespace Apps.Service.SCV.FILTER
{
	public class Virtual_FILTER_STATEMENT_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.FILTER.IFILTER_STATEMENT_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.FILTER_STATEMENT;
			}
		}
		

		public virtual List<Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL> GetList(Expression<Func<Apps.Models.FILTER_STATEMENT, bool>> where = null){
		
				IQueryable<Apps.Models.FILTER_STATEMENT> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.FILTER_STATEMENT, bool>> where,Expression<Func<Apps.Models.FILTER_STATEMENT, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.FILTER_STATEMENT> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.FILTER_STATEMENT, bool>> where = null)
		{

			IQueryable<Apps.Models.FILTER_STATEMENT> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.RECORD_TYPE.Contains(queryStr)
								|| a.FILTER_NAME.Contains(queryStr)
								
								
								|| a.AND_OR.Contains(queryStr)
								|| a.ATTRIBUTE.Contains(queryStr)
								|| a.OPERAND.Contains(queryStr)
								|| a.LITERAL_VALUE.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								
								
								
								|| a.LITERAL_TYPE.Contains(queryStr)
								);
			}else{
				queryData = m_Rep.GetList(where);
			}
			
		  
			pager.totalRows = queryData.Count();
			//排序
			queryData = LinqHelper.SortingAndPaging(queryData, pager.sort, pager.order, pager.page, pager.rows);
			return CreateModelList(ref queryData);
		}
		public virtual List<Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL> CreateModelList(ref IQueryable<Apps.Models.FILTER_STATEMENT> queryData)
		{

			List<Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL
											  {
													RECORD_TYPE = r.RECORD_TYPE,
													FILTER_NAME = r.FILTER_NAME,
													SEQUENCE = r.SEQUENCE,
													FILTER_NUM = r.FILTER_NUM,
													AND_OR = r.AND_OR,
													ATTRIBUTE = r.ATTRIBUTE,
													OPERAND = r.OPERAND,
													LITERAL_VALUE = r.LITERAL_VALUE,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													LEFT_PAREN = r.LEFT_PAREN,
													RIGHT_PAREN = r.RIGHT_PAREN,
													OBJECT_ID = r.OBJECT_ID,
													LITERAL_TYPE = r.LITERAL_TYPE,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL model)
		{
				Apps.Models.FILTER_STATEMENT entity = m_Rep.GetById(model.RECORD_TYPE);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.FILTER_STATEMENT();
			   				entity.RECORD_TYPE = model.RECORD_TYPE;
				entity.FILTER_NAME = model.FILTER_NAME;
				entity.SEQUENCE = model.SEQUENCE;
				entity.FILTER_NUM = model.FILTER_NUM;
				entity.AND_OR = model.AND_OR;
				entity.ATTRIBUTE = model.ATTRIBUTE;
				entity.OPERAND = model.OPERAND;
				entity.LITERAL_VALUE = model.LITERAL_VALUE;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.LEFT_PAREN = model.LEFT_PAREN;
				entity.RIGHT_PAREN = model.RIGHT_PAREN;
				entity.OBJECT_ID = model.OBJECT_ID;
				entity.LITERAL_TYPE = model.LITERAL_TYPE;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL model,params string[] updateProperties)
		{
				Apps.Models.FILTER_STATEMENT entity = m_Rep.GetById(model.RECORD_TYPE);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.RECORD_TYPE = model.RECORD_TYPE;
											entity.FILTER_NAME = model.FILTER_NAME;
											entity.SEQUENCE = model.SEQUENCE;
											entity.FILTER_NUM = model.FILTER_NUM;
											entity.AND_OR = model.AND_OR;
											entity.ATTRIBUTE = model.ATTRIBUTE;
											entity.OPERAND = model.OPERAND;
											entity.LITERAL_VALUE = model.LITERAL_VALUE;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.LEFT_PAREN = model.LEFT_PAREN;
											entity.RIGHT_PAREN = model.RIGHT_PAREN;
											entity.OBJECT_ID = model.OBJECT_ID;
											entity.LITERAL_TYPE = model.LITERAL_TYPE;
									}else{
					
						Type type = typeof(Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL);
						Type typeE = typeof(Apps.Models.FILTER_STATEMENT);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL GetById(string id)
		{
			Apps.Models.FILTER_STATEMENT entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//FILTER_STATEMENT entity = m_Rep.GetById(id);
				Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL model = new Apps.Models.SCV.FILTER.FILTER_STATEMENT_MODEL();
							  				model.RECORD_TYPE = entity.RECORD_TYPE;
				model.FILTER_NAME = entity.FILTER_NAME;
				model.SEQUENCE = entity.SEQUENCE;
				model.FILTER_NUM = entity.FILTER_NUM;
				model.AND_OR = entity.AND_OR;
				model.ATTRIBUTE = entity.ATTRIBUTE;
				model.OPERAND = entity.OPERAND;
				model.LITERAL_VALUE = entity.LITERAL_VALUE;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.LEFT_PAREN = entity.LEFT_PAREN;
				model.RIGHT_PAREN = entity.RIGHT_PAREN;
				model.OBJECT_ID = entity.OBJECT_ID;
				model.LITERAL_TYPE = entity.LITERAL_TYPE;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
