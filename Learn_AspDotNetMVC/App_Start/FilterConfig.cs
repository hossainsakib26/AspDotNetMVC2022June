﻿using System.Web;
using System.Web.Mvc;

namespace Learn_AspDotNetMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
