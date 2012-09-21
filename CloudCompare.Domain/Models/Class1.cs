using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Models
{
    #region Lookup Classes



 








    #region Country
    public class Country
    {
        public virtual int CountryID { get; set; }
        public virtual string CountryName { get; set; }
    }
    #endregion



 

  






    #region DashboardRole
    public class DashboardRole
    {
        public virtual int DashboardRoleID { get; set; }
        public virtual string DashboardRoleName { get; set; }
    }
    #endregion

    #region PackageType
    public class PackageType
    {
        public virtual int PackageTypeID { get; set; }
        public virtual string PackageTypeName { get; set; }
    }
    #endregion

    #region SupportArea
    public class SupportArea
    {
        public virtual int SupportAreaID { get; set; }
        public virtual string SupportAreaName { get; set; }
    }
    #endregion

    #region QAStatus
    public class QAStatus
    {
        public virtual int QAStatusID { get; set; }
        public virtual string QAStatusName { get; set; }
    }
    #endregion

    #region ApplicationContentStatus
    public class ApplicationContentStatus
    {
        public virtual int ApplicationContentStatusID { get; set; }
        public virtual string ApplicationContentStatusName { get; set; }
    }
    #endregion

    #region ApprovalStatus
    public class ApprovalStatus
    {
        public virtual int ApprovalStatusID { get; set; }
        public virtual string ApprovalStatusName { get; set; }
    }
    #endregion

    #region WhatHappensNext
    public class WhatHappensNext
    {
        public virtual int WhatHappensNextID { get; set; }
        public virtual int ListPosition { get; set; }
        public virtual string WhatHappensNextName { get; set; }
        public virtual int PackageID { get; set; }
    }
    #endregion

    #region PackageStep
    public class PackageStep
    {
        public virtual int PackageStepID { get; set; }
        public virtual int ListPosition { get; set; }
        public virtual string PackageStepName { get; set; }
        public virtual int PackageID { get; set; }
    }
    #endregion

    #endregion
    #region Search
    public class Search
    {
        public virtual int SearchID { get; set; }
        public virtual string Name { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string EMail { get; set; }
        public virtual int OperatingSystemID { get; set; }
        public virtual int LicenceTypeID { get; set; }
    }
    #endregion

    #region CustomiseSearch
    public class CustomiseSearch
    {
        public virtual int CustomiseSearchID { get; set; }
        public List<Category> Categories { get; set; }
        public List<LicenceTypeMinimum> LicenceTypeMinimums { get; set; }
        public List<LicenceTypeMaximum> LicenceTypeMaximums { get; set; }
        public List<OperatingSystem> OperatingSystems { get; set; }
        public List<Browser> Browsers { get; set; }
        public List<Feature> Features { get; set; }
    }
    #endregion







    #region ManyToMany
    #region VendorApplicationCategory
    public class VendorApplicationCategory
    {
        public virtual int VendorApplicationCategoryID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool SendUpdates { get; set; }
        public virtual bool SendNews { get; set; }
    }
    #endregion

    #region VendorApplicationOperatingSystem
    public class VendorApplicationOperatingSystem
    {
        public virtual int VendorApplicationOperatingSystemID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int OperatingSystemID { get; set; }
    }
    #endregion

    #region VendorApplicationBrowser
    public class VendorApplicationBrowser
    {
        public virtual int VendorApplicationBrowserID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int BrowserID { get; set; }
    }
    #endregion

    #region VendorApplicationLanguage
    public class VendorApplicationLanguage
    {
        public virtual int VendorApplicationLanguageID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int LanguageID { get; set; }
    }
    #endregion

    #region VendorApplicationSupportType
    public class VendorApplicationSupportType
    {
        public virtual int VendorApplicationSupportTypeID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int SupportTypeID { get; set; }
    }
    #endregion

    #region VendorApplicationSupportTerritory
    public class VendorApplicationSupportTerritory
    {
        public virtual int VendorApplicationSupportTerritoryID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int SupportTerritoryID { get; set; }
    }
    #endregion

    #region VendorApplicationFeature
    public class VendorApplicationFeature
    {
        public virtual int VendorApplicationFeatureID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int FeatureID { get; set; }
        public virtual bool IsActive { get; set; }
    }
    #endregion

    #region PackageVendor
    public class PackageVendor
    {
        public virtual int PackageVendorID { get; set; }
        public virtual int PackageID { get; set; }
        public virtual int VendorID { get; set; }
    }
    #endregion

    #region PersonSupportArea
    public class PersonSupportArea
    {
        public virtual int PersonSupportAreaID { get; set; }
        public virtual int PersonID { get; set; }
        public virtual int SupportAreaID { get; set; }
    }
    #endregion

    #endregion



    #region PackageFeature
    public class PackageFeature
    {
        public virtual int PackageFeatureID { get; set; }
        public virtual int ParentPackageFeatureID { get; set; }
        public virtual int PackageID { get; set; }
        public virtual bool IsSearchParameter { get; set; }
        public virtual int FeatureID { get; set; }
    }
    #endregion


    #region ApplicationFeature
    public class ApplicationFeature
    {
        public virtual int ApplicationFeatureID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual int FeatureID { get; set; }
        public virtual bool IsSearchParameter { get; set; }
    }
    #endregion





    #region Person
    public class Customer
    {
        public virtual int PersonID { get; set; }
        public virtual string ForeName { get; set; }
        public virtual string Surname { get; set; }
        public virtual string EMail { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Company { get; set; }
        public virtual int NumberOfEmployees { get; set; }
        public virtual string Position { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string PersonAddress1 { get; set; }
        public virtual string PersonAddress2 { get; set; }
        public virtual string PersonRegion { get; set; }
        public virtual string PersonCountry { get; set; }
        public virtual string PersonPostCode { get; set; }
        public virtual int AccountsPersonID { get; set; }
        public virtual DateTime LastLoggedIn { get; set; }
        public virtual bool IsAdministrator { get; set; }
        public virtual bool IsEditor { get; set; }
        public virtual bool IsFinanceContact { get; set; }
    }
    #endregion

    #region PlaceHolder
    public class Placeholder
    {
        public virtual int PlaceholderID { get; set; }
        public virtual int CategoryID { get; set; }
    }
    #endregion

    #region PlaceholderTextBased
    public class PlaceholderTextBased : Placeholder
    {
        public virtual string PlaceholderHeader { get; set; }
        public virtual string PlaceholderTitle { get; set; }
        public virtual string PlaceholderText { get; set; }
        public virtual string PlaceholderLogoURL { get; set; }
        public virtual string PlaceholderAverageRatingURL { get; set; }
        public virtual string PlaceholderGraphicText { get; set; }
        public virtual int PlaceholderReviewCount { get; set; }
    }
    #endregion

    #region PlaceholderGraphicBased
    public class PlaceholderGraphicBased : Placeholder
    {
        public virtual string PlaceholderGraphicURL { get; set; }
    }
    #endregion

    #region Package
    public class Package
    {
        public virtual int PackageID { get; set; }
        public virtual int PackageTypeID { get; set; }
        public virtual string PackageName { get; set; }
        public virtual List<PackageBulletPoint> PackageBulletPoints { get; set; }
        public virtual decimal PackageCostPerQuarter { get; set; }
        public virtual decimal PackageCostPerAnnum { get; set; }
        public virtual DateTime PackageActiveFrom { get; set; }
        public virtual DateTime PackageActiveTo { get; set; }
    }
    #endregion

    #region PackageBulletPoint
    public class PackageBulletPoint
    {
        public virtual int PackageBulletPointID { get; set; }
        public virtual int PackageID { get; set; }
        public virtual string PackageBulletPointDescription { get; set; }
        public virtual int ListPosition { get; set; }
    }
    #endregion




    #region VendorDashboard
    public class VendorDashboard
    {
        public virtual int VendorDashboardID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int DashboardRoleID { get; set; }
        public virtual bool IsActive { get; set; }
    }
    #endregion

    #region VendorDashboardRole
    public class VendorDashboardRole
    {
        public virtual int VendorDashboardRoleID { get; set; }
        public virtual int DashboardRoleID { get; set; }
        public virtual bool IsActive { get; set; }
    }
    #endregion

    #region VendorDashboardRolePerson
    public class VendorDashboardRolePerson
    {
        public virtual int VendorDashboardRolePersonID { get; set; }
        public virtual int VendorDashboardRoleID { get; set; }
        public virtual int PersonID { get; set; }
    }
    #endregion

    #region Profile
    public class Profile
    {
        public virtual int ProfileID { get; set; }
        public virtual int PackageVendorID { get; set; }
        public virtual int VendorDashboardID { get; set; }
    }
    #endregion

    #region Invoice
    public class Invoice
    {
        public virtual int InvoiceID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
        public virtual byte InvoiceBytes { get; set; }
        public virtual DateTime InvoiceDate { get; set; }
        public virtual int InvoiceNumber { get; set; }
        public virtual int InvoiceNetAmount { get; set; }
        public virtual int InvoiceVATAmount { get; set; }
        public virtual int InvoiceGrossAmount { get; set; }
        public virtual int VATID { get; set; }
        public virtual string InvoiceDescription { get; set; }
    }
    #endregion

    #region VAT
    public class VAT
    {
        public virtual int VATID { get; set; }
        public virtual DateTime FromDate { get; set; }
        public virtual DateTime ToDate { get; set; }
        public virtual decimal VATPercentage { get; set; }
    }
    #endregion


    #region SupportAreaVendorApplication
    public class SupportAreaVendorApplication
    {
        public virtual int SupportAreaVendorApplicationID { get; set; }
        public virtual int SupportAreaID { get; set; }
        public virtual int VendorID { get; set; }
        public virtual int ApplicationID { get; set; }
    }
    #endregion

    #region SupportAreaQA
    public class SupportAreaQA
    {
        public virtual int SupportAreaQAID { get; set; }
        public virtual int SupportAreaVendorApplicationID { get; set; }
        public virtual int SubmittedPersonID { get; set; }
        public virtual string Question { get; set; }
        public virtual DateTime QuestionDate { get; set; }
        public virtual string Answer { get; set; }
        public virtual DateTime AnswerDate { get; set; }
        public virtual int AssignedPersonID { get; set; }
        public virtual int QAStatusID { get; set; }
    }
    #endregion


    #region MessagePanel
    public class MessagePanel
    {
        public virtual int MessagePanelID { get; set; }
        public virtual string QAStatusText { get; set; }
    }
    #endregion

}
