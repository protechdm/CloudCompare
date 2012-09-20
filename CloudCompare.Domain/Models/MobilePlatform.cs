using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region MobilePlatform
    public class MobilePlatform
    {
        public virtual int MobilePlatformID { get; set; }
        public virtual string MobilePlatformName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
