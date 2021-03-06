﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region SupportDays
    public class SupportDays
    {
        public virtual int SupportDaysID { get; set; }
        public virtual string SupportDaysName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual List<CloudApplication> CloudApplications { get; set; }
    }
    #endregion

}
