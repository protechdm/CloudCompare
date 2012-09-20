using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region CloudApplicationFeature
    public class CloudApplicationFeature
    {
        public virtual int CloudApplicationFeatureID { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual bool Include { get; set; }
        public virtual bool IncludeExtraCost { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual bool IncludeCount { get; set; }
        public virtual int Count { get; set; }
        public virtual bool IncludeCountSuffix { get; set; }
        public virtual string CountSuffix { get; set; }
        public virtual byte[] RowVersion { get; set; }
    }
    #endregion
}
