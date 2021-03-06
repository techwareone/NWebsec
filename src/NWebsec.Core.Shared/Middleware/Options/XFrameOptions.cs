﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Core.Common.HttpHeaders;
using NWebsec.Core.Common.HttpHeaders.Configuration;

namespace NWebsec.Core.Common.Middleware.Options
{
    public class XFrameOptions : IXFrameOptionsConfiguration, IFluentXFrameOptions
    {
        public XFrameOptions()
        {
            Policy = XfoPolicy.Disabled;
        }

        public XfoPolicy Policy { get; set; }

        public void Deny()
        {
            Policy = XfoPolicy.Deny;
        }

        public void SameOrigin()
        {
            Policy = XfoPolicy.SameOrigin;
        }
    }
}