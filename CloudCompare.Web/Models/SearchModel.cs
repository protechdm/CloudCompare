using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
//using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchModel
    {
        public SearchModel()
        {
            this.SearchFiltersModel = new SearchFiltersModel();
            this.SearchResultsModel = new SearchResultsModel();
        }
        public SearchFiltersModel SearchFiltersModel { get; set; }
        public SearchResultsModel SearchResultsModel { get; set; }
        
        
    }

}
