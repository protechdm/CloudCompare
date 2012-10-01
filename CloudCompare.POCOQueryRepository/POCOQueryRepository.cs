using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data.Entity;
using CloudCompare.Domain.Models;
using CloudCompare.Domain.Contracts.Repositories;
using LinqKit;
using CloudCompare.POCOQueryRepository.Helpers;

namespace CloudCompare.POCOQueryRepository
{
    public class QueryRepository : BaseRepository, ICloudCompareRepository, IDisposable
    {
        const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_FEATURES = "FEATURES";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";

        ICloudCompareContext _context;

        #region Constructors
        //public QueryRepository()
        //{
        //    _context = new CloudCompareContext();
        //}

        public QueryRepository(ICloudCompareContext context)
            : base(context as CloudCompareContext)
        {
            _context = context;
        }

        public QueryRepository(CloudCompareContext context)
            :base(context)
        {
            _context = context;
        }
        #endregion

        #region GetCloudApplicationsForVendor
        public IList<CloudApplication> GetCloudApplicationsForVendor(int? vendorID)
        {
            if (!vendorID.HasValue || vendorID.Value < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return _context.CloudApplications.
              Where(ca => ca.Vendor.VendorID == vendorID).ToList();
        }
        #endregion

        #region Save
        public string Save()
        {
            string validationErrors = "";
            if (PreSavingValidations(out validationErrors) == true)
            {
                //this Save is not taking n-tier issues into account
                _context.SaveChanges();
                return "";
            }
            else
                return "Data Not Saved due to Validation Errors: " + validationErrors;
        }
        #endregion

        #region PreSavingValidations
        public bool PreSavingValidations(out string validationErrors)
        {
            bool isvalid = true;
            validationErrors = "";

            //foreach (Reservation res in _context.ManagedReservations)
            //{
            //    try
            //    {
            //        bool isResValid;
            //        string validationError;
            //        isResValid = res.ValidateBeforeSave(out validationError);
            //        if (!isResValid)
            //        {
            //            isvalid = false;
            //            validationErrors += validationError;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            return isvalid;
        }
        #endregion

        #region AddCloudApplication
        public void AddCloudApplication(CloudApplication ca)
        {
            _context.CloudApplications.Add(ca);
        }
        #endregion

        #region AddFeature
        public void AddFeature(Feature f)
        {
            _context.Features.Add(f);
        }
        #endregion

        #region AddFeatureType
        public void AddFeatureType(FeatureType ft)
        {
            _context.FeatureTypes.Add(ft);
        }
        #endregion

        #region AddOperatingSystem
        public void AddOperatingSystem(CloudCompare.Domain.Models.OperatingSystem os)
        {
            _context.OperatingSystems.Add(os);
        }
        #endregion

        #region AddMobilePlatform
        public void AddMobilePlatform(MobilePlatform mp)
        {
            _context.MobilePlatforms.Add(mp);
        }
        #endregion

        #region AddBrowser
        public void AddBrowser(Browser b)
        {
            _context.Browsers.Add(b);
        }
        #endregion

        #region AddLicenceTypeMinimum
        public void AddLicenceTypeMinimum(LicenceTypeMinimum ltm)
        {
            _context.LicenceTypeMinimums.Add(ltm);
        }
        #endregion

        #region AddLicenceTypeMaximum
        public void AddLicenceTypeMaximum(LicenceTypeMaximum ltm)
        {
            _context.LicenceTypeMaximums.Add(ltm);
        }
        #endregion

        #region AddLanguage
        public void AddLanguage(Language l)
        {
            _context.Languages.Add(l);
        }
        #endregion

        #region AddSupportType
        public void AddSupportType(SupportType st)
        {
            _context.SupportTypes.Add(st);
        }
        #endregion

        #region AddSupportDays
        public void AddSupportDays(SupportDays sd)
        {
            _context.SupportDays.Add(sd);
        }
        #endregion

        #region AddSupportHours
        public void AddSupportHours(SupportHours sh)
        {
            _context.SupportHours.Add(sh);
        }
        #endregion

        #region AddSupportTerritory
        public void AddSupportTerritory(SupportTerritory st)
        {
            _context.SupportTerritories.Add(st);
        }
        #endregion

        #region AddCategory
        public void AddCategory(Category c)
        {
            _context.Categories.Add(c);
        }
        #endregion

        #region AddMinimumContract
        public void AddMinimumContract(MinimumContract mc)
        {
            _context.MinimumContracts.Add(mc);
        }
        #endregion

        #region AddPaymentFrequency
        public void AddPaymentFrequency(PaymentFrequency pf)
        {
            _context.PaymentFrequencies.Add(pf);
        }
        #endregion

        #region AddSetupFee
        public void AddSetupFee(SetupFee sf)
        {
            _context.SetupFees.Add(sf);
        }
        #endregion

        #region AddPaymentOption
        public void AddPaymentOption(PaymentOption po)
        {
            _context.PaymentOptions.Add(po);
        }
        #endregion

        #region AddFreeTrialPeriod
        public void AddFreeTrialPeriod(FreeTrialPeriod ftp)
        {
            _context.FreeTrialPeriods.Add(ftp);
        }
        #endregion

        #region AddVendor
        public void AddVendor(Vendor v)
        {
            _context.Vendors.Add(v);
        }
        #endregion

        #region AddThumbnailDocumentType
        public void AddThumbnailDocumentType(ThumbnailDocumentType tdt)
        {
            _context.ThumbnailDocumentTypes.Add(tdt);
        }
        #endregion

        #region AddThumbnailDocument
        public void AddThumbnailDocument(ThumbnailDocument td)
        {
            _context.ThumbnailDocuments.Add(td);
        }
        #endregion

        #region FindCategoryByName
        public Category FindCategoryByName(string categoryName)
        {
            Category f1 = _context.Categories.Where(x => x.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())).FirstOrDefault();
            Category f2 = (from cf in _context.Categories
                          where cf.CategoryName.ToUpper().StartsWith(categoryName.ToUpper())
                          select cf).FirstOrDefault();

            if (f2 == null)
            {
                throw new Exception("Cannot find category");
            }
            return f2;
        }
        #endregion

