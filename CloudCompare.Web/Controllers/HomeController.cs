using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Logging;
using CloudCompare.POCOQueryRepository;
using CloudCompare.Domain.Contracts.Repositories;
using CloudCompare.Domain.Models;
using CloudCompare.Web.Models;
using CloudCompare.Web.Helpers;
using System.Data.Entity;
using LinqKit;

namespace CloudCompare.Web.Controllers
{
    public class HomeController : Controller
    {
        const string FILTER_BROWSERS = "BROWSERS";
        const string FILTER_FEATURES = "FEATURES";
        const string FILTER_OPERATINGSYSTEMS = "OPERATINGSYSTEMS";
        const string FILTER_SUPPORTTYPES = "SUPPORTTYPES";
        const string FILTER_SUPPORTDAYS = "SUPPORTDAYS";
        const string FILTER_SUPPORTHOURS = "SUPPORTHOURS";
        const string FILTER_LANGUAGES = "LANGUAGES";
        const string FILTER_MOBILEPLATFORMS = "MOBILEPLATFORMS";

        readonly ICloudCompareRepository _repository;

        // this is Castle.Core.Logging.ILogger, not log4net.Core.ILogger
        public ILogger Logger { get; set; }

        private ICustomSession CustomSession { get; set; }

        public HomeController(ICustomSession session, ICloudCompareRepository repository)
        {
            CustomSession = session;
            _repository = repository;
        }

        #region xIndex
        public ActionResult xIndex()
        {
            Logger.Debug("Entered site");

            var bc = Request.Browser;
            int x = bc.EcmaScriptVersion.Major;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            return View();
            //return RedirectToAction("HomePage");
        }
        #endregion

        #region Index
        public ActionResult Index(string id, string javascriptenabled)
        {
            Logger.Debug("Entered site");
            CustomSession.JavaScriptEnabled = true;

            var bc = Request.Browser;
            int x = bc.EcmaScriptVersion.Major;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            //return View();
            return RedirectToAction("HomePage");
            //return RedirectToAction("SearchPage");
        }
        #endregion

        #region IndexCustom
        public ActionResult IndexCustom(string id, string javascriptenabled)
        {
            Logger.Debug("Entered site");

            CustomSession.JavaScriptEnabled = javascriptenabled != null ? Convert.ToBoolean(javascriptenabled) : CustomSession.JavaScriptEnabled;
            var bc = Request.Browser;
            int x = bc.EcmaScriptVersion.Major;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            //data.LoadFakeReferenceData(context);
            //context.SaveChanges();

            //var db = new FakeCloudCompareContext();

            //var data = new CloudCompareContext();
            //var viewData = data.CloudApplications.ToList();
            //return View(data.CloudApplications.ToList());

            //return View();
            return RedirectToAction("Index");
        }
        #endregion

        #region About
        public ActionResult About()
        {
            return View();
        }
        #endregion

        #region HomePage
        public ActionResult HomePage()
        {
            var model = new HomePageModel();
            model.SearchInputModel = new SearchInputModel();

            model.SearchInputModel.Categories = this.GetCategories();
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();
            model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = 6;
            model.SearchInputModel.Firstname = "Glyn";
            model.SearchInputModel.EMailAddress = "somebody@anywhere.com";

            model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();

            var model2 = new SearchFiltersModel();
            //IEnumerable<CloudCompare.Web.Models.SearchFilterModel> filters = _repository.GetSearchOptions(3).Select( x => new SearchFilterModel() { 
            //    //CategoryID = x.Category.CategoryID,
            //    SearchFilterID = x.Category.CategoryID,
            //    SearchFilterName = x.SearchFeatureName,
            //    Selected = false}
            //    );

            ////model2.SearchFilters = features;
            //model2.SearchFiltersBrowsers = filters.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            //model2.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersLanguages = filters.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersMobilePlatforms = filters.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersOperatingSystems = filters.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS);
            //model2.SearchFiltersSupportDays = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersSupportHours = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersSupportTypes = filters.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;



            return View(model);

            //return View("Index");
        }
        #endregion

        #region HomePage POST
        [HttpPost]
        public ActionResult HomePage(HomePageModel model)
        {
            model.SearchInputModel.Categories = this.GetCategories();
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();


            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;
            SearchModel searchModel = new SearchModel();
            searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchInputModel.ChosenCategoryID;
            searchModel.SearchFiltersModel.Categories = model.SearchInputModel.Categories;
            searchModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchInputModel.ChosenNumberOfUsers;
            searchModel.SearchFiltersModel.NumberOfUsers = model.SearchInputModel.NumberOfUsers;

            searchModel = this.GetSearchModelFilters(searchModel,false);
            searchModel.SearchResultsModel.SearchResults = this.GetSearchResults(searchModel).ToList();

            return View("SearchPage",searchModel);
        }
        #endregion

        #region xHomePage POST
        [HttpPost]
        public ActionResult xHomePage(SearchInputModel model)
        {
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            return View(model);
        }
        #endregion

