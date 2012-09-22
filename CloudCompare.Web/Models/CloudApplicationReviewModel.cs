using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{
    #region CloudApplicationReviewModel
    public class CloudApplicationReviewModel
    {
        public int CloudApplicationReviewID { get; set; }
        public string CloudApplicationReviewHeadline { get; set; }
        public string CloudApplicationReviewPublisherName { get; set; }
        public string CloudApplicationReviewText { get; set; }
        public DateTime CloudApplicationReviewDate { get; set; }
        public string CloudApplicationReviewURL { get; set; }
        public int CloudApplicationID { get; set; }
    }
    #endregion
}
