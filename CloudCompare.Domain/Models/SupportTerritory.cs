using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region SupportTerritory
    public class SupportTerritory
    {
        public virtual int SupportTerritoryID { get; set; }
        public virtual string SupportTerritoryName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion
}
