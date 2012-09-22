using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{
    #region CloudApplicationRatingModel
    public class CloudApplicationRatingModel
    {
        public int CloudApplicationRatingID { get; set; }
        public string CloudApplicationRatingReviewerName { get; set; }
        public string CloudApplicationRatingReviewerTitle { get; set; }
        public string CloudApplicationRatingReviewerCompany { get; set; }
        public string CloudApplicationRatingText { get; set; }
        public decimal CloudApplicationOverallRating { get; set; }
        public decimal CloudApplicationEaseOfUse { get; set; }
        public decimal CloudApplicationValueForMoney { get; set; }
        public decimal CloudApplicationFunctionality { get; set; }
        public int CloudApplicationID { get; set; }
    }
    #endregion
}
