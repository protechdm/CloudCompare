using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.Objects;
using System.Data.Entity;
using CloudCompare.Domain.Contracts.Repositories;
using CloudCompare.Domain.Models;

namespace CloudCompare.POCOQueryRepository
{
    public class FakeCloudCompareContext : ICloudCompareContext, IDisposable
    {

        private FakeObjectSet<CloudApplication> _cloudApplications;
        private FakeObjectSet<Vendor> _vendors;
        private FakeObjectSet<Feature> _features;
        private FakeObjectSet<CloudCompare.Domain.Models.OperatingSystem> _operatingSystems;
        private FakeObjectSet<MobilePlatform> _mobilePlatforms;
        private FakeObjectSet<Browser> _browsers;
        private FakeObjectSet<LicenceTypeMinimum> _licenceTypeMinimums;
        private FakeObjectSet<LicenceTypeMaximum> _licenceTypeMaximums;
        private FakeObjectSet<Language> _languages;
        private FakeObjectSet<SupportType> _supportTypes;
        private FakeObjectSet<SupportDays> _supportDays;
        private FakeObjectSet<SupportHours> _supportHours;
        private FakeObjectSet<SupportTerritory> _supportTerritories;
        private FakeObjectSet<Category> _categories;
        private FakeObjectSet<MinimumContract> _minimumContracts;
        private FakeObjectSet<PaymentFrequency> _paymentFrequencies;
        private FakeObjectSet<SetupFee> _setupFees;
        private FakeObjectSet<PaymentOption> _paymentOptions;
        private FakeObjectSet<FreeTrialPeriod> _freeTrialPeriods;
        private FakeObjectSet<FeatureType> _featureTypes;

        #region ICloudCompareEntities Members

        public IDbSet<CloudApplication> CloudApplications
        {
            get
            {
                return _cloudApplications ?? (_cloudApplications = new FakeObjectSet<CloudApplication>());
            }
            set
            {
                _cloudApplications = value as FakeObjectSet<CloudApplication>;
            }
        }

        public IDbSet<Vendor> Vendors
        {
            get
            {
                return _vendors ?? (_vendors = new FakeObjectSet<Vendor>());
            }
            set
            {
                _vendors = value as FakeObjectSet<Vendor>;
            }
        }

        public IDbSet<Feature> Features
        {
            get
            {
                return _features ?? (_features = new FakeObjectSet<Feature>());
            }
            set
            {
                _features = value as FakeObjectSet<Feature>;
            }
        }

        public IDbSet<CloudCompare.Domain.Models.OperatingSystem> OperatingSystems
        {
            get
            {
                return _operatingSystems ?? (_operatingSystems = new FakeObjectSet<CloudCompare.Domain.Models.OperatingSystem>());
            }
            set
            {
                _operatingSystems = value as FakeObjectSet<CloudCompare.Domain.Models.OperatingSystem>;
            }
        }

        public IDbSet<MobilePlatform> MobilePlatforms
        {
            get
            {
                return _mobilePlatforms ?? (_mobilePlatforms = new FakeObjectSet<MobilePlatform>());
            }
            set
            {
                _mobilePlatforms = value as FakeObjectSet<MobilePlatform>;
            }
        }

        public IDbSet<Browser> Browsers
        {
            get
            {
                return _browsers ?? (_browsers = new FakeObjectSet<Browser>());
            }
            set
            {
                _browsers = value as FakeObjectSet<Browser>;
            }
        }

        public IDbSet<LicenceTypeMinimum> LicenceTypeMinimums
        {
            get
            {
                return _licenceTypeMinimums ?? (_licenceTypeMinimums = new FakeObjectSet<LicenceTypeMinimum>());
            }
            set
            {
                _licenceTypeMinimums = value as FakeObjectSet<LicenceTypeMinimum>;
            }
        }

        public IDbSet<LicenceTypeMaximum> LicenceTypeMaximums
        {
            get
            {
                return _licenceTypeMaximums ?? (_licenceTypeMaximums = new FakeObjectSet<LicenceTypeMaximum>());
            }
            set
            {
                _licenceTypeMaximums = value as FakeObjectSet<LicenceTypeMaximum>;
            }
        }

