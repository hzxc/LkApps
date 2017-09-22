﻿using Apps.Web.Filters;
using System.Web;
using System.Web.Mvc;

namespace Apps.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CheckPermissionAttribute());
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalExceptionAttribute());


        }
    }
}
