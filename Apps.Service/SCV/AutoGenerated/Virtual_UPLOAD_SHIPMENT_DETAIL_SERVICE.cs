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
namespace Apps.Service.SCV.UPLOAD
{
	public class Virtual_UPLOAD_SHIPMENT_DETAIL_SERVICE
	{

		public Apps.IRepository.SCV.ISCVDBSession SCVDBSession{
			 get
			{
				return Service.SCV.SCVDBSessionFactory.GetDBSession();
			}
		}
	   
		public Apps.IRepository.SCV.UPLOAD.IUPLOAD_SHIPMENT_DETAIL_REPOSITORY m_Rep{
			 get
			{
				return SCVDBSession.UPLOAD_SHIPMENT_DETAIL;
			}
		}
		

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL> GetList(Expression<Func<Apps.Models.UPLOAD_SHIPMENT_DETAIL, bool>> where = null){
		
				IQueryable<Apps.Models.UPLOAD_SHIPMENT_DETAIL> queryData = m_Rep.GetList(where);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL> GetListSort<TKey>(Expression<Func<Apps.Models.UPLOAD_SHIPMENT_DETAIL, bool>> where,Expression<Func<Apps.Models.UPLOAD_SHIPMENT_DETAIL, TKey>>orderBy, bool isAsc = true){
		
				IQueryable<Apps.Models.UPLOAD_SHIPMENT_DETAIL> queryData = m_Rep.GetListSort(where, orderBy, isAsc);
				return CreateModelList(ref queryData);
		}

		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL> GetList(ref GridPager pager, string queryStr,Expression<Func<Apps.Models.UPLOAD_SHIPMENT_DETAIL, bool>> where = null)
		{

			IQueryable<Apps.Models.UPLOAD_SHIPMENT_DETAIL> queryData;
			
			if (!string.IsNullOrWhiteSpace(queryStr))
			{
				queryData = m_Rep.GetList(where
								,a=>a.INTERFACE_RECORD_ID.Contains(queryStr)
								|| a.INTERFACE_LINK_ID.Contains(queryStr)
								|| a.INTERFACE_ACTION_CODE.Contains(queryStr)
								|| a.INTERFACE_CONDITION.Contains(queryStr)
								|| a.PROCESS_STAMP.Contains(queryStr)
								|| a.WAREHOUSE.Contains(queryStr)
								|| a.COMPANY.Contains(queryStr)
								|| a.SHIPMENT_ID.Contains(queryStr)
								|| a.ERP_ORDER.Contains(queryStr)
								|| a.ERP_ORDER_LINE_NUM.Contains(queryStr)
								|| a.SHIPMENT_TYPE.Contains(queryStr)
								|| a.ITEM.Contains(queryStr)
								|| a.ITEM_DESC.Contains(queryStr)
								
								
								|| a.QUANTITY_UM.Contains(queryStr)
								|| a.ALLOCATION_RULE.Contains(queryStr)
								|| a.PICK_LOC.Contains(queryStr)
								|| a.USER_STAMP.Contains(queryStr)
								
								|| a.ATTRIBUTE_TRACK.Contains(queryStr)
								|| a.ATTRIBUTE1.Contains(queryStr)
								|| a.ATTRIBUTE2.Contains(queryStr)
								|| a.ATTRIBUTE3.Contains(queryStr)
								|| a.ATTRIBUTE4.Contains(queryStr)
								|| a.ATTRIBUTE5.Contains(queryStr)
								|| a.ATTRIBUTE6.Contains(queryStr)
								|| a.ATTRIBUTE7.Contains(queryStr)
								|| a.ATTRIBUTE8.Contains(queryStr)
								|| a.INVENTORY_STS.Contains(queryStr)
								|| a.DOCK_LOC.Contains(queryStr)
								|| a.PACKING_CLASS.Contains(queryStr)
								
								
								
								|| a.WEIGHT_UM.Contains(queryStr)
								
								|| a.VOLUME_UM.Contains(queryStr)
								
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
		public virtual List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL> CreateModelList(ref IQueryable<Apps.Models.UPLOAD_SHIPMENT_DETAIL> queryData)
		{

			List<Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL> modelList = (from r in queryData
											  select new Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL
											  {
													INTERFACE_RECORD_ID = r.INTERFACE_RECORD_ID,
													INTERFACE_LINK_ID = r.INTERFACE_LINK_ID,
													INTERFACE_ACTION_CODE = r.INTERFACE_ACTION_CODE,
													INTERFACE_CONDITION = r.INTERFACE_CONDITION,
													PROCESS_STAMP = r.PROCESS_STAMP,
													WAREHOUSE = r.WAREHOUSE,
													COMPANY = r.COMPANY,
													SHIPMENT_ID = r.SHIPMENT_ID,
													ERP_ORDER = r.ERP_ORDER,
													ERP_ORDER_LINE_NUM = r.ERP_ORDER_LINE_NUM,
													SHIPMENT_TYPE = r.SHIPMENT_TYPE,
													ITEM = r.ITEM,
													ITEM_DESC = r.ITEM_DESC,
													TOTAL_QTY = r.TOTAL_QTY,
													REQUEST_QTY = r.REQUEST_QTY,
													QUANTITY_UM = r.QUANTITY_UM,
													ALLOCATION_RULE = r.ALLOCATION_RULE,
													PICK_LOC = r.PICK_LOC,
													USER_STAMP = r.USER_STAMP,
													DATE_TIME_STAMP = r.DATE_TIME_STAMP,
													ATTRIBUTE_TRACK = r.ATTRIBUTE_TRACK,
													ATTRIBUTE1 = r.ATTRIBUTE1,
													ATTRIBUTE2 = r.ATTRIBUTE2,
													ATTRIBUTE3 = r.ATTRIBUTE3,
													ATTRIBUTE4 = r.ATTRIBUTE4,
													ATTRIBUTE5 = r.ATTRIBUTE5,
													ATTRIBUTE6 = r.ATTRIBUTE6,
													ATTRIBUTE7 = r.ATTRIBUTE7,
													ATTRIBUTE8 = r.ATTRIBUTE8,
													INVENTORY_STS = r.INVENTORY_STS,
													DOCK_LOC = r.DOCK_LOC,
													PACKING_CLASS = r.PACKING_CLASS,
													STATUS = r.STATUS,
													INTERNAL_WAVE_NUM = r.INTERNAL_WAVE_NUM,
													TOTAL_WEIGHT = r.TOTAL_WEIGHT,
													WEIGHT_UM = r.WEIGHT_UM,
													TOTAL_VOLUME = r.TOTAL_VOLUME,
													VOLUME_UM = r.VOLUME_UM,
													BACK_ORDER_LINE_NUM = r.BACK_ORDER_LINE_NUM,
													USER_DEF1 = r.USER_DEF1,
													USER_DEF2 = r.USER_DEF2,
													USER_DEF3 = r.USER_DEF3,
													USER_DEF4 = r.USER_DEF4,
													USER_DEF5 = r.USER_DEF5,
													USER_DEF6 = r.USER_DEF6,
													USER_DEF7 = r.USER_DEF7,
													USER_DEF8 = r.USER_DEF8,
													ITEM_LIST_PRICE = r.ITEM_LIST_PRICE,
													ITEM_NET_PRICE = r.ITEM_NET_PRICE,
													SERIAL_NUM_TRACK = r.SERIAL_NUM_TRACK,
          
											  }).ToList();

			return modelList;
		}

		public virtual void Create(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL model)
		{
				Apps.Models.UPLOAD_SHIPMENT_DETAIL entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity != null)
				{
					errors.Add(Resource.PrimaryRepeat);
					return;
				}
				entity = new Apps.Models.UPLOAD_SHIPMENT_DETAIL();
			   				entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
				entity.INTERFACE_LINK_ID = model.INTERFACE_LINK_ID;
				entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
				entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
				entity.PROCESS_STAMP = model.PROCESS_STAMP;
				entity.WAREHOUSE = model.WAREHOUSE;
				entity.COMPANY = model.COMPANY;
				entity.SHIPMENT_ID = model.SHIPMENT_ID;
				entity.ERP_ORDER = model.ERP_ORDER;
				entity.ERP_ORDER_LINE_NUM = model.ERP_ORDER_LINE_NUM;
				entity.SHIPMENT_TYPE = model.SHIPMENT_TYPE;
				entity.ITEM = model.ITEM;
				entity.ITEM_DESC = model.ITEM_DESC;
				entity.TOTAL_QTY = model.TOTAL_QTY;
				entity.REQUEST_QTY = model.REQUEST_QTY;
				entity.QUANTITY_UM = model.QUANTITY_UM;
				entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
				entity.PICK_LOC = model.PICK_LOC;
				entity.USER_STAMP = model.USER_STAMP;
				entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
				entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
				entity.ATTRIBUTE1 = model.ATTRIBUTE1;
				entity.ATTRIBUTE2 = model.ATTRIBUTE2;
				entity.ATTRIBUTE3 = model.ATTRIBUTE3;
				entity.ATTRIBUTE4 = model.ATTRIBUTE4;
				entity.ATTRIBUTE5 = model.ATTRIBUTE5;
				entity.ATTRIBUTE6 = model.ATTRIBUTE6;
				entity.ATTRIBUTE7 = model.ATTRIBUTE7;
				entity.ATTRIBUTE8 = model.ATTRIBUTE8;
				entity.INVENTORY_STS = model.INVENTORY_STS;
				entity.DOCK_LOC = model.DOCK_LOC;
				entity.PACKING_CLASS = model.PACKING_CLASS;
				entity.STATUS = model.STATUS;
				entity.INTERNAL_WAVE_NUM = model.INTERNAL_WAVE_NUM;
				entity.TOTAL_WEIGHT = model.TOTAL_WEIGHT;
				entity.WEIGHT_UM = model.WEIGHT_UM;
				entity.TOTAL_VOLUME = model.TOTAL_VOLUME;
				entity.VOLUME_UM = model.VOLUME_UM;
				entity.BACK_ORDER_LINE_NUM = model.BACK_ORDER_LINE_NUM;
				entity.USER_DEF1 = model.USER_DEF1;
				entity.USER_DEF2 = model.USER_DEF2;
				entity.USER_DEF3 = model.USER_DEF3;
				entity.USER_DEF4 = model.USER_DEF4;
				entity.USER_DEF5 = model.USER_DEF5;
				entity.USER_DEF6 = model.USER_DEF6;
				entity.USER_DEF7 = model.USER_DEF7;
				entity.USER_DEF8 = model.USER_DEF8;
				entity.ITEM_LIST_PRICE = model.ITEM_LIST_PRICE;
				entity.ITEM_NET_PRICE = model.ITEM_NET_PRICE;
				entity.SERIAL_NUM_TRACK = model.SERIAL_NUM_TRACK;
  
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

		
	   

		public virtual void Modify(ref ValidationErrors errors, Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL model,params string[] updateProperties)
		{
				Apps.Models.UPLOAD_SHIPMENT_DETAIL entity = m_Rep.GetById(model.INTERFACE_RECORD_ID);
				if (entity == null)
				{
					errors.Add(Resource.Disable);
					return;
				}
							  				if (updateProperties.Count() <= 0){
										entity.INTERFACE_RECORD_ID = model.INTERFACE_RECORD_ID;
											entity.INTERFACE_LINK_ID = model.INTERFACE_LINK_ID;
											entity.INTERFACE_ACTION_CODE = model.INTERFACE_ACTION_CODE;
											entity.INTERFACE_CONDITION = model.INTERFACE_CONDITION;
											entity.PROCESS_STAMP = model.PROCESS_STAMP;
											entity.WAREHOUSE = model.WAREHOUSE;
											entity.COMPANY = model.COMPANY;
											entity.SHIPMENT_ID = model.SHIPMENT_ID;
											entity.ERP_ORDER = model.ERP_ORDER;
											entity.ERP_ORDER_LINE_NUM = model.ERP_ORDER_LINE_NUM;
											entity.SHIPMENT_TYPE = model.SHIPMENT_TYPE;
											entity.ITEM = model.ITEM;
											entity.ITEM_DESC = model.ITEM_DESC;
											entity.TOTAL_QTY = model.TOTAL_QTY;
											entity.REQUEST_QTY = model.REQUEST_QTY;
											entity.QUANTITY_UM = model.QUANTITY_UM;
											entity.ALLOCATION_RULE = model.ALLOCATION_RULE;
											entity.PICK_LOC = model.PICK_LOC;
											entity.USER_STAMP = model.USER_STAMP;
											entity.DATE_TIME_STAMP = model.DATE_TIME_STAMP;
											entity.ATTRIBUTE_TRACK = model.ATTRIBUTE_TRACK;
											entity.ATTRIBUTE1 = model.ATTRIBUTE1;
											entity.ATTRIBUTE2 = model.ATTRIBUTE2;
											entity.ATTRIBUTE3 = model.ATTRIBUTE3;
											entity.ATTRIBUTE4 = model.ATTRIBUTE4;
											entity.ATTRIBUTE5 = model.ATTRIBUTE5;
											entity.ATTRIBUTE6 = model.ATTRIBUTE6;
											entity.ATTRIBUTE7 = model.ATTRIBUTE7;
											entity.ATTRIBUTE8 = model.ATTRIBUTE8;
											entity.INVENTORY_STS = model.INVENTORY_STS;
											entity.DOCK_LOC = model.DOCK_LOC;
											entity.PACKING_CLASS = model.PACKING_CLASS;
											entity.STATUS = model.STATUS;
											entity.INTERNAL_WAVE_NUM = model.INTERNAL_WAVE_NUM;
											entity.TOTAL_WEIGHT = model.TOTAL_WEIGHT;
											entity.WEIGHT_UM = model.WEIGHT_UM;
											entity.TOTAL_VOLUME = model.TOTAL_VOLUME;
											entity.VOLUME_UM = model.VOLUME_UM;
											entity.BACK_ORDER_LINE_NUM = model.BACK_ORDER_LINE_NUM;
											entity.USER_DEF1 = model.USER_DEF1;
											entity.USER_DEF2 = model.USER_DEF2;
											entity.USER_DEF3 = model.USER_DEF3;
											entity.USER_DEF4 = model.USER_DEF4;
											entity.USER_DEF5 = model.USER_DEF5;
											entity.USER_DEF6 = model.USER_DEF6;
											entity.USER_DEF7 = model.USER_DEF7;
											entity.USER_DEF8 = model.USER_DEF8;
											entity.ITEM_LIST_PRICE = model.ITEM_LIST_PRICE;
											entity.ITEM_NET_PRICE = model.ITEM_NET_PRICE;
											entity.SERIAL_NUM_TRACK = model.SERIAL_NUM_TRACK;
									}else{
					
						Type type = typeof(Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL);
						Type typeE = typeof(Apps.Models.UPLOAD_SHIPMENT_DETAIL);
						foreach (var item in updateProperties) {
						System.Reflection.PropertyInfo pi = type.GetProperty(item);
						System.Reflection.PropertyInfo piE = typeE.GetProperty(item);
						piE.SetValue(entity,pi.GetValue(model),null);
				}
				}
				 

				m_Rep.Modify(entity,updateProperties);
		}

	  

		public virtual Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL GetById(string id)
		{
			Apps.Models.UPLOAD_SHIPMENT_DETAIL entity = m_Rep.GetById(id);
			if (entity!=null)
			{
				//UPLOAD_SHIPMENT_DETAIL entity = m_Rep.GetById(id);
				Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL model = new Apps.Models.SCV.UPLOAD.UPLOAD_SHIPMENT_DETAIL_MODEL();
							  				model.INTERFACE_RECORD_ID = entity.INTERFACE_RECORD_ID;
				model.INTERFACE_LINK_ID = entity.INTERFACE_LINK_ID;
				model.INTERFACE_ACTION_CODE = entity.INTERFACE_ACTION_CODE;
				model.INTERFACE_CONDITION = entity.INTERFACE_CONDITION;
				model.PROCESS_STAMP = entity.PROCESS_STAMP;
				model.WAREHOUSE = entity.WAREHOUSE;
				model.COMPANY = entity.COMPANY;
				model.SHIPMENT_ID = entity.SHIPMENT_ID;
				model.ERP_ORDER = entity.ERP_ORDER;
				model.ERP_ORDER_LINE_NUM = entity.ERP_ORDER_LINE_NUM;
				model.SHIPMENT_TYPE = entity.SHIPMENT_TYPE;
				model.ITEM = entity.ITEM;
				model.ITEM_DESC = entity.ITEM_DESC;
				model.TOTAL_QTY = entity.TOTAL_QTY;
				model.REQUEST_QTY = entity.REQUEST_QTY;
				model.QUANTITY_UM = entity.QUANTITY_UM;
				model.ALLOCATION_RULE = entity.ALLOCATION_RULE;
				model.PICK_LOC = entity.PICK_LOC;
				model.USER_STAMP = entity.USER_STAMP;
				model.DATE_TIME_STAMP = entity.DATE_TIME_STAMP;
				model.ATTRIBUTE_TRACK = entity.ATTRIBUTE_TRACK;
				model.ATTRIBUTE1 = entity.ATTRIBUTE1;
				model.ATTRIBUTE2 = entity.ATTRIBUTE2;
				model.ATTRIBUTE3 = entity.ATTRIBUTE3;
				model.ATTRIBUTE4 = entity.ATTRIBUTE4;
				model.ATTRIBUTE5 = entity.ATTRIBUTE5;
				model.ATTRIBUTE6 = entity.ATTRIBUTE6;
				model.ATTRIBUTE7 = entity.ATTRIBUTE7;
				model.ATTRIBUTE8 = entity.ATTRIBUTE8;
				model.INVENTORY_STS = entity.INVENTORY_STS;
				model.DOCK_LOC = entity.DOCK_LOC;
				model.PACKING_CLASS = entity.PACKING_CLASS;
				model.STATUS = entity.STATUS;
				model.INTERNAL_WAVE_NUM = entity.INTERNAL_WAVE_NUM;
				model.TOTAL_WEIGHT = entity.TOTAL_WEIGHT;
				model.WEIGHT_UM = entity.WEIGHT_UM;
				model.TOTAL_VOLUME = entity.TOTAL_VOLUME;
				model.VOLUME_UM = entity.VOLUME_UM;
				model.BACK_ORDER_LINE_NUM = entity.BACK_ORDER_LINE_NUM;
				model.USER_DEF1 = entity.USER_DEF1;
				model.USER_DEF2 = entity.USER_DEF2;
				model.USER_DEF3 = entity.USER_DEF3;
				model.USER_DEF4 = entity.USER_DEF4;
				model.USER_DEF5 = entity.USER_DEF5;
				model.USER_DEF6 = entity.USER_DEF6;
				model.USER_DEF7 = entity.USER_DEF7;
				model.USER_DEF8 = entity.USER_DEF8;
				model.ITEM_LIST_PRICE = entity.ITEM_LIST_PRICE;
				model.ITEM_NET_PRICE = entity.ITEM_NET_PRICE;
				model.SERIAL_NUM_TRACK = entity.SERIAL_NUM_TRACK;
 
				return model;
			}
			else
			{
				return null;
			}
		}

	 

	}
}