        #region FindFeatureByName
        public CloudApplicationFeature FindFeatureByName(string featureName)
        {
            Feature f1 =_context.Features.Where(x => x.FeatureName.ToUpper().StartsWith(featureName.ToUpper())).FirstOrDefault();
            Feature f2 =     (from cf in _context.Features
                              where cf.FeatureName.ToUpper().StartsWith(featureName.ToUpper())
                         select cf).FirstOrDefault();

            if (f2 == null)
            {
                string x = "";
            }
            return new CloudApplicationFeature()
            {
                Feature = f2    
            }
            ;     
        }
        #endregion

        #region FindOperatingSystemByName
        public Domain.Models.OperatingSystem FindOperatingSystemByName(string operatingSystemName)
        {
            Domain.Models.OperatingSystem f1 = _context.OperatingSystems.Where(x => x.OperatingSystemName.ToUpper().StartsWith(operatingSystemName.ToUpper())).FirstOrDefault();
            Domain.Models.OperatingSystem f2 = (from cf in _context.OperatingSystems
                          where cf.OperatingSystemName.ToUpper().StartsWith(operatingSystemName.ToUpper())
                          select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region GetAllMobilePlatforms
        public List<MobilePlatform> GetAllMobilePlatforms()
        {
            return _context.MobilePlatforms.ToList();
        }
        #endregion

        #region FindMobilePlatformByName
        public MobilePlatform FindMobilePlatformByName(string mobilePlatformName)
        {
            MobilePlatform f1 = _context.MobilePlatforms.Where(x => x.MobilePlatformName.ToUpper().StartsWith(mobilePlatformName.ToUpper())).FirstOrDefault();
            MobilePlatform f2 = (from cf in _context.MobilePlatforms
                                  where cf.MobilePlatformName.ToUpper().StartsWith(mobilePlatformName.ToUpper())
                                  select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindBrowserByName
        public Browser FindBrowserByName(string browserName)
        {
            Browser f1 = _context.Browsers.Where(x => x.BrowserName.ToUpper().StartsWith(browserName.ToUpper())).FirstOrDefault();
            Browser f2 = (from cf in _context.Browsers
                          where cf.BrowserName.ToUpper().StartsWith(browserName.ToUpper())
                          select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindLicenceTypeMinimumByName
        public LicenceTypeMinimum FindLicenceTypeMinimumByName(int licenceTypeMinimumName)
        {
            //LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
            //              where cf.LicenceTypeMinimumName.ToUpper().StartsWith(licenceTypeMinimumName.ToUpper())
            //              select cf).FirstOrDefault();

            LicenceTypeMinimum f1 = _context.LicenceTypeMinimums.Where(x => x.LicenceTypeMinimumName == licenceTypeMinimumName).FirstOrDefault();
            LicenceTypeMinimum f2 = (from cf in _context.LicenceTypeMinimums
                                     where cf.LicenceTypeMinimumName == licenceTypeMinimumName
                                     select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindLicenceTypeMaximumByName
        public LicenceTypeMaximum FindLicenceTypeMaximumByName(int licenceTypeMaximumName)
        {
            //LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())).FirstOrDefault();
            //LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
            //                         where cf.LicenceTypeMaximumName.ToUpper().StartsWith(licenceTypeMaximumName.ToUpper())
            //                         select cf).FirstOrDefault();

            LicenceTypeMaximum f1 = _context.LicenceTypeMaximums.Where(x => x.LicenceTypeMaximumName == licenceTypeMaximumName).FirstOrDefault();
            LicenceTypeMaximum f2 = (from cf in _context.LicenceTypeMaximums
                                     where cf.LicenceTypeMaximumName == licenceTypeMaximumName
                                     select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindLanguageByName
        public Language FindLanguageByName(string languageName)
        {
            Language f1 = _context.Languages.Where(x => x.LanguageName.ToUpper().StartsWith(languageName.ToUpper())).FirstOrDefault();
            Language f2 = (from cf in _context.Languages
                          where cf.LanguageName.ToUpper().StartsWith(languageName.ToUpper())
                          select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindSupportTypeByName
        public SupportType FindSupportTypeByName(string supportTypeName)
        {
            SupportType f1 = _context.SupportTypes.Where(x => x.SupportTypeName.ToUpper().StartsWith(supportTypeName.ToUpper())).FirstOrDefault();
            SupportType f2 = (from cf in _context.SupportTypes
                           where cf.SupportTypeName.ToUpper().StartsWith(supportTypeName.ToUpper())
                           select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindSupportHoursByName
        public SupportHours FindSupportHoursByName(string supportHoursName)
        {
            SupportHours f1 = _context.SupportHours.Where(x => x.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())).FirstOrDefault();
            SupportHours f2 = (from cf in _context.SupportHours
                              where cf.SupportHoursName.ToUpper().StartsWith(supportHoursName.ToUpper())
                              select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindSupportDaysByName
        public SupportDays FindSupportDaysByName(string supportDaysName)
        {
            SupportDays f1 = _context.SupportDays.Where(x => x.SupportDaysName.ToUpper().StartsWith(supportDaysName.ToUpper())).FirstOrDefault();
            SupportDays f2 = (from cf in _context.SupportDays
                               where cf.SupportDaysName.ToUpper().StartsWith(supportDaysName.ToUpper())
                               select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindSupportTerritoryByName
        public SupportTerritory FindSupportTerritoryByName(string supportTerritoryName)
        {
            SupportTerritory f1 = _context.SupportTerritories.Where(x => x.SupportTerritoryName.ToUpper().StartsWith(supportTerritoryName.ToUpper())).FirstOrDefault();
            SupportTerritory f2 = (from cf in _context.SupportTerritories
                              where cf.SupportTerritoryName.ToUpper().StartsWith(supportTerritoryName.ToUpper())
                              select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindSetupFeeByName
        public SetupFee FindSetupFeeByName(string setupFeeName)
        {
            SetupFee f1 = _context.SetupFees.Where(x => x.SetupFeeName.ToUpper().StartsWith(setupFeeName.ToUpper())).FirstOrDefault();
            SetupFee f2 = (from cf in _context.SetupFees
                                   where cf.SetupFeeName.ToUpper().StartsWith(setupFeeName.ToUpper())
                                   select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindMinimumContractByName
        public MinimumContract FindMinimumContractByName(string minimumContractName)
        {
            MinimumContract f1 = _context.MinimumContracts.Where(x => x.MinimumContractName.ToUpper().StartsWith(minimumContractName.ToUpper())).FirstOrDefault();
            MinimumContract f2 = (from cf in _context.MinimumContracts
                           where cf.MinimumContractName.ToUpper().StartsWith(minimumContractName.ToUpper())
                           select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindPaymentFrequencyByName
        public PaymentFrequency FindPaymentFrequencyByName(string paymentFrequencyName)
        {
            PaymentFrequency f1 = _context.PaymentFrequencies.Where(x => x.PaymentFrequencyName.ToUpper().StartsWith(paymentFrequencyName.ToUpper())).FirstOrDefault();
            PaymentFrequency f2 = (from cf in _context.PaymentFrequencies
                                  where cf.PaymentFrequencyName.ToUpper().StartsWith(paymentFrequencyName.ToUpper())
                                  select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindPaymentOptionByName
        public PaymentOption FindPaymentOptionByName(string paymentOptionName)
        {
            PaymentOption f1 = _context.PaymentOptions.Where(x => x.PaymentOptionName.ToUpper().StartsWith(paymentOptionName.ToUpper())).FirstOrDefault();
            PaymentOption f2 = (from cf in _context.PaymentOptions
                                   where cf.PaymentOptionName.ToUpper().StartsWith(paymentOptionName.ToUpper())
                                   select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindFreeTrialPeriodByName
        public FreeTrialPeriod FindFreeTrialPeriodByName(string freeTrialPeriodName)
        {
            FreeTrialPeriod f1 = _context.FreeTrialPeriods.Where(x => x.FreeTrialPeriodName.ToUpper().StartsWith(freeTrialPeriodName.ToUpper())).FirstOrDefault();
            FreeTrialPeriod f2 = (from cf in _context.FreeTrialPeriods
                                where cf.FreeTrialPeriodName.ToUpper().StartsWith(freeTrialPeriodName.ToUpper())
                                select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindVendorByName
        public Vendor FindVendorByName(string vendorName)
        {
            Vendor f1 = _context.Vendors.Where(x => x.VendorName.ToUpper().StartsWith(vendorName.ToUpper())).FirstOrDefault();
            Vendor f2 = (from cf in _context.Vendors
                                  where cf.VendorName.ToUpper().StartsWith(vendorName.ToUpper())
                                  select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region FindThumbnailDocumentTypeByName
        public ThumbnailDocumentType FindThumbnailDocumentTypeByName(string thumbnailDocumentTypeName)
        {
            ThumbnailDocumentType f1 = _context.ThumbnailDocumentTypes.Where(x => x.ThumbnailDocumentTypeName.ToUpper().StartsWith(thumbnailDocumentTypeName.ToUpper())).FirstOrDefault();
            ThumbnailDocumentType f2 = (from cf in _context.ThumbnailDocumentTypes
                              where cf.ThumbnailDocumentTypeName.ToUpper().StartsWith(thumbnailDocumentTypeName.ToUpper())
                              select cf).FirstOrDefault();

            return f2;
        }
        #endregion

        #region GetDescription
        public string GetDescription()
        {
            return Ipsum.GetPhrase(100);
        }

        public string GetDescription(int length)
        {
            return Ipsum.GetPhrase(length);
        }
        #endregion

        #region test
        public IList<SearchFilterTwoColumn> Test(int categoryID, int numberOfUsers)
        {
            #region Crap
            //Data Source=.\SQLEXPRESS;Initial Catalog=CloudCompare.POCOQueryRepository.CloudCompareContext;Integrated Security=True;MultipleActiveResultSets=True
            //int n = 1;
            //var list = (
            //        from x
            //            in _context.Features
            //        where x.Category.CategoryID == 3
            //        group x by x.FeatureID into g
            //        orderby g.Count() descending
            //        select new 
            //        { 
            //            SearchFeatureID = g.Key,
            //            //Feature = g
            //        }).ToList();

            //var oddList = list.Where((cat, index) => index % 2 == 0).ToArray();
            //var evenList = list.Where((cat, index) => index % 2 == 1).ToList();

            //var retVal = 
            //    from y
            //    in _context.Features
            //    where oddList.Select(x => x.SearchFeatureID).Contains(1)
            //    select y;

            //Feature f = _context.Features.Where(x => x.FeatureID == 1).FirstOrDefault();

            //Func<Feature,SearchFeature,bool> newFunc = this.GetFirstColumn;
            //List<Feature> featurelist = _context.Features.Where(x => x.Category.CategoryID == 3)
            //    .ToList();
            #endregion


            //List<Browser> featurelist = _context.Browsers.ToList();
            IList<SearchFilterTwoColumn> allFeatures = GetSearchOptions(categoryID);
            //List<Browser> featurelist = _context.Browsers.ToList();
            //IList<NumberOfUsers> numberOfUsersList = GetNumberOfUsers();
            IList<SearchFilterTwoColumn> browserList = GetSearchFiltersForFilterType<SearchFilterTwoColumn,SearchFilterTwoColumn>(allFeatures,FILTER_BROWSERS);
            IList<SearchFilterTwoColumn> featureList = (IList<SearchFilterTwoColumn>)GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterOneColumn>(allFeatures, FILTER_FEATURES);
            IList<SearchFilterTwoColumn> languageList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_LANGUAGES);
            IList<SearchFilterTwoColumn> mobilePlatformList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_MOBILEPLATFORMS);
            IList<SearchFilterTwoColumn> operatingSystemList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_OPERATINGSYSTEMS);
            IList<SearchFilterTwoColumn> supportDaysList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTDAYS);
            IList<SearchFilterTwoColumn> supportHoursList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTHOURS);
            IList<SearchFilterTwoColumn> supportTypesList = GetSearchFiltersForFilterType<SearchFilterTwoColumn, SearchFilterTwoColumn>(allFeatures, FILTER_SUPPORTTYPES);

            
            browserList.ToList().AddRange(featureList.ToList());
            browserList.ToList().AddRange(languageList);
            browserList.ToList().AddRange(mobilePlatformList);
            browserList.ToList().AddRange(operatingSystemList);
            browserList.ToList().AddRange(supportDaysList);
            browserList.ToList().AddRange(supportHoursList);
            browserList.ToList().AddRange(supportTypesList);
            //IList<SearchFilterTwoColumn> index = browserList;
            var index = (from browsers in browserList select browsers)
                .Union(from features in featureList select features)
                .Union(from languages in languageList select languages)
                .Union(from mobileplatforms in mobilePlatformList select mobileplatforms)
                .Union(from operatingsystems in operatingSystemList select operatingsystems)
                .Union(from supportdays in supportDaysList select supportdays)
                .Union(from supporthours in supportHoursList select supporthours)
                .Union(from supporttypes in supportTypesList select supporttypes)
                ;

            return index.ToList();
            //return null;
            
        }
        #endregion

        //private IList<SearchFilterOneColumn> GetSearchFiltersForFilterType<T>(IList<SearchFilterOneColumn> allFilters, string filterType)
        //where T : SearchFilterOneColumn
        //{
        //    return null;
        //}

        #region GetSearchFiltersForFilterType
        private IList<Source> GetSearchFiltersForFilterType<Source,Results>(IList<Source> allFilters, string filterType)
        {
            IList<Source> retVal = null;
            if (typeof(Results) == typeof(SearchFilterOneColumn))
            {
                //IList<SearchFilterOneColumn> retVal1 = GetSearchFiltersForFilterTypeOneCol<SearchFilterOneColumn>(allFilters as IList<SearchFilterOneColumn>, filterType);
                retVal = (IList<Source>)GetSearchFiltersForFilterTypeOneCol<SearchFilterOneColumn>(allFilters as IList<SearchFilterTwoColumn>, filterType);
                //return (IList<SearchFilterOneColumn>)retVal;
                //retVal = (IList<T>)retVal1;
                //return (IList<T>)retVal;
            }
            else if (typeof(Results) == typeof(SearchFilterTwoColumn))
            {
                retVal = (IList<Source>)GetSearchFiltersForFilterTypeTwoCol<SearchFilterTwoColumn>(allFilters as IList<SearchFilterTwoColumn>, filterType);
                //return (IList<T>)retVal;
            }
            return retVal;

        }
        #endregion

        #region GetSearchFiltersForFilterTypeOneCol
        private IList<SearchFilterTwoColumn> GetSearchFiltersForFilterTypeOneCol<T>(IList<SearchFilterTwoColumn> allFilters, string filterType)
        //where T : SearchFilterTwoColumn
        {
            int nStep = 2;
            List<SearchFilterTwoColumn> filterlist = allFilters.Where(x => x.SearchFilterTypeNameCol1 == filterType).ToList();


            List<SearchFilterTwoColumn> test1 = filterlist.Select((item, i) => new SearchFilterTwoColumn()
            {
                SearchFilterNameCol1 = item.SearchFilterNameCol1,
                SearchFilterRowNumberCol1 = i,
                SearchFilterTypeNameCol1 = filterType,
            }).ToList();

            return (IList<SearchFilterTwoColumn>)test1.ToList();
        }
        #endregion


        #region GetSearchFiltersForFilterTypeTwoCol
        private IList<SearchFilterTwoColumn> GetSearchFiltersForFilterTypeTwoCol<T>(IList<SearchFilterTwoColumn> allFilters, string filterType)
        //where T : SearchFilterTwoColumn
        {
            int nStep = 2;
            List<SearchFilterTwoColumn> filterlist = allFilters.Where(x => x.SearchFilterTypeNameCol1 == filterType).ToList();

            var test1 = filterlist.WhereExtended((x, i) => i % nStep == 0)
                .Select((item, i) => new SearchFilterTwoColumn()
                {
                    SearchFilterRowNumberCol1 = i,
                    SearchFilterColumnNumberCol1 = 1,
                    SearchFilterID = item.SearchFilterID,
                    SearchFilterNameCol1 = item.SearchFilterNameCol1,
                    SearchFilterTypeNameCol1 = filterType,
                })
                //.GroupBy(x => x.SearchFeatureID)
                .ToList();
            var test2 = filterlist.Where((x, i) => i % nStep == 1)
                .Select((item, i) => new SearchFilterTwoColumn()
                {
                    SearchFilterRowNumberCol1 = i,
                    SearchFilterColumnNumberCol1 = 2,
                    SearchFilterID = item.SearchFilterID,
                    SearchFilterNameCol1 = item.SearchFilterNameCol1,
                    SearchFilterTypeNameCol1 = filterType,
                })
                //.GroupBy(x => x.SearchFeatureID)
                .ToList();
            //List<SearchFeature> test3 = featurelist.Where((x, i) => i % nStep == 0)
            //    .Select(x => new SearchFeature() { SearchFeatureColumnNumber = 2, SearchFeatureID = x.FeatureID, SearchFeatureName = x.FeatureName })
            //    //.GroupBy(x => x.SearchFeatureID)
            //    .ToList();
            //var retVal = test1.ToListExtended(test2);            
            //test1.AddRange(test2);

            List<SearchFilterTwoColumn> index = test1.Select((item, i) => new SearchFilterTwoColumn()
            {
                SearchFilterNameCol1 = item.SearchFilterNameCol1,
                SearchFilterRowNumberCol1 = i,
                SearchFilterTypeNameCol1 = filterType,
                SearchFilterNameCol2 = test2.Where(x => x.SearchFilterRowNumberCol1 == item.SearchFilterRowNumberCol1).Select(x => x.SearchFilterNameCol1).FirstOrDefault(),
                SearchFilterRowNumberCol2 =
                    test2
                    .Where(x => x.SearchFilterRowNumberCol1 == item.SearchFilterRowNumberCol1)
                    .Select(x => x.SearchFilterRowNumberCol1).FirstOrDefault(),
                SearchFilterTypeNameCol2 = filterType,
            }).ToList();
            //    .First(x => x.Item == search).Index;

            //// or
            //var tagged = list.Select((item, i) => new { Item = item, Index = i });
            //int index = (from pair in tagged
            //             where pair.Item == search
            //             select pair.Index).First();

            return (IList<SearchFilterTwoColumn>)index.ToList();
            //as List<SearchFilterTwoColumn>;
            return null;

        }
        #endregion

        #region GetFirstColumn
        public bool GetFirstColumn(Feature f, SearchFilterOneColumn row)
        {
            return false;
            //int counter = 0;
            ////This will yield when counter is 0 or 1, and not when it's 2, 3, or 4.
            ////The result is yield two, skip 3, repeat.
            //foreach (Browser line in GetBrowsers())
            //{
            //    if (counter == 1)
            //        yield return line;

            //    //add one to the counter and have it wrap, 
            //    //so it is always between 0 and 4 (inclusive).
            //    counter = (counter + 1) % 2;
            //}
        }
        #endregion

        #region GetCategories
        public IList<Category> GetCategories()
        {
            Logger.Debug("GetCategories()");
            IList<Category> list = null;
            try
            {
                list = (from x in _context.Categories
                        select x)
                        .OrderBy(x => x.CategoryName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #region GetOperatingSystems
        public IList<Domain.Models.OperatingSystem> GetOperatingSystems()
        {
            Logger.Debug("GetOperatingSystems()");
            IList<Domain.Models.OperatingSystem> list = null;
            try
            {
                list = (from x in _context.OperatingSystems
                        select x)
                        .OrderBy(x => x.OperatingSystemName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion


        #region GetBrowsers
        public IList<Domain.Models.Browser> GetBrowsers()
        {
            Logger.Debug("GetBrowsers()");
            IList<Domain.Models.Browser> list = null;
            try
            {
                list = (from x in _context.Browsers
                        select x)
                        .OrderBy(x => x.BrowserName)
                    .ToList();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return list;
        }
        #endregion

        #region GetFeaturedCloudware
        IList<SearchResult> ICloudCompareRepository.GetFeaturedCloudware()
        {
            var f1 = _context.CloudApplications
                .Where(x => x.Vendor.VendorLogoURL.Trim().Length > 0)
                .Select(c => new { c.Vendor.VendorName, c.Vendor.VendorLogoURL, c.ServiceName, c.Description });
            var f2 = (from cf in _context.CloudApplications
                      where cf.Vendor.VendorLogoURL.Trim().Length > 0
                      select new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description });
            var f3 = (from cf in _context.CloudApplications
                      where cf.Vendor.VendorLogoURL.Trim().Length > 0
                      let Applications = new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description }
                      select Applications);

            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();
            var f4 = (from cf in _context.CloudApplications
                      where cf.Vendor.VendorLogoURL.Trim().Length > 0
                      select new SearchResult
                      {
                          CloudApplicationID = cf.CloudApplicationID,
                          VendorName = cf.Vendor.VendorName,
                          VendorLogoURL = imagesPath + cf.Vendor.VendorLogoURL,
                          ServiceName = cf.ServiceName,
                          Description = cf.Description
                      });


            return f4.ToList();
        }
        #endregion

        #region GetTopTenCloudware
        IList<SearchResult> ICloudCompareRepository.GetTopTenCloudware()
        {
            var f1 = _context.CloudApplications
                .OrderByDescending(c => c.CloudApplicationID)
                .Where(c => c.CloudApplicationID % 2 == 0)
                .Select(c => new { c.Vendor.VendorName, c.Vendor.VendorLogoURL, c.ServiceName, c.Description })
                .Take(8);
            var f2 = (from cf in _context.CloudApplications
                      where cf.CloudApplicationID % 2 == 0
                      orderby cf.AddDate
                      select new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description }
                      ).Take(10);
            var f3 = (from cf in _context.CloudApplications
                      where cf.CloudApplicationID % 2 == 0
                      orderby cf.AddDate
                      let Applications = new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description }
                      select Applications
                      ).Take(10);

            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();
            var f4 = (from cf in _context.CloudApplications
                      where cf.CloudApplicationID % 2 == 0
                      orderby cf.AddDate
                      select new SearchResult
                      {
                          CloudApplicationID = cf.CloudApplicationID,
                          VendorName = cf.Vendor.VendorName,
                          VendorLogoURL = imagesPath + cf.Vendor.VendorLogoURL,
                          ServiceName = cf.ServiceName,
                          Description = cf.Description
                      }
                      ).Take(10);
            return f4.ToList();
        }
        #endregion

        #region GetNewCloudware
        IList<SearchResult> ICloudCompareRepository.GetNewCloudware()
        {
            var f1 = _context.CloudApplications
                .OrderByDescending(c => c.AddDate)
                .Select(c => new { c.Vendor.VendorName, c.Vendor.VendorLogoURL, c.ServiceName, c.Description })
                .Take(8);
            var f2 = (from cf in _context.CloudApplications
                      orderby cf.AddDate
                      select new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description }
                      ).Take(10);
            var f3 = (from cf in _context.CloudApplications
                      orderby cf.AddDate
                      let Applications = new { cf.Vendor.VendorName, cf.Vendor.VendorLogoURL, cf.ServiceName, cf.Description }
                      select Applications
                      ).Take(10);

            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();
            var f4 = (from cf in _context.CloudApplications
                      orderby cf.AddDate descending
                      select new SearchResult
                      {
                          CloudApplicationID = cf.CloudApplicationID,
                          VendorName = cf.Vendor.VendorName,
                          VendorLogoURL = imagesPath + cf.Vendor.VendorLogoURL,
                          ServiceName = cf.ServiceName,
                          Description = cf.Description
                      }
                      ).Take(10);
            return f4.ToList();
        }
        #endregion


        #region GetSearchOptions
        public IList<SearchFilterTwoColumn> GetSearchOptions(int categoryID)
        {
            Logger.Debug("GetSearchFilters()");
            //IList<SearchFeature> list = null;
            try
            {

                var listTemp = (
                    from x
                    in _context.Features
                    //where x.Category.CategoryID == categoryID
                    where x.Categories.Any(y => y.CategoryID == categoryID)
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                        //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                        SearchFilterID = x.FeatureID,
                        SearchFilterNameCol1 = x.FeatureName,
                        SearchFilterTypeNameCol1 = FILTER_FEATURES,
                    }
                ).ToList();

                var list = (
                    //from x 
                    //    in _context.Features
                    //    //where x.Category.CategoryID == categoryID
                    //where x.Categories.Any(y => y.CategoryID == categoryID)
                    //select new SearchFilterTwoColumn()
                    //{
                    //    //CategoryCol1 = x.Category,
                    //    SearchFilterID = x.FeatureID,
                    //    SearchFilterNameCol1 = x.FeatureName,
                    //    SearchFilterTypeNameCol1 = FILTER_FEATURES,
                    //}
                    //)

                                        from x
                    in _context.Features
                    //where x.Category.CategoryID == categoryID
                    where x.Categories.Any(y => y.CategoryID == categoryID)
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = x.Categories.FirstOrDefault(z => z.CategoryID == categoryID),
                        //CategoryCol1 = x.Categories.AsQueryable().FirstOrDefault(z => z.CategoryID == FindCategoryByName),
                        SearchFilterID = x.FeatureID,
                        SearchFilterNameCol1 = x.FeatureName,
                        SearchFilterTypeNameCol1 = FILTER_FEATURES,
                    }
                )
                    .Union(
                    from x
                        in _context.OperatingSystems
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.OperatingSystemID,
                        SearchFilterNameCol1 = x.OperatingSystemName,
                        SearchFilterTypeNameCol1 = FILTER_OPERATINGSYSTEMS,
                    }
                    )
                    
                    .Union(
                    from x
                        in _context.Browsers
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.BrowserID,
                        SearchFilterNameCol1 = x.BrowserName,
                        SearchFilterTypeNameCol1 = FILTER_BROWSERS,
                    }
                    )

                    .Union(
                    from x
                        in _context.MobilePlatforms
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.MobilePlatformID,
                        SearchFilterNameCol1 = x.MobilePlatformName,
                        SearchFilterTypeNameCol1 = FILTER_MOBILEPLATFORMS,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportTypes
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportTypeID,
                        SearchFilterNameCol1 = x.SupportTypeName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTTYPES,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportDays
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportDaysID,
                        SearchFilterNameCol1 = x.SupportDaysName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTDAYS,
                    }
                    )

                    .Union(
                    from x
                        in _context.SupportHours
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.SupportHoursID,
                        SearchFilterNameCol1 = x.SupportHoursName,
                        SearchFilterTypeNameCol1 = FILTER_SUPPORTHOURS,
                    }
                    )

                    .Union(
                    from x
                        in _context.Languages
                    //where x.Category.CategoryID == categoryID
                    select new SearchFilterTwoColumn()
                    {
                        CategoryCol1 = null,
                        SearchFilterID = x.LanguageID,
                        SearchFilterNameCol1 = x.LanguageName,
                        SearchFilterTypeNameCol1 = FILTER_LANGUAGES,
                    }
                    )

                    .OrderBy(x => x.SearchFilterTypeNameCol1)
                    .ToList();
                return list;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return null;
        }
        #endregion


        #region GetSearchResults
        public IList<CloudApplication> GetSearchResults(System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            var retVal = _context.CloudApplications.AsExpandable().Where(predicate.Expand());

            //var retVal2 = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //var retVal3 = _context.CloudApplications
            //    .Where(x => x.CloudApplicationFeatures.Any(y => y.Feature.FeatureName == "High Definition Video"))
            //    .Where(x => x.CloudApplicationFeatures.Any(y => y.Feature.FeatureName == "Multiple Meeting Hosts/Chairperson"))
            //    .Select(y => new CloudApplication()
            //    {
            //        CloudApplicationID = y.CloudApplicationID,
            //        Description = y.Description,
            //        ServiceName = y.ServiceName,
            //        Vendor = y.Vendor,
            //        ApplicationCostOneOff = y.ApplicationCostOneOff,
            //        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
            //        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
            //        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
            //        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
            //        FreeTrialPeriod = y.FreeTrialPeriod,
            //        SetupFee = y.SetupFee,

            //    }
            //    );
            
            return retVal.ToList();
        }
        #endregion

        #region GetCloudApplication
        public CloudApplication GetCloudApplication(int cloudApplicationID)
        {
            //return _context.FindById(cloudApplicationID);
            var terVal1 = _context.CloudApplications.Where(x => x.CloudApplicationID == cloudApplicationID);
            var retVal2 = (from ca in _context.CloudApplications where ca.CloudApplicationID == cloudApplicationID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion

        #region GetCloudApplicationThumbnailDocument
        public ThumbnailDocument GetCloudApplicationThumbnailDocument(int thumbnailDocumentID)
        {
            //return _context.FindById(cloudApplicationID);
            var retVal1 = _context.ThumbnailDocuments.Where(x => x.ThumbnailDocumentID == thumbnailDocumentID);
            var retVal2 = (from ca in _context.ThumbnailDocuments where ca.ThumbnailDocumentID == thumbnailDocumentID select ca).FirstOrDefault();
            return retVal2;
        }
        #endregion



        public IList<NumberOfUsers> GetNumberOfUsers()
        {
            List<NumberOfUsers> NumberOfUsers = new List<NumberOfUsers>();
            for (int i = 0; i <= 50; i++)
            {
                NumberOfUsers.Add(new NumberOfUsers() { UserValue = i });
            }

            var retVal1 = _context.LicenceTypeMaximums.Select(x => new { User = x.LicenceTypeMaximumName } ).ToList().Select(y => y.User).Where(z => z > 50);

            //var retVal2 = _context.LicenceTypeMinimums.Where(x => int.Parse(x.LicenceTypeMinimumName) > 50).OrderBy(x => int.Parse(x.LicenceTypeMinimumName));

            retVal1.ForEach(x => NumberOfUsers.Add(new NumberOfUsers() { UserValue = x }));
            return NumberOfUsers;
        }
    }


}
