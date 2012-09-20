using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
//using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchFiltersForFeatureTypeModel
    {
        public SearchFiltersForFeatureTypeModel()
        {
            //this.SearchFiltersModel = new SearchFiltersModel();
            //this.SearchResultsModel = new SearchResultsModel();
        }

        private List<SearchFilterModelTwoColumn> _featureFilters;
        public List<SearchFilterModelTwoColumn> FeatureFilters
        {
            get
            {
                return _featureFilters;
            }
            set
            {
                _featureFilters = value;
            }
        }

        //public SearchFilterModel ChosenFeatureFilter { get; set; }


    }

}
