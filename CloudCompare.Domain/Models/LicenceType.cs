using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region LicenceTypeMinimum
    public class LicenceTypeMinimum
    {
        public virtual int LicenceTypeMinimumID { get; set; }
        public virtual string LicenceTypeMinimumName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

    #region LicenceTypeMaximum
    public class LicenceTypeMaximum
    {
        public virtual int LicenceTypeMaximumID { get; set; }
        public virtual string LicenceTypeMaximumName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
