using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchFilterModelOneColumn
    {
        //[Display(Name = "Search Filter ID")]
        public int SearchFilterID { get; set; }

        //[Display(Name = "Category ID")]
        public Category Category { get; set; }

        //[Display(Name = "Name")]
        //[Required(ErrorMessage="Name is required")]
        //[StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string SearchFilterName { get; set; }

        public string SearchFilterType { get; set; }

        //[Display(Name = "Selected")]
        public bool Selected { get; set; }
    }

}
