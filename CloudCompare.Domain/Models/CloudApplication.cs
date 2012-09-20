using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region CloudApplication
    public class CloudApplication
    {
        public virtual int CloudApplicationID { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual string Brand { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string CompanyURL { get; set; }
        //[Required]
        //[MaxLength(101)]
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsPromotional { get; set; }
        public virtual decimal ApplicationCostPerMonth { get; set; }
        public virtual string ApplicationCostPerMonthExtra { get; set; }
        public virtual decimal ApplicationCostPerAnnum { get; set; }
        public virtual decimal ApplicationCostOneOff { get; set; }
        public virtual decimal CallsPackageCostPerMonth { get; set; }
        public virtual SetupFee SetupFee { get; set; }
        public virtual FreeTrialPeriod FreeTrialPeriod { get; set; }
        public virtual List<OperatingSystem> OperatingSystems { get; set; }
        public virtual List<Browser> Browsers { get; set; }
        public virtual List<MobilePlatform> MobilePlatforms { get; set; }
        public virtual LicenceTypeMinimum LicenceTypeMinimum { get; set; }
        public virtual LicenceTypeMaximum LicenceTypeMaximum { get; set; }
        public virtual List<SupportType> SupportTypes { get; set; }
        public virtual SupportDays SupportDays { get; set; }
        public virtual SupportHours SupportHours { get; set; }
        public virtual List<SupportTerritory> SupportTerritories { get; set; }
        public virtual List<Language> Languages { get; set; }
        public virtual List<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
        public virtual List<ThumbnailDocument> ThumbnailDocuments { get; set; }
        public virtual string TwitterURL { get; set; }
        public virtual string FacebookURL { get; set; }
        public virtual string LinkedInURL { get; set; }
        public virtual int TwitterFollowers { get; set; }
        public virtual int FacebookFollowers { get; set; }
        public virtual int LinkedInFollowers { get; set; }
        public virtual decimal AverageOverallRating { get; set; }
        public virtual decimal AverageEaseOfUse { get; set; }
        public virtual decimal AverageValueForMoney { get; set; }
        public virtual decimal AverageFunctionality { get; set; }

        public virtual Category Category { get; set; }
        public virtual DateTime? AddDate { get; set; }

        public virtual MinimumContract MinimumContract { get; set; }
        public virtual PaymentFrequency PaymentFrequency { get; set; }
        public virtual List<PaymentOption> PaymentOptions { get; set; }

        public virtual bool VideoTrainingSupport { get; set; }

        public virtual int MaximumMeetingAttendees { get; set; }
        public virtual int MaximumWebinarAttendees { get; set; }

        public virtual int ApprovalAssignedPersonID { get; set; }
        public virtual int ApplicationContentStatusID { get; set; }
        public virtual int ApprovalStatusID { get; set; }

        public virtual byte[] RowVersion { get; set; }

    }
    #endregion
}
