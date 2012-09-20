using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    public interface ISearchFilterOneColumn
    {
        int SearchFilterID { get; set; }
        string SearchFilterNameCol1 { get; set; }
        Category CategoryCol1 { get; set; }
        FeatureType SearchFilterTypeCol1 { get; set; }
        string SearchFilterTypeNameCol1 { get; set; }
        int SearchFilterColumnNumberCol1 { get; set; }
        int SearchFilterRowNumberCol1 { get; set; }
    }

    #region SearchFilter
    public class SearchFilterOneColumn : ISearchFilterOneColumn
    {
        public virtual int SearchFilterID { get; set; }
        public virtual string SearchFilterNameCol1 { get; set; }
        public virtual Category CategoryCol1 { get; set; }
        public virtual FeatureType SearchFilterTypeCol1 { get; set; }
        public virtual string SearchFilterTypeNameCol1 { get; set; }
        public virtual int SearchFilterColumnNumberCol1 { get; set; }
        public virtual int SearchFilterRowNumberCol1 { get; set; }
    }
    #endregion
}
