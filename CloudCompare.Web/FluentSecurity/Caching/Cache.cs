﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Caching
{
    public enum Cache
    {
        DoNotCache,
        PerHttpRequest,
        PerHttpSession
    }
}