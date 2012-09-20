using System;
using System.Data.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using CloudCompare.Domain.Models;

namespace CloudCompare.Domain.Contracts.Repositories
{
    public interface ICloudCompareContext : IDisposable
    {
        IDbSet<CloudApplication> CloudApplications { get; }
        IDbSet<Vendor> Vendors { get; }
        IDbSet<Feature> Features { get; }
        IDbSet<CloudCompare.Domain.Models.OperatingSystem> OperatingSystems { get; }
        IDbSet<MobilePlatform> MobilePlatforms { get; }
        IDbSet<Browser> Browsers { get; }
        IDbSet<LicenceTypeMinimum> LicenceTypeMinimums { get; }
        IDbSet<LicenceTypeMaximum> LicenceTypeMaximums { get; }
        IDbSet<Language> Languages { get; }
        IDbSet<SupportType> SupportTypes { get; }
        IDbSet<SupportDays> SupportDays { get; }
        IDbSet<SupportHours> SupportHours { get; }
        IDbSet<SupportTerritory> SupportTerritories { get; }
        IDbSet<Category> Categories { get; }
        IDbSet<MinimumContract> MinimumContracts { get; }
        IDbSet<PaymentFrequency> PaymentFrequencies { get; }
        IDbSet<SetupFee> SetupFees { get; }
        IDbSet<PaymentOption> PaymentOptions { get; }
        IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; }
        IDbSet<FeatureType> FeatureTypes { get; }

        int SaveChanges();
        //int GetStations(string startsWith);
        CloudApplication FindById(int cloudApplicationId);
    }
}
