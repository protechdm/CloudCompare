using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CloudCompare.Domain.Models
{
    #region Vendor
    public class Vendor
    {
        public virtual int VendorID { get; set; }
        //[Required]
        //[MaxLength(100)]
        public virtual string VendorName { get; set; }
        public virtual string VendorLogoURL { get; set; }
        //[Column(TypeName="image")]
        public virtual byte[] VendorLogo { get; set; }

        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