        #region HomePage with selected tab
        [HttpPost]
        public ActionResult xHomePage(string tab)
        {
            var model = new HomePageModel();
            model.SearchInputModel.Categories = this.GetCategories();
            model.SearchInputModel.NumberOfUsers = this.GetNumberOfUsers();
            model.SearchInputModel.ChosenNumberOfUsers = 2;
            model.SearchInputModel.ChosenCategoryID = 6;
            model.SearchInputModel.Firstname = "Glyn";
            model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = int.Parse(tab);

            //TabbedSearchResults tsr = new TabbedSearchResults();
            //tsr.FeaturedCloudware = repository.GetFeaturedCloudware();
            //tsr.NewCloudware = repository.GetNewCloudware();
            //tsr.TopTenCloudware = repository.GetTopTenCloudware();
            ////return View(context.CloudApplications.ToList());
            //ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            //ViewBag.VisibleResultsTab = int.Parse(tab);
            //return View(tsr);

            //return View("Index");
            return View(model);
        }
        #endregion

        #region SearchPage
        public ActionResult SearchPage()
        {

            var twoCols = _repository.Test(3,5);
            
            //var query = from x in Enumerable.Range(0, twoCols.GetUpperBound(0))
            //from y in Enumerable.Range(0, twoCols.GetUpperBound(1))
            //where twoCols[x, y] = true
            //select new { x, y };

            //twoCols.AsQueryable();
            //var filtersTwoCols =
            //    from twoColsResults
            //    in twoCols.AsEnumerable();
                //.Where(x => x.SearchFeatureTypeName != FILTER_FEATURES)
                //.Select(x => new SearchFilterModelOneColumn()
                //{
                //    Category = x.Category != null ? x.Category : null,
                //    //SearchFilterID = x.Category.CategoryID,
                //    SearchFilterName = x.SearchFeatureName,
                //    SearchFilterType = x.SearchFeatureTypeName,
                //    Selected = false
                //}
                //);
            //var model = new HomePageModel();
            //model.Categories = _repository.GetCategories();
            //model.OperatingSystems = _repository.GetOperatingSystems();
            //model.ChosenOperatingSystemID = 2;
            //model.ChosenCategoryID = 6;
            //model.Name = "aaa";

            //model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            //model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            //model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            //model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();

            var filtersOneColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn()
                    {
                        Category = x.CategoryCol1 != null ? x.CategoryCol1 : null,
                        //SearchFilterID = x.Category.CategoryID,
                        SearchFilterName = x.SearchFilterNameCol1,
                        SearchFilterType = x.SearchFilterTypeNameCol1,
                        Selected = false,
                    }
                );

            var filtersTwoColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                .Select(x => new SearchFilterModelTwoColumn()
                    {
                        //Category = x.Category != null ? x.Category : null,
                        //SearchFilterID = x.Category.CategoryID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                        Col2SearchFilterName = x.SearchFilterNameCol2,
                        Col2SearchFilterType = x.SearchFilterTypeNameCol2,
                        Col2Selected = false
                    }
                );
            //List<SearchFilterModelOneColumn> list = filtersOneColumn.ToList();
            //int nStep = 2;
            //var test = list.Where((x, i) => i % nStep == 0);

            //var model2 = new SearchFiltersModel();
            ////model2.SearchFilters = features;
            //model2.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            //model2.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);
            ////model2.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersOperatingSystems.FeatureFilters = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
            //model2.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);


            var model3 = new SearchModel();
            //model3.SearchFiltersModel.SearchFilters = features;
            model3.SearchFiltersModel.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
            model3.SearchFiltersModel.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            model3.SearchFiltersModel.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
            model3.SearchFiltersModel.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
            model3.SearchFiltersModel.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
            model3.SearchFiltersModel.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
            model3.SearchFiltersModel.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
            model3.SearchFiltersModel.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);


            var results = this.SearchProducts(model3.SearchFiltersModel, null).ToList();
            //var temp = results.Where(x => x.SetupFee == null).ToList();

            //var results = _repository.GetSearchResults()
            var results2 = results
                .Select(y => new SearchResultModel()
            {
                CloudApplicationID = y.CloudApplicationID,
                Description = y.Description,
                SearchResultID = y.CloudApplicationID,
                ServiceName = y.ServiceName,
                VendorLogoURL = y.Vendor.VendorLogoURL.AddImagePath(),
                VendorName = y.Vendor.VendorName,
                ApplicationCostOneOff = y.ApplicationCostOneOff,
                ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
                ApplicationCostPerMonth = y.ApplicationCostPerMonth,
                ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
                CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
                FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
                SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,

            }
            );
            model3.SearchResultsModel.SearchResults = results2.ToList();

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            ViewBag.VisibleResultsTab = 1;



            return View(model3);

