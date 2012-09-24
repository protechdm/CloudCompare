using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region CloudApplicationReview
    public class CloudApplicationReview
    {
        public virtual int CloudApplicationReviewID { get; set; }
        public virtual string CloudApplicationReviewHeadline { get; set; }
        public virtual string CloudApplicationReviewPublisherName { get; set; }
        public virtual string CloudApplicationReviewText { get; set; }
        public virtual DateTime CloudApplicationReviewDate { get; set; }
        public virtual string CloudApplicationReviewURL { get; set; }
        public virtual string CloudApplicationReviewPhysicalFileName { get; set; }
        public virtual byte[] RowVersion { get; set; }
        public virtual CloudApplication CloudApplication { get; set; }
    }
    #endregion

}
