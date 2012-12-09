﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System;
using System.Web.Mvc;
using NWebsec.HttpHeaders;
using NWebsec.Modules.Configuration;

namespace NWebsec.Mvc.HttpHeaders
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class XDownloadOptionsAttribute : ActionFilterAttribute
    {
        public bool Enabled { get; set; }

        public XDownloadOptionsAttribute()
        {
            Enabled = true;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            new HttpHeaderHelper(filterContext.HttpContext).SetXDownloadOptionsOverride(new SimpleBooleanConfigurationElement { Enabled = Enabled });
            base.OnActionExecuting(filterContext);
        }
    }
}
