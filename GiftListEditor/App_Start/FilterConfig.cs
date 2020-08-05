﻿using PDWebCore.Filters;
using System.Web;
using System.Web.Mvc;

namespace GiftListEditor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogExceptionFilterAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