        public IDbSet<Language> Languages
        {
            get
            {
                return _languages ?? (_languages = new FakeObjectSet<Language>());
            }
            set
            {
                _languages = value as FakeObjectSet<Language>;
            }
        }

        public IDbSet<SupportType> SupportTypes
        {
            get
            {
                return _supportTypes ?? (_supportTypes = new FakeObjectSet<SupportType>());
            }
            set
            {
                _supportTypes = value as FakeObjectSet<SupportType>;
            }
        }

        public IDbSet<SupportDays> SupportDays
        {
            get
            {
                return _supportDays ?? (_supportDays = new FakeObjectSet<SupportDays>());
            }
            set
            {
                _supportDays = value as FakeObjectSet<SupportDays>;
            }
        }

        public IDbSet<SupportHours> SupportHours
        {
            get
            {
                return _supportHours ?? (_supportHours = new FakeObjectSet<SupportHours>());
            }
            set
            {
                _supportHours = value as FakeObjectSet<SupportHours>;
            }
        }

        public IDbSet<SupportTerritory> SupportTerritories
        {
            get
            {
                return _supportTerritories ?? (_supportTerritories = new FakeObjectSet<SupportTerritory>());
            }
            set
            {
                _supportTerritories = value as FakeObjectSet<SupportTerritory>;
            }
        }

        public IDbSet<Category> Categories
        {
            get
            {
                return _categories ?? (_categories = new FakeObjectSet<Category>());
            }
            set
            {
                _categories = value as FakeObjectSet<Category>;
            }
        }

        public IDbSet<MinimumContract> MinimumContracts
        {
            get
            {
                return _minimumContracts ?? (_minimumContracts = new FakeObjectSet<MinimumContract>());
            }
            set
            {
                _minimumContracts = value as FakeObjectSet<MinimumContract>;
            }
        }

        public IDbSet<PaymentFrequency> PaymentFrequencies
        {
            get
            {
                return _paymentFrequencies ?? (_paymentFrequencies = new FakeObjectSet<PaymentFrequency>());
            }
            set
            {
                _paymentFrequencies = value as FakeObjectSet<PaymentFrequency>;
            }
        }

        public IDbSet<SetupFee> SetupFees
        {
            get
            {
                return _setupFees ?? (_setupFees = new FakeObjectSet<SetupFee>());
            }
            set
            {
                _setupFees = value as FakeObjectSet<SetupFee>;
            }
        }

        public IDbSet<PaymentOption> PaymentOptions
        {
            get
            {
                return _paymentOptions ?? (_paymentOptions = new FakeObjectSet<PaymentOption>());
            }
            set
            {
                _paymentOptions = value as FakeObjectSet<PaymentOption>;
            }
        }

        public IDbSet<FreeTrialPeriod> FreeTrialPeriods
        {
            get
            {
                return _freeTrialPeriods ?? (_freeTrialPeriods = new FakeObjectSet<FreeTrialPeriod>());
            }
            set
            {
                _freeTrialPeriods = value as FakeObjectSet<FreeTrialPeriod>;
            }
        }

        public IDbSet<FeatureType> FeatureTypes
        {
            get
            {
                return _featureTypes ?? (_featureTypes = new FakeObjectSet<FeatureType>());
            }
            set
            {
                _featureTypes = value as FakeObjectSet<FeatureType>;
            }
        }

        public int SaveChanges()
        {
            foreach (var cloudApplication in CloudApplications)
            {
                ((IValidate)cloudApplication).Validate(ChangeAction.Insert);
            }
            return 1;
        }
        public void Dispose() { }


        #endregion


        //public int GetStations(string startsWith)
        //{
        //    throw new InvalidOperationException();
        //}

        //System.Data.Entity.IDbSet<CloudApplication> ICloudCompareContext.CloudApplications
        //{
        //    get { return _cloudApplications; }
        //}

        //public System.Data.Entity.IDbSet<Vendor> Vendors
        //{
        //    get { return _vendors; }
        //}

        //public System.Data.Entity.IDbSet<Feature> Features
        //{
        //    get { return _features; }
        //}

        public CloudApplication FindById(int cloudApplicationId)
        {
            throw new NotImplementedException();
        }
    }
}
