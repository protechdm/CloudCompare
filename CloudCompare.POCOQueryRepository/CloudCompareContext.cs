﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using CloudCompare.Domain.Models;
using CloudCompare.Domain.Contracts.Repositories;
using CloudCompare.POCOQueryRepository.Configurations;

namespace CloudCompare.POCOQueryRepository
{
    public class CloudCompareContext : DbContext, ICloudCompareContext
    {
        public IDbSet<CloudApplication> CloudApplications { get; set; }
        public IDbSet<Vendor> Vendors { get; set; }
        public IDbSet<Feature> Features { get; set; }
        public IDbSet<Domain.Models.OperatingSystem> OperatingSystems { get; set; }
        public IDbSet<MobilePlatform> MobilePlatforms { get; set; }
        public IDbSet<Browser> Browsers { get; set; }
        public IDbSet<LicenceTypeMinimum> LicenceTypeMinimums { get; set; }
        public IDbSet<LicenceTypeMaximum> LicenceTypeMaximums { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<SupportType> SupportTypes { get; set; }
        public IDbSet<SupportDays> SupportDays { get; set; }
        public IDbSet<SupportHours> SupportHours { get; set; }
        public IDbSet<SupportTerritory> SupportTerritories { get; set; }
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<MinimumContract> MinimumContracts { get; set; }
        public IDbSet<PaymentFrequency> PaymentFrequencies { get; set; }
        public IDbSet<SetupFee> SetupFees { get; set; }
        public IDbSet<PaymentOption> PaymentOptions { get; set; }
        public IDbSet<FreeTrialPeriod> FreeTrialPeriods { get; set; }
        public IDbSet<CloudApplicationFeature> CloudApplicationFeatures { get; set; }
        public IDbSet<SimpleSearchInputs> SimpleSearchInputs { get; set; }
        public IDbSet<FeatureType> FeatureTypes { get; set; }
        public IDbSet<CloudApplicationReview> CloudApplicationReviews { get; set; }
        public IDbSet<CloudApplicationRating> CloudApplicationRatings { get; set; }
        public IDbSet<ThumbnailDocument> ThumbnailDocuments { get; set; }
        public IDbSet<ThumbnailDocumentType> ThumbnailDocumentTypes { get; set; }

        public CloudCompareContext()
            : base()
        {
        }

        public CloudCompareContext(string connectionString)
            : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<CloudCompareContext>(null);
            //Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CloudApplicationConfiguration());
            modelBuilder.Configurations.Add(new VendorConfiguration());
            modelBuilder.Configurations.Add(new FeatureConfiguration());
            modelBuilder.Configurations.Add(new OperatingSystemConfiguration());
            modelBuilder.Configurations.Add(new MobilePlatformConfiguration());
            modelBuilder.Configurations.Add(new BrowserConfiguration());
            modelBuilder.Configurations.Add(new LicenceTypeMinimumConfiguration());
            modelBuilder.Configurations.Add(new LicenceTypeMaximumConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new SupportTypeConfiguration());
            modelBuilder.Configurations.Add(new SupportDaysConfiguration());
            modelBuilder.Configurations.Add(new SupportHoursConfiguration());
            modelBuilder.Configurations.Add(new SupportTerritoryConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new MinimumContractConfiguration());
            modelBuilder.Configurations.Add(new PaymentFrequencyConfiguration());
            modelBuilder.Configurations.Add(new SetupFeeConfiguration());
            modelBuilder.Configurations.Add(new PaymentOptionConfiguration());
            modelBuilder.Configurations.Add(new FreeTrialPeriodConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationFeatureConfiguration());
            modelBuilder.Configurations.Add(new FeatureTypeConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationReviewConfiguration());
            modelBuilder.Configurations.Add(new CloudApplicationRatingConfiguration());
            modelBuilder.Configurations.Add(new ThumbnailDocumentConfiguration());
            modelBuilder.Configurations.Add(new ThumbnailDocumentTypeConfiguration());
            modelBuilder.Ignore<SearchResult>();
            modelBuilder.Ignore<TabbedSearchResults>();
            modelBuilder.Ignore<SimpleSearchInputs>();

            //SimpleSearchInputs.Include(x => x.Categories);
        }

        public CloudApplication FindById(int cloudApplicationId)
        {
            return CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationId).SingleOrDefault();
        }

        //IDbSet<CloudApplication> ICloudCompareContext.CloudApplications
        //{
        //    get { return CloudApplications; }
        //}

        //IDbSet<Vendor> ICloudCompareContext.Vendors
        //{
        //    get { return Vendors; }
        //}

        //IDbSet<Feature> ICloudCompareContext.Features
        //{
        //    get { return Features; }
        //}
    }
}
