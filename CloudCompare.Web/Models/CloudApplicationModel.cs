using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using CloudCompare.Domain.Models;

namespace CloudCompare.Web.Models
{
    #region CloudApplication
    public class CloudApplicationModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Buy now")]
        public int CloudApplicationID { get; set; }
        public Vendor Vendor { get; set; }
        public string Brand { get; set; }
        public string ServiceName { get; set; }
        public string CompanyURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] CloudApplicationLogo { get; set; }
        public bool IsPromotional { get; set; }
        public decimal ApplicationCostPerMonth { get; set; }
        public string ApplicationCostPerMonthExtra { get; set; }
        public decimal ApplicationCostPerAnnum { get; set; }
        public decimal ApplicationCostOneOff { get; set; }
        public decimal CallsPackageCostPerMonth { get; set; }
        public SetupFee SetupFee { get; set; }
        //public string SetupFee { get; set; }
        public FreeTrialPeriod FreeTrialPeriod { get; set; }
        //public string FreeTrialPeriod { get; set; }
        public List<CloudCompare.Domain.Models.OperatingSystem> OperatingSystems { get; set; }
        public List<Browser> Browsers { get; set; }
        public List<MobilePlatform> MobilePlatforms { get; set; }
        public LicenceTypeMinimum LicenceTypeMinimum { get; set; }
        public LicenceTypeMaximum LicenceTypeMaximum { get; set; }
        public List<SupportType> SupportTypes { get; set; }
        public SupportDays SupportDays { get; set; }
        public SupportHours SupportHours { get; set; }
        public List<SupportTerritory> SupportTerritories { get; set; }
        public List<Language> Languages { get; set; }
        public List<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
        public List<ThumbnailDocument> ThumbnailDocuments { get; set; }
        public string TwitterURL { get; set; }
        public string FacebookURL { get; set; }
        public string LinkedInURL { get; set; }
        public int TwitterFollowers { get; set; }
        public int FacebookFollowers { get; set; }
        public int LinkedInFollowers { get; set; }
        public decimal AverageOverallRating { get; set; }
        public decimal AverageEaseOfUse { get; set; }
        public decimal AverageValueForMoney { get; set; }
        public decimal AverageFunctionality { get; set; }

        public Category Category { get; set; }
        public DateTime? AddDate { get; set; }

        public MinimumContract MinimumContract { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }
        public List<PaymentOption> PaymentOptions { get; set; }

        public bool VideoTrainingSupport { get; set; }

        public int MaximumMeetingAttendees { get; set; }
        public int MaximumWebinarAttendees { get; set; }

        public int ApprovalAssignedPersonID { get; set; }
        public int ApplicationContentStatusID { get; set; }
        public int ApprovalStatusID { get; set; }

        public List<CloudApplicationReviewModel> Reviews { get; set; }
        public List<CloudApplicationRatingModel> Ratings { get; set; }

        public virtual byte[] RowVersion { get; set; }

    }
    #endregion
}
