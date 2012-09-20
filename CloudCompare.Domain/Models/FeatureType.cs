using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region FeatureType
    public class FeatureType
    {
        public virtual int FeatureTypeID { get; set; }
        public virtual string FeatureTypeName { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
