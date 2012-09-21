﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    public interface ISearchFilterTwoColumn
    {
        int SearchFilterID { get; set; }
        string SearchFilterNameCol1 { get; set; }
        Category CategoryCol1 { get; set; }
        FeatureType SearchFilterTypeCol1 { get; set; }
        string SearchFilterTypeNameCol1 { get; set; }
        int SearchFilterColumnNumberCol1 { get; set; }
        int SearchFilterRowNumberCol1 { get; set; }
        string SearchFilterNameCol2 { get; set; }
        Category CategoryCol2 { get; set; }
        FeatureType SearchFilterTypeCol2 { get; set; }
        string SearchFilterTypeNameCol2 { get; set; }
        int SearchFilterColumnNumberCol2 { get; set; }
        int SearchFilterRowNumberCol2 { get; set; }

    }
    #region SearchFilterTwoColumn
    public class SearchFilterTwoColumn : ISearchFilterTwoColumn
    {
        //public virtual int SearchFilterTwoColumnID { get; set; }
        public virtual int SearchFilterID { get; set; }
        public virtual string SearchFilterNameCol1 { get; set; }
        public virtual Category CategoryCol1 { get; set; }
        public virtual FeatureType SearchFilterTypeCol1 { get; set; }
        public virtual string SearchFilterTypeNameCol1 { get; set; }
        public virtual int SearchFilterColumnNumberCol1 { get; set; }
        public virtual int SearchFilterRowNumberCol1 { get; set; }
        public virtual string SearchFilterNameCol2 { get; set; }
        public virtual Category CategoryCol2 { get; set; }
        public virtual FeatureType SearchFilterTypeCol2 { get; set; }
        public virtual string SearchFilterTypeNameCol2 { get; set; }
        public virtual int SearchFilterColumnNumberCol2 { get; set; }
        public virtual int SearchFilterRowNumberCol2 { get; set; }
    }
    #endregion
}