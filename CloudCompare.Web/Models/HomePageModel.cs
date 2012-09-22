using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class HomePageModel
    {

        public TabbedSearchResults TabbedSearchResults { get; set; }
        public SearchInputModel SearchInputModel { get; set; }

    }

}
