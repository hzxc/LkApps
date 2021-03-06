﻿
 //------------------------------------------------------------------------------
// <auto-generated>
// 数据仓储接口，作用：
// 1.调用EF容器 批量 执行 sql语句
// 2.方便通过 子接口属性直接 获取 对应数据表的操作接口对象
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.IRepository.SCV
{
    using System;
    public partial interface ISCVDBSession
    {
    	
    	ALLOCATION.IALLOCATION_RULE_DETAIL_REPOSITORY ALLOCATION_RULE_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	ALLOCATION.IALLOCATION_RULE_HEADER_REPOSITORY ALLOCATION_RULE_HEADER 
    	{ 
    		get;
    	}
    
    	
    	Sys.IAPPOINTMENT_REPOSITORY APPOINTMENT 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_RECEIPT_CONTAINER_REPOSITORY AR_RECEIPT_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_RECEIPT_DETAIL_REPOSITORY AR_RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_RECEIPT_HEADER_REPOSITORY AR_RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_TASK_DETAIL_REPOSITORY AR_TASK_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_TASK_HEADER_REPOSITORY AR_TASK_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_TRANSACTION_HISTORY_REPOSITORY AR_TRANSACTION_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	Sys.IAREAS_REPOSITORY AREAS 
    	{ 
    		get;
    	}
    
    	
    	Sys.IATTRIBUTE_REPOSITORY ATTRIBUTE 
    	{ 
    		get;
    	}
    
    	
    	ATTRIBUTE.IATTRIBUTE_TEMPLATE_REPOSITORY ATTRIBUTE_TEMPLATE 
    	{ 
    		get;
    	}
    
    	
    	AUDIT.IAUDIT_LOG_REPOSITORY AUDIT_LOG 
    	{ 
    		get;
    	}
    
    	
    	BOM.IBOM_DETAIL_REPOSITORY BOM_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	BOM.IBOM_HEADER_REPOSITORY BOM_HEADER 
    	{ 
    		get;
    	}
    
    	
    	CART.ICART_DETAIL_REPOSITORY CART_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	CART.ICART_HEADER_REPOSITORY CART_HEADER 
    	{ 
    		get;
    	}
    
    	
    	Sys.ICOMPANY_REPOSITORY COMPANY 
    	{ 
    		get;
    	}
    
    	
    	Sys.ICOMPANYSTATE_REPOSITORY COMPANYSTATE 
    	{ 
    		get;
    	}
    
    	
    	CONFIG.ICONFIG_VALUE_REPOSITORY CONFIG_VALUE 
    	{ 
    		get;
    	}
    
    	
    	CONTAINER.ICONTAINER_TYPE_REPOSITORY CONTAINER_TYPE 
    	{ 
    		get;
    	}
    
    	
    	CUSTOM.ICUSTOM_RESOURCE_REPOSITORY CUSTOM_RESOURCE 
    	{ 
    		get;
    	}
    
    	
    	Sys.ICUSTOMER_REPOSITORY CUSTOMER 
    	{ 
    		get;
    	}
    
    	
    	CYCLE.ICYCLE_COUNT_DETAIL_REPOSITORY CYCLE_COUNT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	CYCLE.ICYCLE_COUNT_HEADER_REPOSITORY CYCLE_COUNT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	CYCLE.ICYCLE_COUNT_MASTER_REPOSITORY CYCLE_COUNT_MASTER 
    	{ 
    		get;
    	}
    
    	
    	DOCUMENT.IDOCUMENT_ROUTING_REPOSITORY DOCUMENT_ROUTING 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_COMPANY_REPOSITORY DOWNLOAD_COMPANY 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_ITEM_REPOSITORY DOWNLOAD_ITEM 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_ITEM_BARCODE_REPOSITORY DOWNLOAD_ITEM_BARCODE 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_ITEM_UNIT_OF_MEASURE_REPOSITORY DOWNLOAD_ITEM_UNIT_OF_MEASURE 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_ITEMS_REPOSITORY DOWNLOAD_ITEMS 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_RECEIPT_DETAIL_REPOSITORY DOWNLOAD_RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_RECEIPT_HEADER_REPOSITORY DOWNLOAD_RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_RECEIPTS_REPOSITORY DOWNLOAD_RECEIPTS 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_SHIPMENT_DETAIL_REPOSITORY DOWNLOAD_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_SHIPMENT_HEADER_REPOSITORY DOWNLOAD_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_SHIPMENTS_REPOSITORY DOWNLOAD_SHIPMENTS 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_SHIPMENTS_UPDATE_REPOSITORY DOWNLOAD_SHIPMENTS_UPDATE 
    	{ 
    		get;
    	}
    
    	
    	DYNAMIC.IDYNAMIC_CALLING_DETAIL_REPOSITORY DYNAMIC_CALLING_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	DYNAMIC.IDYNAMIC_CALLING_HEADER_REPOSITORY DYNAMIC_CALLING_HEADER 
    	{ 
    		get;
    	}
    
    	
    	EX.IEX_MENU_REPOSITORY EX_MENU 
    	{ 
    		get;
    	}
    
    	
    	FILTER.IFILTER_CONFIG_DETAIL_REPOSITORY FILTER_CONFIG_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	FILTER.IFILTER_GROUP_BY_REPOSITORY FILTER_GROUP_BY 
    	{ 
    		get;
    	}
    
    	
    	FILTER.IFILTER_ORDER_BY_REPOSITORY FILTER_ORDER_BY 
    	{ 
    		get;
    	}
    
    	
    	FILTER.IFILTER_STATEMENT_REPOSITORY FILTER_STATEMENT 
    	{ 
    		get;
    	}
    
    	
    	GENERIC.IGENERIC_CONFIG_DETAIL_REPOSITORY GENERIC_CONFIG_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	GENERIC.IGENERIC_CONFIG_HEADER_REPOSITORY GENERIC_CONFIG_HEADER 
    	{ 
    		get;
    	}
    
    	
    	INTERFACE.IINTERFACE_FAILURE_REPOSITORY INTERFACE_FAILURE 
    	{ 
    		get;
    	}
    
    	
    	INTERFACE.IINTERFACE_PROCESS_REPOSITORY INTERFACE_PROCESS 
    	{ 
    		get;
    	}
    
    	
    	INTERFACE.IINTERFACE_SESSION_REPOSITORY INTERFACE_SESSION 
    	{ 
    		get;
    	}
    
    	
    	INTERFACE.IINTERFACE_TABLE_STATISTIC_REPOSITORY INTERFACE_TABLE_STATISTIC 
    	{ 
    		get;
    	}
    
    	
    	INVENTORY.IINVENTORY_TRANSACTION_REPOSITORY INVENTORY_TRANSACTION 
    	{ 
    		get;
    	}
    
    	
    	Sys.IITEM_REPOSITORY ITEM 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_BARCODE_REPOSITORY ITEM_BARCODE 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_BEIYONG_REPOSITORY ITEM_BEIYONG 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_BEIYONG1_REPOSITORY ITEM_BEIYONG1 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_LOCATION_CAPACITY_REPOSITORY ITEM_LOCATION_CAPACITY 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_UNIT_OF_MEASURE_REPOSITORY ITEM_UNIT_OF_MEASURE 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_WEIGHT_HIS_REPOSITORY ITEM_WEIGHT_HIS 
    	{ 
    		get;
    	}
    
    	
    	ITEM.IITEM_ZONE_CAPACITY_REPOSITORY ITEM_ZONE_CAPACITY 
    	{ 
    		get;
    	}
    
    	
    	LOCATING.ILOCATING_RULE_DETAIL_REPOSITORY LOCATING_RULE_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	LOCATING.ILOCATING_RULE_HEADER_REPOSITORY LOCATING_RULE_HEADER 
    	{ 
    		get;
    	}
    
    	
    	Sys.ILOCATION_REPOSITORY LOCATION 
    	{ 
    		get;
    	}
    
    	
    	LOCATION.ILOCATION_CARRIER_REPOSITORY LOCATION_CARRIER 
    	{ 
    		get;
    	}
    
    	
    	LOCATION.ILOCATION_INVENTORY_REPOSITORY LOCATION_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	LOCATION.ILOCATION_SELECTION_REPOSITORY LOCATION_SELECTION 
    	{ 
    		get;
    	}
    
    	
    	MISC.IMISC_INVENTORY_HANDLING_REPOSITORY MISC_INVENTORY_HANDLING 
    	{ 
    		get;
    	}
    
    	
    	NEXT.INEXT_NUMBER_REPOSITORY NEXT_NUMBER 
    	{ 
    		get;
    	}
    
    	
    	PACKING.IPACKING_CLASS_REPOSITORY PACKING_CLASS 
    	{ 
    		get;
    	}
    
    	
    	PACKING.IPACKING_PREFERENCE_REPOSITORY PACKING_PREFERENCE 
    	{ 
    		get;
    	}
    
    	
    	PROCESS.IPROCESS_HISTORY_REPOSITORY PROCESS_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	PURCHASE.IPURCHASE_ORDER_DETAIL_REPOSITORY PURCHASE_ORDER_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	PURCHASE.IPURCHASE_ORDER_HEADER_REPOSITORY PURCHASE_ORDER_HEADER 
    	{ 
    		get;
    	}
    
    	
    	QUEUE.IQUEUE_TASK_IN_CONFIRM_REPOSITORY QUEUE_TASK_IN_CONFIRM 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_CONTAINER_REPOSITORY RECEIPT_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_DETAIL_REPOSITORY RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_HEADER_REPOSITORY RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_HEADER_TEMP_REPOSITORY RECEIPT_HEADER_TEMP 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_LOCATE_REQUEST_REPOSITORY RECEIPT_LOCATE_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	RECEIVING.IRECEIVING_PREFERENCE_REPOSITORY RECEIVING_PREFERENCE 
    	{ 
    		get;
    	}
    
    	
    	Sys.IREPLENISHMENT_REPOSITORY REPLENISHMENT 
    	{ 
    		get;
    	}
    
    	
    	REPLENISHMENT.IREPLENISHMENT_MASTER_REPOSITORY REPLENISHMENT_MASTER 
    	{ 
    		get;
    	}
    
    	
    	REPLENISHMENT.IREPLENISHMENT_REQUEST_REPOSITORY REPLENISHMENT_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	REPORT.IREPORT_CONNECTION_REPOSITORY REPORT_CONNECTION 
    	{ 
    		get;
    	}
    
    	
    	RETURNED.IRETURNED_PACKAGE_REPOSITORY RETURNED_PACKAGE 
    	{ 
    		get;
    	}
    
    	
    	RULE.IRULE_ASSIGNMENT_DETAIL_REPOSITORY RULE_ASSIGNMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	RULE.IRULE_ASSIGNMENT_HEADER_REPOSITORY RULE_ASSIGNMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	SCHEDULE.ISCHEDULE_JOB_REPOSITORY SCHEDULE_JOB 
    	{ 
    		get;
    	}
    
    	
    	SCHEDULE.ISCHEDULE_JOB_HISTORY_REPOSITORY SCHEDULE_JOB_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	SCHEDULE.ISCHEDULE_JOB_TYPE_REPOSITORY SCHEDULE_JOB_TYPE 
    	{ 
    		get;
    	}
    
    	
    	SECURITY.ISECURITY_FUNCTION_REPOSITORY SECURITY_FUNCTION 
    	{ 
    		get;
    	}
    
    	
    	SECURITY.ISECURITY_ROLE_DETAIL_REPOSITORY SECURITY_ROLE_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	SECURITY.ISECURITY_ROLE_HEADER_REPOSITORY SECURITY_ROLE_HEADER 
    	{ 
    		get;
    	}
    
    	
    	SERIAL.ISERIAL_NUMBER_REPOSITORY SERIAL_NUMBER 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_ALLOC_REQUEST_REPOSITORY SHIPMENT_ALLOC_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_CARRIER_EDITRULE_REPOSITORY SHIPMENT_CARRIER_EDITRULE 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_DETAIL_REPOSITORY SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_EXPRESS_REPOSITORY SHIPMENT_EXPRESS 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_HEADER_REPOSITORY SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_HEADER_TEMP_REPOSITORY SHIPMENT_HEADER_TEMP 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_HEADER_TEMP1_REPOSITORY SHIPMENT_HEADER_TEMP1 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_INVOICE_REPOSITORY SHIPMENT_INVOICE 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_SERIAL_NUMBER_REPOSITORY SHIPMENT_SERIAL_NUMBER 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_TRACKING_NUMBER_REPOSITORY SHIPMENT_TRACKING_NUMBER 
    	{ 
    		get;
    	}
    
    	
    	SHIPPING.ISHIPPING_CART_DETAIL_REPOSITORY SHIPPING_CART_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	SHIPPING.ISHIPPING_CART_HEADER_REPOSITORY SHIPPING_CART_HEADER 
    	{ 
    		get;
    	}
    
    	
    	SHIPPING.ISHIPPING_CONTAINER_REPOSITORY SHIPPING_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	SHIPPING.ISHIPPING_CONTAINER_HIS_REPOSITORY SHIPPING_CONTAINER_HIS 
    	{ 
    		get;
    	}
    
    	
    	SHIPPING.ISHIPPING_LOAD_REPOSITORY SHIPPING_LOAD 
    	{ 
    		get;
    	}
    
    	
    	STATISTICS.ISTATISTICS_REPORT_REPOSITORY STATISTICS_REPORT 
    	{ 
    		get;
    	}
    
    	
    	STATUS.ISTATUS_FLOW_DETAIL_REPOSITORY STATUS_FLOW_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	STATUS.ISTATUS_FLOW_HEADER_REPOSITORY STATUS_FLOW_HEADER 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_CREATION_MASTER_REPOSITORY TASK_CREATION_MASTER 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_DETAIL_REPOSITORY TASK_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_HANDLING_OPTION_REPOSITORY TASK_HANDLING_OPTION 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_HEADER_REPOSITORY TASK_HEADER 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_PREF_USER_AUTH_REPOSITORY TASK_PREF_USER_AUTH 
    	{ 
    		get;
    	}
    
    	
    	TASK.ITASK_PREFERENCE_REPOSITORY TASK_PREFERENCE 
    	{ 
    		get;
    	}
    
    	
    	TRANSACTION.ITRANSACTION_HISTORY_REPOSITORY TRANSACTION_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	TRANSFER.ITRANSFER_LOCATE_REQUEST_REPOSITORY TRANSFER_LOCATE_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	TRANSFER.ITRANSFER_ORDER_DETAIL_REPOSITORY TRANSFER_ORDER_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	TRANSFER.ITRANSFER_ORDER_HEADER_REPOSITORY TRANSFER_ORDER_HEADER 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_INVENTORY_REPOSITORY UPLOAD_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_INVENTORY_TRANS_REPOSITORY UPLOAD_INVENTORY_TRANS 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_LOCATION_INVENTORY_REPOSITORY UPLOAD_LOCATION_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_OBJECT_REPOSITORY UPLOAD_OBJECT 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_ORDER_STATUS_REPOSITORY UPLOAD_ORDER_STATUS 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_RECEIPT_CONTAINER_REPOSITORY UPLOAD_RECEIPT_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_RECEIPT_DETAIL_REPOSITORY UPLOAD_RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_RECEIPT_HEADER_REPOSITORY UPLOAD_RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_RECEIPTS_REPOSITORY UPLOAD_RECEIPTS 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_SHIPMENT_DETAIL_REPOSITORY UPLOAD_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_SHIPMENT_HEADER_REPOSITORY UPLOAD_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_SHIPPING_CONTAINER_REPOSITORY UPLOAD_SHIPPING_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	Sys.IUSER_REPOSITORY USER 
    	{ 
    		get;
    	}
    
    	
    	USER.IUSER_COMPANY_AUTH_REPOSITORY USER_COMPANY_AUTH 
    	{ 
    		get;
    	}
    
    	
    	USER.IUSER_WAREHOUSE_AUTH_REPOSITORY USER_WAREHOUSE_AUTH 
    	{ 
    		get;
    	}
    
    	
    	USER.IUSER_ZONE_AUTH_REPOSITORY USER_ZONE_AUTH 
    	{ 
    		get;
    	}
    
    	
    	Sys.IVENDOR_REPOSITORY VENDOR 
    	{ 
    		get;
    	}
    
    	
    	Sys.IVIEWER_REPOSITORY VIEWER 
    	{ 
    		get;
    	}
    
    	
    	Sys.IWAREHOUSE_REPOSITORY WAREHOUSE 
    	{ 
    		get;
    	}
    
    	
    	WAREHOUSE.IWAREHOUSE_ACTIVITY_REPOSITORY WAREHOUSE_ACTIVITY 
    	{ 
    		get;
    	}
    
    	
    	Sys.IWAVE_REPOSITORY WAVE 
    	{ 
    		get;
    	}
    
    	
    	WAVE.IWAVE_FLOW_DETAIL_REPOSITORY WAVE_FLOW_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	WAVE.IWAVE_FLOW_HEADER_REPOSITORY WAVE_FLOW_HEADER 
    	{ 
    		get;
    	}
    
    	
    	WAVE.IWAVE_MASTER_REPOSITORY WAVE_MASTER 
    	{ 
    		get;
    	}
    
    	
    	WAYBILL.IWAYBILL_INFO_REPOSITORY WAYBILL_INFO 
    	{ 
    		get;
    	}
    
    	
    	WORK.IWORK_OPTION_REPOSITORY WORK_OPTION 
    	{ 
    		get;
    	}
    
    	
    	WORK.IWORK_ORDER_DETAIL_REPOSITORY WORK_ORDER_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	WORK.IWORK_ORDER_HEADER_REPOSITORY WORK_ORDER_HEADER 
    	{ 
    		get;
    	}
    
    	
    	Sys.IZONE_REPOSITORY ZONE 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_ITEM_REPOSITORY AR_DOWNLOAD_ITEM 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_ITEM_BARCODE_REPOSITORY AR_DOWNLOAD_ITEM_BARCODE 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_ITEM_UNIT_OF_MEASURE_REPOSITORY AR_DOWNLOAD_ITEM_UNIT_OF_MEASURE 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_RECEIPT_DETAIL_REPOSITORY AR_DOWNLOAD_RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_RECEIPT_HEADER_REPOSITORY AR_DOWNLOAD_RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_SHIPMENT_DETAIL_REPOSITORY AR_DOWNLOAD_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_DOWNLOAD_SHIPMENT_HEADER_REPOSITORY AR_DOWNLOAD_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_LOCATION_INVENTORY_REPOSITORY AR_LOCATION_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_PROCESS_HISTORY_REPOSITORY AR_PROCESS_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_RECEIPT_LOCATE_REQUEST_REPOSITORY AR_RECEIPT_LOCATE_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPMENT_ALLOC_REQUEST_REPOSITORY AR_SHIPMENT_ALLOC_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPMENT_DETAIL_REPOSITORY AR_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPMENT_HEADER_REPOSITORY AR_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPMENT_HISTORY_REPOSITORY AR_SHIPMENT_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPPING_CONTAINER_REPOSITORY AR_SHIPPING_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_SHIPPING_LOAD_REPOSITORY AR_SHIPPING_LOAD 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_INVENTORY_REPOSITORY AR_UPLOAD_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_INVENTORY_TRANS_REPOSITORY AR_UPLOAD_INVENTORY_TRANS 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_LOCATION_INVENTORY_REPOSITORY AR_UPLOAD_LOCATION_INVENTORY 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_ORDER_STATUS_REPOSITORY AR_UPLOAD_ORDER_STATUS 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_RECEIPT_CONTAINER_REPOSITORY AR_UPLOAD_RECEIPT_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_RECEIPT_DETAIL_REPOSITORY AR_UPLOAD_RECEIPT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_RECEIPT_HEADER_REPOSITORY AR_UPLOAD_RECEIPT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_SHIPMENT_DETAIL_REPOSITORY AR_UPLOAD_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_SHIPMENT_HEADER_REPOSITORY AR_UPLOAD_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	AR.IAR_UPLOAD_SHIPPING_CONTAINER_REPOSITORY AR_UPLOAD_SHIPPING_CONTAINER 
    	{ 
    		get;
    	}
    
    	
    	CHART.ICHART_CONFIG_REPOSITORY CHART_CONFIG 
    	{ 
    		get;
    	}
    
    	
    	CONSOLIDATE.ICONSOLIDATE_SHIPMENT_HEADER_REPOSITORY CONSOLIDATE_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	CYCLE.ICYCLE_COUNT_PREFERENCE_REPOSITORY CYCLE_COUNT_PREFERENCE 
    	{ 
    		get;
    	}
    
    	
    	DELETED.IDELETED_SHIPMENT_DETAIL_REPOSITORY DELETED_SHIPMENT_DETAIL 
    	{ 
    		get;
    	}
    
    	
    	DELETED.IDELETED_SHIPMENT_HEADER_REPOSITORY DELETED_SHIPMENT_HEADER 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_RECEIPT_HEADER_FAILED_REPOSITORY DOWNLOAD_RECEIPT_HEADER_FAILED 
    	{ 
    		get;
    	}
    
    	
    	DOWNLOAD.IDOWNLOAD_SHIPMENT_HEADER_FAILED_REPOSITORY DOWNLOAD_SHIPMENT_HEADER_FAILED 
    	{ 
    		get;
    	}
    
    	
    	END.IEND_POINT_REPOSITORY END_POINT 
    	{ 
    		get;
    	}
    
    	
    	g.Ig_login_history_REPOSITORY g_login_history 
    	{ 
    		get;
    	}
    
    	
    	g.Ig_user_REPOSITORY g_user 
    	{ 
    		get;
    	}
    
    	
    	GENERIC.IGENERIC_USER_AUTH_REPOSITORY GENERIC_USER_AUTH 
    	{ 
    		get;
    	}
    
    	
    	GSP.IGSP_CODE_REPOSITORY GSP_CODE 
    	{ 
    		get;
    	}
    
    	
    	INTERFACE.IINTERFACE_REQUEST_REPOSITORY INTERFACE_REQUEST 
    	{ 
    		get;
    	}
    
    	
    	LOCATION.ILOCATION_INVENTORY_HIS_REPOSITORY LOCATION_INVENTORY_HIS 
    	{ 
    		get;
    	}
    
    	
    	LOCATION.ILOCATION_INVENTORY_TEMP_REPOSITORY LOCATION_INVENTORY_TEMP 
    	{ 
    		get;
    	}
    
    	
    	Sys.IMESSAGE_REPOSITORY MESSAGE 
    	{ 
    		get;
    	}
    
    	
    	MESSAGE.IMESSAGE_ROUTE_REPOSITORY MESSAGE_ROUTE 
    	{ 
    		get;
    	}
    
    	
    	PT.IPT_QTY_REPOSITORY PT_QTY 
    	{ 
    		get;
    	}
    
    	
    	RECEIPT.IRECEIPT_HISTORY_REPOSITORY RECEIPT_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	RECEIVING.IRECEIVING_CART_REPOSITORY RECEIVING_CART 
    	{ 
    		get;
    	}
    
    	
    	SECURITY.ISECURITY_FUNCTION_bak_REPOSITORY SECURITY_FUNCTION_bak 
    	{ 
    		get;
    	}
    
    	
    	SHIPMENT.ISHIPMENT_HISTORY_REPOSITORY SHIPMENT_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	test.Itest_LOC_V_REPOSITORY test_LOC_V 
    	{ 
    		get;
    	}
    
    	
    	UPLOAD.IUPLOAD_SHIPMENT_HISTORY_REPOSITORY UPLOAD_SHIPMENT_HISTORY 
    	{ 
    		get;
    	}
    
    	
    	USER.IUSER_ADDRESS_CARRIER_AUTH_REPOSITORY USER_ADDRESS_CARRIER_AUTH 
    	{ 
    		get;
    	}
    
    	
    	WAREHOUSE.IWAREHOUSE_ISSUE_REPOSITORY WAREHOUSE_ISSUE 
    	{ 
    		get;
    	}
    
    }
}
