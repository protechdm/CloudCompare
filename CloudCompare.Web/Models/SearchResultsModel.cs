using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
//using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchResultsModel
    {
        //[Display(Name = "Categories", ResourceType = typeof(App_LocalResources.ENG_Case))]
        [Display(Name = "Search Results")]
        //[UIHint("SearchFilter")]
        public IEnumerable<SearchResultModel> SearchResults { get; set; }

        //public IEnumerable<CategoryModel> CategoryFilters { get; set; }

        [Display(Name = "Test Value")]
        public string TestValue { get; set; }

    }

}