            //return View("Index");
        }
        #endregion

        #region SearchPageMoreInfo POST
        [HttpPost]
        public ActionResult SearchPageMoreInfo(string buttonID)
        {
            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            return View();
        }
        #endregion

        #region SearchPage POST
        [HttpPost]
        public ActionResult SearchPage(SearchModel model, FormCollection formCollection)
        {
            //PROCEED_BUTTON_APPLICATION_ID_

            var oldCategory = model.SearchFiltersModel.PreviouslyChosenCategoryID;
            var newCategory = model.SearchFiltersModel.ChosenCategoryID;

            var textButton = formCollection
                .Keys
                .OfType<string>()
                .Where(x => x.StartsWith("PROCEED_BUTTON_APPLICATION_ID_"))
                //.SingleOrDefault()
                ;

            if (textButton.Count() == 0)
            {
                #region via the filter button
                //must have come in via the filter button
                model.SearchFiltersModel.Categories = this.GetCategories();
                model.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();
                model.SearchFiltersModel.PreviouslyChosenCategoryID = newCategory;
                
                //SearchModel newModel = new SearchModel();
                //newModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
                //newModel.SearchFiltersModel.Categories = this.GetCategories();
                //newModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
                //newModel.SearchFiltersModel.NumberOfUsers = this.GetNumberOfUsers();

                //newModel = this.GetSearchModel(newModel);
                if (oldCategory != newCategory)
                {
                    //ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                    model = this.GetSearchModelFilters(model, true);
                }
                
                model.SearchResultsModel.SearchResults = this.GetSearchResults(model).ToList();


                #region crap
                //var results = this.SearchProducts(model3.SearchFiltersModel, null).ToList();
                ////var temp = results.Where(x => x.SetupFee == null).ToList();

                ////var results = _repository.GetSearchResults()
                //var results2 = results
                //    .Select(y => new SearchResultModel()
                //    {
                //        CloudApplicationID = y.CloudApplicationID,
                //        Description = y.Description,
                //        SearchResultID = y.CloudApplicationID,
                //        ServiceName = y.ServiceName,
                //        VendorLogoURL = y.Vendor.VendorLogoURL.AddImagePath(),
                //        VendorName = y.Vendor.VendorName,
                //        ApplicationCostOneOff = y.ApplicationCostOneOff,
                //        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
                //        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
                //        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
                //        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
                //        FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
                //        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,

                //    }
                //);
                //model3.SearchResultsModel.SearchResults = results2.ToList();
                #endregion


                ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
                //return View(newModel);
                bool removed = ModelState.Remove("SearchFiltersModel.PreviouslyChosenCategoryID");
                ModelState.Clear();
                return View(model);
                #endregion
            }
            else
            {
                if (textButton.Count() > 1)
                {
                    throw new Exception("Internal server error");
                }
                else
                {
                    var pressedButton = textButton.ElementAt(0);
                    int cloudApplicationID = int.Parse(pressedButton.Replace("PROCEED_BUTTON_APPLICATION_ID_",""));
                    
                    CloudApplication ca = _repository.GetCloudApplication(cloudApplicationID);
                    CloudApplicationModel cam = new CloudApplicationModel()
                    {
                        AddDate = ca.AddDate,
                        ApplicationContentStatusID = ca.ApplicationContentStatusID,
                        ApplicationCostOneOff = ca.ApplicationCostOneOff,
                        ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                        ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                        ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthExtra,
                        ApprovalAssignedPersonID = ca.ApprovalAssignedPersonID,
                        ApprovalStatusID = ca.ApprovalStatusID,
                        AverageEaseOfUse = ca.AverageEaseOfUse,
                        AverageFunctionality = ca.AverageFunctionality,
                        AverageOverallRating = ca.AverageOverallRating,
                        AverageValueForMoney = ca.AverageValueForMoney,
                        Brand = ca.Brand,
                        Browsers = ca.Browsers,
                        CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,
                        Category = ca.Category,
                        CloudApplicationFeatures = ca.CloudApplicationFeatures,
                        CloudApplicationID = ca.CloudApplicationID,
                        CloudApplicationLogo = ca.CloudApplicationLogo,
                        CompanyURL = ca.CompanyURL,
                        Description = ca.Description,
                        FacebookFollowers = ca.FacebookFollowers,
                        FacebookURL = ca.FacebookURL,
                        FreeTrialBuyNow = new FreeTrialBuyNowModel()
                        {
                            FirstName = "Glyn",
                            EMailAddress = "glyn.threadgold@yahoo.co.uk",
                        },
                        FreeTrialPeriod = ca.FreeTrialPeriod,
                        IsPromotional = ca.IsPromotional,
                        Languages = ca.Languages,
                        LicenceTypeMaximum = ca.LicenceTypeMaximum,
                        LicenceTypeMinimum = ca.LicenceTypeMinimum,
                        LinkedInFollowers = ca.LinkedInFollowers,
                        LinkedInURL = ca.LinkedInURL,
                        MaximumMeetingAttendees = ca.MaximumMeetingAttendees,
                        MaximumWebinarAttendees = ca.MaximumWebinarAttendees,
                        MinimumContract = ca.MinimumContract,
                        MobilePlatforms = ca.MobilePlatforms,
                        OperatingSystems = ca.OperatingSystems,
                        PaymentFrequency = ca.PaymentFrequency,
                        PaymentOptions = ca.PaymentOptions,
                        Ratings = ca.Ratings.Select(x => new CloudApplicationRatingModel()
                        {
                            CloudApplicationEaseOfUse = x.CloudApplicationEaseOfUse,
                            CloudApplicationFunctionality = x.CloudApplicationFunctionality,
                            CloudApplicationOverallRating = x.CloudApplicationOverallRating,
                            CloudApplicationRatingID = x.CloudApplicationRatingID,
                            CloudApplicationRatingReviewerCompany = x.CloudApplicationRatingReviewerCompany,
                            CloudApplicationRatingReviewerName = x.CloudApplicationRatingReviewerName,
                            CloudApplicationRatingReviewerTitle = x.CloudApplicationRatingReviewerTitle,
                            CloudApplicationRatingText = x.CloudApplicationRatingText,
                            CloudApplicationValueForMoney = x.CloudApplicationValueForMoney,
                        }).Take(2).ToList(),
                        Reviews = ca.Reviews.Select(x => new CloudApplicationReviewModel()
                            { 
                            CloudApplicationReviewDate = x.CloudApplicationReviewDate,
                            CloudApplicationReviewHeadline = x.CloudApplicationReviewHeadline,
                            CloudApplicationReviewID = x.CloudApplicationReviewID,
                            CloudApplicationReviewPublisherName = x.CloudApplicationReviewPublisherName,
                            CloudApplicationReviewText = x.CloudApplicationReviewText,
                            CloudApplicationReviewURL = x.CloudApplicationReviewURL,
                            }).Take(2).ToList()
                        ,
                        SearchResultModel = new SearchResultModel()
                        {
                            ApplicationCostOneOff = ca.ApplicationCostOneOff,
                            ApplicationCostPerAnnum = ca.ApplicationCostPerAnnum,
                            ApplicationCostPerMonth = ca.ApplicationCostPerMonth,
                            ApplicationCostPerMonthExtra = ca.ApplicationCostPerMonthExtra,
                            CallsPackageCostPerMonth = ca.CallsPackageCostPerMonth,
                            CloudApplicationID = ca.CloudApplicationID,
                            Description = ca.Description,
                            FreeTrialPeriod = ca.FreeTrialPeriod.FreeTrialPeriodName,
                            SearchResultID = 0,
                            ServiceName = ca.ServiceName,
                            SetupFee = ca.SetupFee.SetupFeeName,
                            VendorLogoURL = ca.Vendor.VendorLogoURL.AddImagePath(),
                            VendorName = ca.Vendor.VendorName,
                            ResultDisplayFormat = SearchResultDisplayFormat.Single,
                        },
                        ServiceName = ca.ServiceName,
                        SetupFee = ca.SetupFee,
                        SupportDays = ca.SupportDays,
                        SupportHours = ca.SupportHours,
                        SupportTerritories = ca.SupportTerritories,
                        SupportTypes = ca.SupportTypes,
                        ThumbnailDocuments = ca.ThumbnailDocuments,
                        Title = ca.Title,
                        TwitterFollowers = ca.TwitterFollowers,
                        TwitterURL = ca.TwitterURL,
                        Vendor = ca.Vendor,
                        VideoTrainingSupport = ca.VideoTrainingSupport,
                    };
                    return ForceDisplayTemplateViewFor(cam);
                }
            }
        }
        #endregion

        #region xSearchPage3 POST
        [HttpPost]
        public ActionResult xSearchPage3(SearchFiltersForFeatureTypeModel model2)
        {
            //var results = this.SearchProducts(model2.SearchFiltersModel, null);

            //var model = new HomePageModel();
            //model.Categories = _repository.GetCategories();
            //model.OperatingSystems = _repository.GetOperatingSystems();
            //model.ChosenOperatingSystemID = 2;
            //model.ChosenCategoryID = 6;
            //model.Name = "aaa";

            //model.TabbedSearchResults = new Domain.Models.TabbedSearchResults();
            //model.TabbedSearchResults.FeaturedCloudware = _repository.GetFeaturedCloudware();
            //model.TabbedSearchResults.TopTenCloudware = _repository.GetTopTenCloudware();
            //model.TabbedSearchResults.NewCloudware = _repository.GetNewCloudware();

            ////var model2 = new SearchFiltersModel();
            //var filtersOneColumn =
            //    _repository.GetSearchOptions(3)
            //    .Where(x => x.SearchFeatureTypeName == FILTER_FEATURES)
            //    .Select(x => new SearchFilterModelOneColumn()
            //    {
            //        Category = x.Category != null ? x.Category : null,
            //        //SearchFilterID = x.Category.CategoryID,
            //        SearchFilterName = x.SearchFeatureName,
            //        SearchFilterType = x.SearchFeatureTypeName,
            //        Selected = false
            //    }
            //    );
            //var filtersTwoColumn =
            //    _repository.GetSearchOptions(3)
            //    .Where(x => x.SearchFeatureTypeName != FILTER_FEATURES)
            //    .Select(x => new SearchFilterModelTwoColumn()
            //    {
            //        Category = x.Category != null ? x.Category : null,
            //        //SearchFilterID = x.Category.CategoryID,
            //        SearchFilterName = x.SearchFeatureName,
            //        SearchFilterType = x.SearchFeatureTypeName,
            //        Selected = false
            //    }
            //    );


            ////model2.SearchFiltersModel.SearchFilters = features.ToList();
            //model2.SearchFiltersModel.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_BROWSERS);
            ////model2.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersModel.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);
            //model2.SearchFiltersModel.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_LANGUAGES);
            //model2.SearchFiltersModel.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_MOBILEPLATFORMS);
            //model2.SearchFiltersModel.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_OPERATINGSYSTEMS);
            //model2.SearchFiltersModel.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTDAYS);
            //model2.SearchFiltersModel.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTHOURS);
            //model2.SearchFiltersModel.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.SearchFilterType == FILTER_SUPPORTTYPES);

            ////var results = this.SearchProducts(model3.SearchFiltersModel, null).ToList();
            //var temp = results.Where(x => x.SetupFee == null).ToList();

            ////var results = _repository.GetSearchResults()
            //var results2 = results
            //    .Select(y => new SearchResultModel()
            //    {
            //        CloudApplicationID = y.CloudApplicationID,
            //        Description = y.Description,
            //        SearchResultID = y.CloudApplicationID,
            //        ServiceName = y.ServiceName,
            //        VendorLogoURL = y.Vendor.VendorLogoURL.AddImagePath(),
            //        VendorName = y.Vendor.VendorName,
            //        ApplicationCostOneOff = y.ApplicationCostOneOff,
            //        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
            //        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
            //        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
            //        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
            //        FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
            //        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,

            //    }
            //);
            //model2.SearchResultsModel.SearchResults = results2.ToList();

            ViewBag.JavaScriptEnabled = CustomSession.JavaScriptEnabled;
            //ViewBag.VisibleResultsTab = 1;



            //return View(model2);

            //return View("Index");
            return View();
        }
        #endregion

        #region SearchProducts
        IQueryable<CloudCompare.Domain.Models.CloudApplication> SearchProducts(SearchFiltersModel model, params string[] keywords)
        {
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> allPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> categoryPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> browsersPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> featuresPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> operatingSystemsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportTypesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportDaysPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> supportHoursPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> languagesPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> mobilePlatformsPredicate;
            System.Linq.Expressions.Expression<Func<CloudApplication, bool>> numberOfUsersPredicate;

            if (
                model.SearchFiltersBrowsers.All(x => x.Col1Selected == false) &
                //model.SearchFiltersFeatures.FeatureFilters.All(x => x.Selected == false) &
                model.SearchFiltersFeatures.All(x => x.Selected == false) &
                model.SearchFiltersLanguages.All(x => x.Col1Selected == false) &
                model.SearchFiltersMobilePlatforms.All(x => x.Col1Selected == false) &
                model.SearchFiltersOperatingSystems.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportDays.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportHours.All(x => x.Col1Selected == false) &
                model.SearchFiltersSupportTypes.All(x => x.Col1Selected == false)
                )
            {
                allPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                browsersPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                featuresPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                operatingSystemsPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
            }
            else
            {
                allPredicate = LinqKit.PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                categoryPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                if (model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).Any(x => x.Col1SearchFilterType.StartsWith("BROWSERS")))
                {
                    browsersPredicate = PredicateBuilder.False<CloudCompare.Domain.Models.CloudApplication>();
                }
                else
                {
                    browsersPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                }

                //if (model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).Any(x => x.SearchFilterType.StartsWith("FEATURES")))
                if (model.SearchFiltersFeatures.Where(x => x.Selected == true).Any(x => x.SearchFilterType.StartsWith("FEATURES")))
                {
                    featuresPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                }
                else
                {
                    featuresPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                }
                operatingSystemsPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportTypesPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportDaysPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                supportHoursPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                languagesPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                mobilePlatformsPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
                numberOfUsersPredicate = PredicateBuilder.True<CloudCompare.Domain.Models.CloudApplication>();
            }
            //foreach (string keyword in keywords)
            //{
            //    string temp = keyword;
            //    predicate = predicate.Or(p => p.Description.Contains(temp));
            //}

            //foreach (SearchFilterModel checkedentry in model.SearchFilters)
            //{
            //    if (checkedentry.Selected)
            //    {
            //        predicate = predicate.Or(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName == checkedentry.SearchFilterName));
            //    }
            //}

            //Dictionary<string, Action<SearchFilterModel>> actions =
            //         new Dictionary<string, Action<SearchFilterModel>>();

            //actions.Add("FEATURES", DoThis);
            //actions.Add("OPERATINGSYSTEMS", DoThat);
            //actions.Add("BROWSERS", DoSomethingElse);

            //Action<SearchFilterModel,string> action = null;
            //model.SearchFilters.ToList().ForEach(x => action(x,x.SearchFilterName));
            //model.SearchFilters.ForEachMatch(s => s.SearchFilterType.StartsWith("a"), s => Console.WriteLine(s));

            InsertCategoryFilterClause(model.ChosenCategoryID,ref categoryPredicate);
            InsertNumberOfUsersFilterClause(model.ChosenNumberOfUsers, ref categoryPredicate);
            model.SearchFiltersBrowsers.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("BROWSERS"), x => InsertBrowserFilterClause(x, ref browsersPredicate));
            //model.SearchFiltersFeatures.FeatureFilters.Where(x => x.Selected == true).ForEachMatch(x => x.SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));
            model.SearchFiltersFeatures.Where(x => x.Selected == true).ForEachMatch(x => x.SearchFilterType.StartsWith("FEATURES"), x => InsertFeatureFilterClause(x, ref featuresPredicate));

            model.SearchFiltersOperatingSystems.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("OPERATINGSYSTEMS"), x => InsertOperatingSystemFilterClause(x, ref operatingSystemsPredicate));
            model.SearchFiltersSupportTypes.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTTYPES"), x => InsertSupportTypeFilterClause(x, ref supportHoursPredicate));
            model.SearchFiltersSupportDays.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTDAYS"), x => InsertSupportDaysFilterClause(x, ref supportDaysPredicate));
            model.SearchFiltersSupportHours.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("SUPPORTHOURS"), x => InsertSupportHoursFilterClause(x, ref supportHoursPredicate));
            model.SearchFiltersLanguages.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("LANGUAGES"), x => InsertLanguageFilterClause(x, ref languagesPredicate));
            model.SearchFiltersMobilePlatforms.Where(x => x.Col1Selected == true).ForEachMatch(x => x.Col1SearchFilterType.StartsWith("MOBILEPLATFORMS"), x => InsertMobilePlatformFilterClause(x, ref mobilePlatformsPredicate));

            allPredicate = allPredicate.And(categoryPredicate.Expand());
            allPredicate = allPredicate.And(numberOfUsersPredicate.Expand());

            allPredicate = allPredicate.And(browsersPredicate.Expand());
            
            allPredicate = allPredicate.And(featuresPredicate.Expand());
            allPredicate = allPredicate.And(operatingSystemsPredicate.Expand());
            allPredicate = allPredicate.And(supportTypesPredicate.Expand());
            allPredicate = allPredicate.And(supportDaysPredicate.Expand());
            allPredicate = allPredicate.And(supportHoursPredicate.Expand());
            allPredicate = allPredicate.And(languagesPredicate.Expand());
            allPredicate = allPredicate.And(mobilePlatformsPredicate.Expand());

            var retVal = _repository.GetSearchResults(allPredicate);

            //var retVal = _repository.GetSearchResults(allPredicate.And(browsersPredicate).And(featuresPredicate));
            return retVal.AsQueryable();
            //return dataContext.Products.Where(predicate);
        }
        #endregion

        #region Inserts
        //public static void CallActionForEachMatch<T>(this IEnumerable<T> values, Func<T, bool> pred, Action<T> act)
        //{
        //    foreach (var value in values.Where(pred))
        //    {
        //        act(value);
        //    }
        //}

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertCategoryFilterClause(int? categoryID, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(categoryID ?? 0) != 0)
            {
                predicate = predicate.And(p => p.Category.CategoryID == categoryID);
            }
            else
            {
                predicate = predicate.Or(p => p.Category.CategoryID == categoryID);
            }
            return predicate;
        }

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertNumberOfUsersFilterClause(int? numberOfUsers, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            if (Convert.ToInt32(numberOfUsers ?? 0) != 0)
            {
                predicate = predicate.And(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                predicate = predicate.And(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            else
            {
                predicate = predicate.Or(p => p.LicenceTypeMaximum.LicenceTypeMaximumName >= numberOfUsers);
                predicate = predicate.Or(p => p.LicenceTypeMinimum.LicenceTypeMinimumName <= numberOfUsers);
            }
            return predicate;
        }

        public System.Linq.Expressions.Expression<Func<CloudApplication, bool>> InsertBrowserFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.Or(p => p.Browsers.Any(x => x.BrowserName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            return predicate;
        }

        public void InsertFeatureFilterClause(SearchFilterModelOneColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            // Do something to element#
            predicate = predicate.And(p => p.CloudApplicationFeatures.Any(x => x.Feature.FeatureName.Trim().ToUpper() == element.SearchFilterName.ToUpper().Trim()));
            //retVal = _context.CloudApplications.Where(x => x.Browsers.Any(y => y.BrowserName == "Firefox")).ToList();
            //return predicate;
        }

        public void InsertOperatingSystemFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.OperatingSystems.Any(x => x.OperatingSystemName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertSupportTypeFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.SupportTypes.Any(x => x.SupportTypeName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertSupportHoursFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportHours.SupportHoursName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertSupportDaysFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(x => x.SupportDays.SupportDaysName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim());
        }

        public void InsertLanguageFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.Languages.Any(x => x.LanguageName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }

        public void InsertMobilePlatformFilterClause(SearchFilterModelTwoColumn element, ref System.Linq.Expressions.Expression<Func<CloudApplication, bool>> predicate)
        {
            predicate = predicate.And(p => p.MobilePlatforms.Any(x => x.MobilePlatformName.Trim().ToUpper() == element.Col1SearchFilterName.ToUpper().Trim()));
        }
        #endregion

        #region ForceDisplayTemplateViewFor
        protected ViewResult ForceDisplayTemplateViewFor(object model)
        {
            return View("ForceDisplayTemplate", model);
        }
        #endregion

        #region ShowImage
        public ActionResult ShowImage(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            return File(td.ThumbnailImage, "image/jpg");
        }
        #endregion

        #region RedirectInCloudCompareWebsiteToShowDocument
        public ActionResult RedirectInCloudCompareWebsiteToShowDocument(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            //td.ThumbnailDocumentURL = "http://www.bbc.co.uk";
            PdfResult pr = new PdfResult(td);
            return pr;
            //td.ThumbnailDocumentURL;
        }
        #endregion

        #region RedirectToDocumentOwnerWebsiteToShowDocument
        public ActionResult RedirectToDocumentOwnerWebsiteToShowDocument(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            td.ThumbnailDocumentURL = "http://www.bbc.co.uk";
            //return View();
            //td.ThumbnailDocumentURL;
            RedirectResult rr = new RedirectResult(td.ThumbnailDocumentURL);
            return rr;
        }
        #endregion

        #region DownloadFile
        public FileResult DownloadFile(int thumbnailDocumentID)
        {
            ThumbnailDocument td = _repository.GetCloudApplicationThumbnailDocument(thumbnailDocumentID);
            //int fid = Convert.ToInt32(id);
            //var files = objData.GetFiles();
            //string filename = (from f in files
            //                   where f.FileId == fid
            //                   select f.FilePath).First();
            string fileName = td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName;
            string contentType = "application/pdf";
            //Parameters to file are
            //1. The File Path on the File Server
            //2. The content type MIME type
            //3. The parameter for the file save by the browser
            //return File(fileName, contentType, "Report.pdf");
            return File(fileName, contentType, td.ThumbnailDocumentFileName);
        }
        #endregion

        #region Header
        public ActionResult HeaderModel(HeaderModel hm, FormCollection fc)
        {
            string button = fc.GetSubmitButtonName();
            HeaderModel h = new HeaderModel();
            return PartialView("HeaderModel",hm);
        }
        #endregion

        #region GetCategories
        public List<CategoryModel> GetCategories()
        {
            List<CategoryModel> retVal = _repository.GetCategories().Select(x => new CategoryModel()
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                SearchFilterID = x.CategoryID,
                Selected = false
            }).ToList();

            return retVal;
        }
        #endregion

        #region GetNumberOfUsers
        public List<NumberOfUsersModel> GetNumberOfUsers()
        {
            List<NumberOfUsersModel> retVal = _repository.GetNumberOfUsers().Select(x => new NumberOfUsersModel()
            {
                UserValue = x.UserValue,
            }).ToList();

            return retVal;
        }
        #endregion

        #region GetSearchModelFilters
        public SearchModel GetSearchModelFilters(SearchModel model, bool featuresOnly)
        {

            var twoCols = _repository.Test((int)model.SearchFiltersModel.ChosenCategoryID, (int)model.SearchFiltersModel.ChosenNumberOfUsers);
            //get all the search filters which need to be rendered as one column
            var filtersOneColumn =
                //_repository.GetSearchOptions(3)
                twoCols
                .Where(x => x.SearchFilterTypeNameCol1 == FILTER_FEATURES)
                .Select(x => new SearchFilterModelOneColumn()
                {
                    Category = x.CategoryCol1 != null ? x.CategoryCol1 : null,
                    //SearchFilterID = x.Category.CategoryID,
                    SearchFilterName = x.SearchFilterNameCol1,
                    SearchFilterType = x.SearchFilterTypeNameCol1,
                    Selected = false,
                }
                );

            var searchModel = new SearchModel();
            if (!featuresOnly)
            {
                //get all the search filters which need to be rendered as two column
                var filtersTwoColumn =
                    //_repository.GetSearchOptions(3)
                    twoCols
                    .Where(x => x.SearchFilterTypeNameCol1 != FILTER_FEATURES)
                    .Select(x => new SearchFilterModelTwoColumn()
                    {
                        //Category = x.Category != null ? x.Category : null,
                        //SearchFilterID = x.Category.CategoryID,
                        Col1SearchFilterName = x.SearchFilterNameCol1,
                        Col1SearchFilterType = x.SearchFilterTypeNameCol1,
                        Col1Selected = false,
                        Col2SearchFilterName = x.SearchFilterNameCol2,
                        Col2SearchFilterType = x.SearchFilterTypeNameCol2,
                        Col2Selected = false
                    }
                    );
                //model3.SearchFiltersModel.SearchFilters = features;
                searchModel.SearchFiltersModel.SearchFiltersBrowsers = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_BROWSERS);
                //model3.SearchFiltersModel.SearchFiltersFeatures.FeatureFilters = filters.Where(x => x.SearchFilterType == FILTER_FEATURES);
                searchModel.SearchFiltersModel.SearchFiltersLanguages = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_LANGUAGES);
                searchModel.SearchFiltersModel.SearchFiltersMobilePlatforms = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_MOBILEPLATFORMS);
                //model3.SearchFiltersModel.SearchFiltersOperatingSystems = new SearchFiltersForFeatureTypeModel();
                searchModel.SearchFiltersModel.SearchFiltersOperatingSystems = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_OPERATINGSYSTEMS).ToList();
                searchModel.SearchFiltersModel.SearchFiltersSupportDays = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTDAYS);
                searchModel.SearchFiltersModel.SearchFiltersSupportHours = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTHOURS);
                searchModel.SearchFiltersModel.SearchFiltersSupportTypes = filtersTwoColumn.Where(x => x.Col1SearchFilterType == FILTER_SUPPORTTYPES);
            }
            else
            {
                searchModel.SearchFiltersModel.SearchFiltersBrowsers = model.SearchFiltersModel.SearchFiltersBrowsers;
                searchModel.SearchFiltersModel.SearchFiltersLanguages = model.SearchFiltersModel.SearchFiltersLanguages;
                searchModel.SearchFiltersModel.SearchFiltersMobilePlatforms = model.SearchFiltersModel.SearchFiltersMobilePlatforms;
                searchModel.SearchFiltersModel.SearchFiltersOperatingSystems = model.SearchFiltersModel.SearchFiltersOperatingSystems;
                searchModel.SearchFiltersModel.SearchFiltersSupportDays = model.SearchFiltersModel.SearchFiltersSupportDays;
                searchModel.SearchFiltersModel.SearchFiltersSupportHours = model.SearchFiltersModel.SearchFiltersSupportHours;
                searchModel.SearchFiltersModel.SearchFiltersSupportTypes = model.SearchFiltersModel.SearchFiltersSupportTypes;
            }

            searchModel.SearchFiltersModel.PreviouslyChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            //searchModel.SearchFiltersModel.ChosenCategoryID = model.SearchFiltersModel.ChosenCategoryID;
            searchModel.SearchFiltersModel.Categories = model.SearchFiltersModel.Categories;
            searchModel.SearchFiltersModel.ChosenNumberOfUsers = model.SearchFiltersModel.ChosenNumberOfUsers;
            searchModel.SearchFiltersModel.NumberOfUsers = model.SearchFiltersModel.NumberOfUsers;
            searchModel.SearchFiltersModel.SearchFiltersFeatures = filtersOneColumn.Where(x => x.SearchFilterType == FILTER_FEATURES);


            return searchModel;

        }
        #endregion

        #region GetSearchResults
        private IEnumerable<SearchResultModel> GetSearchResults(SearchModel searchModel)
        {
            var searchResults = this.SearchProducts(searchModel.SearchFiltersModel, null).ToList();
            int i = 0;
            var searchResultsForModel = searchResults
    .Select(y => new SearchResultModel()
    {
        CloudApplicationID = y.CloudApplicationID,
        Description = y.Description,
        SearchResultID = i++,
        ServiceName = y.ServiceName,
        VendorLogoURL = y.Vendor.VendorLogoURL.AddImagePath(),
        VendorName = y.Vendor.VendorName,
        ApplicationCostOneOff = y.ApplicationCostOneOff,
        ApplicationCostPerAnnum = y.ApplicationCostPerAnnum,
        ApplicationCostPerMonth = y.ApplicationCostPerMonth,
        ApplicationCostPerMonthExtra = y.ApplicationCostPerMonthExtra,
        CallsPackageCostPerMonth = y.CallsPackageCostPerMonth,
        FreeTrialPeriod = y.FreeTrialPeriod.FreeTrialPeriodName,
        SetupFee = y.SetupFee != null ? y.SetupFee.SetupFeeName : null,
        ResultDisplayFormat = SearchResultDisplayFormat.Multiple,
    }
);
            return searchResultsForModel;
        }
        #endregion
    }

    #region FormCollectionExtensions
    public static class FormCollectionExtensions
    {
        public static string GetSubmitButtonName(this FormCollection formCollection)
        {
            return GetSubmitButtonName(formCollection, false);
        }

        public static string GetSubmitButtonName(this FormCollection formCollection, bool throwOnError)
        {
            var imageButton = formCollection.Keys.OfType<string>().Where(x => x.EndsWith(".x")).SingleOrDefault();
            var textButton = formCollection.Keys.OfType<string>().Where(x => x.StartsWith("Submit_")).SingleOrDefault();

            if (textButton != null)
            {
                return textButton.Substring("Submit_".Length);
            }

            // we got something like AddToCart.x
            if (imageButton != null)
            {
                return imageButton.Substring(0, imageButton.Length - 2);
            }

            if (throwOnError)
            {
                throw new ApplicationException("No button found");
            }
            else
            {
                return null;
            }
        }
    }
    #endregion

    static class IEnumerableForEachExtensions
    {
        public static void ForEachMatch<T>(this IEnumerable<T> items,
            Predicate<T> predicate,
            Action<T> action
        )
        {
            items.Where(x => predicate(x)).ForEach(action);
        }

        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
            {
                action(item);
            }
        }
    }

    #region PdfResult
    public class PdfResult : ActionResult
    {
        //private members
        private byte[] pdfBytes;
        public PdfResult(ThumbnailDocument td) 
        {
            //System.IO.FileStream fs = new System.IO.FileStream(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName,System.IO.FileMode.Open);
            //using (System.IO.FileStream fs = System.IO.File.OpenRead(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName))
            {
                //System.IO.MemoryStream ms = new System.IO.MemoryStream((int)fs.Length);
                //int read = fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                pdfBytes = System.IO.File.ReadAllBytes(td.ThumbnailDocumentPhysicalFilePath + td.ThumbnailDocumentFileName);
            }
            
        }
        public override void ExecuteResult(ControllerContext context) 
        {
            //create the pdf in a byte array then drop it into the response
            context.HttpContext.Response.Clear();
            context.HttpContext.Response.ContentType = "application/pdf";
            //context.HttpContext.Response.AddHeader("content-disposition", "attachment;filename=xxx.pdf");
            context.HttpContext.Response.AddHeader("content-disposition", "inline;");
            context.HttpContext.Response.OutputStream.Write(pdfBytes.ToArray(), 0, pdfBytes.ToArray().Length);
            context.HttpContext.Response.End();
        }
    }
    #endregion
}
