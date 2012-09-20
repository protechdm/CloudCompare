using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchResultModel
    {
        //[Display(Name = "Search Filter ID")]
        public int SearchResultID { get; set; }

        //[Display(Name = "Category ID")]
        //public Category Category { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        //public string SearchFilterName { get; set; }

        //public string SearchFilterType { get; set; }

        //[Display(Name = "Selected")]
        //public bool Selected { get; set; }

        public int CloudApplicationID { get; set; }
        public string VendorName { get; set; }
        public string VendorLogoURL { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public decimal ApplicationCostPerMonth { get; set; }
        public string ApplicationCostPerMonthExtra { get; set; }
        public decimal ApplicationCostPerAnnum { get; set; }
        public decimal ApplicationCostOneOff { get; set; }
        public decimal CallsPackageCostPerMonth { get; set; }
        public string SetupFee { get; set; }
        public string FreeTrialPeriod { get; set; }

    }

}
