using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
//using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{

    public class SearchFiltersModel
    {
        public SearchFiltersModel()
        {
        }

        public int? PreviouslyChosenCategoryID { get; set; }
        public int? ChosenCategoryID { get; set; }
        [Display(Name = "Categories")]
        public IList<CategoryModel> Categories { get; set; }


        public int? ChosenNumberOfUsers { get; set; }
        [Display(Name = "Users")]
        public IList<NumberOfUsersModel> NumberOfUsers { get; set; }

        //[Display(Name = "Categories", ResourceType = typeof(App_LocalResources.ENG_Case))]
        [Display(Name = "Search Filters")]
        //[UIHint("SearchFilter")]
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersBrowsers { get; set; }
        public IEnumerable<SearchFilterModelOneColumn> SearchFiltersFeatures { get; set; }

        //private EnumerableFeaturesModel _searchFiltersFeatures;
        //public EnumerableFeaturesModel SearchFiltersFeatures 
        //{
        //    get
        //    {
        //        if (_searchFiltersFeatures == null)
        //        {
        //            _searchFiltersFeatures = new EnumerableFeaturesModel();
        //        }
        //        return _searchFiltersFeatures;
        //    }
        //    set
        //    {
        //        _searchFiltersFeatures = value;
        //    }
        //}
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersOperatingSystems { get; set; }
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportTypes { get; set; }
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportDays { get; set; }
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersSupportHours { get; set; }
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersLanguages { get; set; }
        public IEnumerable<SearchFilterModelTwoColumn> SearchFiltersMobilePlatforms { get; set; }

        [Display(Name = "Test Value")]
        public string TestValue { get; set; }

    }

}
