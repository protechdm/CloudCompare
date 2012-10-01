using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region Feature
    public class Feature
    {
        public virtual int FeatureID { get; set; }
        public virtual string FeatureName { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual int FeatureColumnNumber { get; set; }
        public virtual int FeatureRowNumber { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
