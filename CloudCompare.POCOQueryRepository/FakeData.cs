﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudCompare.Domain.Contracts.Repositories;
using CloudCompare.POCOQueryRepository;
using CloudCompare.Domain.Models;

//using Moq;
//using NUnit.Framework;

namespace CloudCompare.POCOQueryRepository
{
    public class FakeData
    {
        private ICloudCompareContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public ICloudCompareContext FakeContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        //[TestMethod]
        public void LoadFakeReferenceData(ICloudCompareContext context)
        {
            //set the context to a fake stub
            //this.FakeContext = new FakeCloudCompareContext();
            this.FakeContext = context;

            //_context = new StationEntities();

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);

            //add our sample fake station entities to the repository
            Feature f;
            FeatureType ft;
            CloudCompare.Domain.Models.OperatingSystem o;
            MobilePlatform mp;
            Browser b;
            LicenceTypeMinimum ltMin;
            LicenceTypeMaximum ltMax;
            Language l;
            SupportType st;
            SupportDays sd;
            SupportHours sh;
            SupportTerritory sterritory;
            Category c;
            MinimumContract mc;
            PaymentFrequency pf;
            SetupFee sf;
            PaymentOption po;
            FreeTrialPeriod ftp;
            Vendor v;

            #region CATEGORIES
            c = new Category()
            {
                CategoryName = "Voice"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Customer Management"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Web Conference"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Email"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Office"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Storage & Backup"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Project Management"
            };
            repository.AddCategory(c);
            c = new Category()
            {
                CategoryName = "Financial"
            };
            repository.AddCategory(c);
            #endregion

            #region FEATURETYPES
            ft = new FeatureType()
            {
                FeatureTypeName = "Category",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "LicenceTypeMinimum",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "LicenceTypeMaximum",
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "OperatingSystem",
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "Browser",
            };
            repository.AddFeatureType(ft);
            ft = new FeatureType()
            {
                FeatureTypeName = "Feature",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportType",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportDays",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "SupportHours",
            };
            repository.AddFeatureType(ft);

            ft = new FeatureType()
            {
                FeatureTypeName = "Language",
            };
            repository.AddFeatureType(ft);
            #endregion

            this.FakeContext.SaveChanges();

            #region FEATURES

            #region VOICE FEATURES
            f = new Feature()
            {
                FeatureName = "Use Existing Handset",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Keep Existing Number",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Emergency Calls",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "PC Required (for Calls)",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive UK Landline Calls",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive Mobile Calls",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inclusive International Calls (Landline Only)",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Virtual Landline Number",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Local Dialling Code",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Freephone/Local Rate Number",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Dial-by-name Directory",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Video Calling",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Auto-Reception/Call Handling",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Answering Rules",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Call Centre/Interactive Voice Response",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Music-on-hold",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Voicemail",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SMS Sending",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Call Forwarding",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fixed-to-mobile Integration",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Hardware Supplied",
                Category = repository.FindCategoryByName("VOICE"),
            };
            repository.AddFeature(f);
            #endregion

            #region CUSTOMER MANAGEMENT FEATURES
            f = new Feature()
            {
                FeatureName = "Unlimited Contacts",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Storage (for Documents, PPTs, PDFs)",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Sales Opportunity Management",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Sales Forecasting",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web to Lead Form",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Marketing",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Campaign Tracking and Management",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Integration",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customer Helpdesk",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Case Queueing & Tracking",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Cases",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Management",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Custom Reports",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Full SSL Security",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile Integration",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invoice Creation & Management",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inventory & Order Management",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Open API/3rd Party Integration",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "User Customization",
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
            };
            repository.AddFeature(f);
            #endregion

            #region WEB CONFERENCE FEATURES
            f = new Feature()
            {
                FeatureName = "Maximum Meeting Attendees",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Maximum Webinar/Event Attendees",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "High Definition Video",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Presenter Preparation Mode",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multiple Meeting Hosts/Chairperson",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual Usage Reports",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "'On The Fly' Invitations For Additional Participants",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant Meeting Function",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Active Speaker Video Switching",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Full Desktop Sharing",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Single Application Share",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Upload Multiple Presentations",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Private Chat Mode",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Record & Replay Service",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interface Company Branding",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Inactivity Time Out",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fixed Line & Mobile Dial-In",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Free VoIP Calling",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Outlook Integration (to book meetings)",
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
            };
            repository.AddFeature(f);
            #endregion

            #region EMAIL FEATURES
            f = new Feature()
            {
                FeatureName = "Number of Mailboxes/Email Addresses",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Storage Limit",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual File Size Limit (Attachments)",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "No Daily Mail Limits (Inbox/Outbox)",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Migrate Company Domain",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Anti-Virus",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Spam Guard / Anti Phishing",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Block Addresses / Blacklist",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Aliases",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Ad-free",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Archiving",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Quick Filter Toolbar",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Smart Folders",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Account Groups",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Instant Messaging (IM)",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Track Conversations",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Outlook Compatible",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Migration Service",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Category = repository.FindCategoryByName("EMAIL"),
            };
            repository.AddFeature(f);
            #endregion

            #region OFFICE FEATURES
            f = new Feature()
            {
                FeatureName = "Advanced Proofing & Editing",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Advanced Referencing & Indexing",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mailing Features",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Formula Management",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Data Management",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Advanced Charting & Tables",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Advanced Design & Animation",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Real-Time Collaboration",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Version Management",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Large Video Files >50MB",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Own Branding",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Shared/Collaboration Workspace",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Email Client",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Contact Management",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Shared Calendar",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Meetings",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Management / Task Manager",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Internet Tools",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Web Publishing e.g. Blog",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Integration",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Internal Website (Intranet)",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "External Customer Website (Extranet)",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Notes",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Read & Edit",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Save Web Content",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Image Capture",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Sync (for use on other devices)",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Office Compatible",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Offline Mode (for desktop editing)",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Document Storage",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Revision History",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Password Protection",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Mobile/Browser Editing",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-User/Guest User",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party APIs",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security/Encryption",
                Category = repository.FindCategoryByName("OFFICE"),
            };
            repository.AddFeature(f);
            #endregion

            #region STORAGE & BACKUP
            f = new Feature()
            {
                FeatureName = "Storage Limit",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Individual File Limit",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Adjust Transfer Speed / Bandwidth Used",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Data Transfer",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Storage",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Version History",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Undelete Files (up to 30 days)",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "No Bandwidth Throttling",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "One-Click Sharing",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Drag & Drop Multiple Files",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-User Access",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Password Protected Folder Sharing",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Role Based Access",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Search Within Documents",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Local Back-Up",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Server Back-Up",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Automatic Back-Up",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Store Video e.g. Movies",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Guaranteed Restore",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Social Media Back-Up",
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
            };
            repository.AddFeature(f);
            #endregion

            #region PROJECT MANAGEMENT
            f = new Feature()
            {
                FeatureName = "Number Of Projects",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "File Storage",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-Users Per Account",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Document Sharing",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Shared Workspace",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Edited Document Tracking",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Lockfiles",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Update & Deadline Alerts",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Interactive GANTT Charts",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Budget Tracking",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Client Invoicing",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Wiki",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customized Reports",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Project Compatible",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Military Grade Document Security",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Guaranteed Restore",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Offline Mode",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party APIs",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Bug Tracker",
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
            };
            repository.AddFeature(f);
            #endregion

            #region FINANCIAL
            f = new Feature()
            {
                FeatureName = "Unlimited Transactions",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Customer Records",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Supplier Records",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Unlimited Product & Service Descriptions",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Create Invoices",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Invoice-to-Payment Matching",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-Currency Invoicing",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Record Bank Payments",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customized Reports",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "SSL Security",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Project Accounting",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "External Access (for Accountants)",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Multi-User Access",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "MS Excel Compatible",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Fixed Asset Depreciation Tool",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Customer Statements",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Purchase Order System",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "Payroll",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "VAT Filing",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            f = new Feature()
            {
                FeatureName = "3rd Party API",
                Category = repository.FindCategoryByName("FINANCIAL"),
            };
            repository.AddFeature(f);
            #endregion

            #endregion

            #region OPERATING SYSTEMS
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Win"
            };
            repository.AddOperatingSystem(o); 
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Mac"
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "Linux"
            };
            repository.AddOperatingSystem(o);
            o = new Domain.Models.OperatingSystem()
            {
                OperatingSystemName = "iPad"
            };
            repository.AddOperatingSystem(o);
            #endregion

            #region MOBILE PLATFORMS
            mp = new MobilePlatform()
            {
                MobilePlatformName = "All"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Android"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "iPhone"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Win"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "BB"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "No"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "iPad"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Apple"
            };
            repository.AddMobilePlatform(mp);
            mp = new MobilePlatform()
            {
                MobilePlatformName = "Blackberry"
            };
            repository.AddMobilePlatform(mp);
            #endregion

            #region BROWSERS
            b = new Browser()
            {
                BrowserName = "Internet Explorer 6"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Internet Explorer 7"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Internet Explorer 8"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Internet Explorer 9"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Firefox"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Safari"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Opera"
            };
            repository.AddBrowser(b);
            b = new Browser()
            {
                BrowserName = "Chrome"
            };
            repository.AddBrowser(b);
            #endregion

            #region LICENCE TYPE MINIMUM
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = "1"
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = "2"
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = "5"
            };
            repository.AddLicenceTypeMinimum(ltMin);
            ltMin = new LicenceTypeMinimum()
            {
                LicenceTypeMinimumName = "3"
            };
            repository.AddLicenceTypeMinimum(ltMin);
            #endregion

            #region LICENCE TYPE MAXIMUM
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "1"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "2"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "3"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "5"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "6"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "8"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "9"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "10"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "20"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "50"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "99"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "250"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "500"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            ltMax = new LicenceTypeMaximum()
            {
                LicenceTypeMaximumName = "16384"
            };
            repository.AddLicenceTypeMaximum(ltMax);
            #endregion

            #region LANGUAGES
            l = new Language()
            {
                LanguageName = "English"
            };
            repository.AddLanguage(l);
            #endregion

            #region SUPPORT TYPES
            st = new SupportType()
            {
                SupportTypeName = "Online"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Telephone"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Email"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "FAQ"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Troubleshoot"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Knowledge Base"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Community"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Free Telephone"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Local Rate Phone"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Troubleticket"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Toll Free Phone"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "Chat"
            };
            repository.AddSupportType(st);
            st = new SupportType()
            {
                SupportTypeName = "CallBack"
            };
            repository.AddSupportType(st);
            #endregion

            #region SUPPORT DAYS
            sd = new SupportDays()
            {
                SupportDaysName = "7"
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "5"
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "N/A"
            };
            repository.AddSupportDays(sd);
            sd = new SupportDays()
            {
                SupportDaysName = "Mon-Fri"
            };
            repository.AddSupportDays(sd);
            #endregion

            #region SUPPORT HOURS
            sh = new SupportHours()
            {
                SupportHoursName = "24 hours"
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "9am-6pm"
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "N/A"
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "12 hours (business)"
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "12 hours"
            };
            repository.AddSupportHours(sh);
            sh = new SupportHours()
            {
                SupportHoursName = "9am-5pm"
            };
            repository.AddSupportHours(sh);
            #endregion

            #region SUPPORT TERRITORIES
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "UK"
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "Global"
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "US"
            };
            repository.AddSupportTerritory(sterritory);
            sterritory = new SupportTerritory()
            {
                SupportTerritoryName = "Australia"
            };
            repository.AddSupportTerritory(sterritory);
            #endregion

            #region MINIMUM CONTRACTS
            mc = new MinimumContract()
            {
                MinimumContractName = "No Contract"
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "12 Months"
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "24 Months"
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "1 Month"
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "36 Months"
            };
            repository.AddMinimumContract(mc);
            mc = new MinimumContract()
            {
                MinimumContractName = "Not Applicable"
            };
            repository.AddMinimumContract(mc);
            #endregion

            #region PAYMENT FREQUENCIES
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "Monthly"
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "Not Applicable"
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "On-demand"
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "Annual"
            };
            repository.AddPaymentFrequency(pf);
            pf = new PaymentFrequency()
            {
                PaymentFrequencyName = "One-Off"
            };
            repository.AddPaymentFrequency(pf);
            #endregion

            #region SETUP FEES
            sf = new SetupFee()
            {
                SetupFeeName = "Not Applicable"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£27.97"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£14.99"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£4.99"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£130.00"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£29.00"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£20.00"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£24.99"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "$25.00"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "$49.99"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£9.21"
            };
            repository.AddSetupFee(sf);
            sf = new SetupFee()
            {
                SetupFeeName = "£19.99"
            };
            repository.AddSetupFee(sf);
            #endregion

            #region PAYMENT OPTIONS
            po = new PaymentOption()
            {
                PaymentOptionName = "Credit Card"
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Pre-Pay"
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Direct Debit"
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Debit Card"
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "PayPal"
            };
            repository.AddPaymentOption(po);
            po = new PaymentOption()
            {
                PaymentOptionName = "Invoice"
            };
            repository.AddPaymentOption(po);
            #endregion

            #region FREE TRIAL PERIODS
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "No"
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "Yes"
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "Demo"
            };
            repository.AddFreeTrialPeriod(ftp);
            ftp = new FreeTrialPeriod()
            {
                FreeTrialPeriodName = "Test Drive"
            };
            repository.AddFreeTrialPeriod(ftp);
            #endregion

            #region VENDORS
            v = new Vendor()
            {
                VendorName = "Skype",
                VendorLogoURL = "skype.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Vonage",
                VendorLogoURL = "vonage.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Vodafone",
                VendorLogoURL = "vodafone.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "VoIPtalk",
                VendorLogoURL = "voiptalk.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Gradwell",
                VendorLogoURL = "gradwell.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "RingCentral",
                VendorLogoURL = "ringcentral.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "BT",
                VendorLogoURL = "bt.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Tpad",
                VendorLogoURL = "tpaddotcom.bmp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "yourCHOICE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "freespeech.co.uk",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "magicJack",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Press1.co.uk",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "usomo",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "colt",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sureVoIP",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "NTA:LTD",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sipgate",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Salesforce",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SUGARCRM",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHOCRM",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Workbooks.com",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Dynamics",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Maximizer",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "opencrm",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "TactileCRM",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "wecandobiz",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Buddy",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sage",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "webCRM",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "capsule",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SohoOS",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Cisco webex",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "GoToMeeting",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Lync Online",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "LotusLive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Infinite",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Meeting",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FUZE Meeting",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Yugma",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "POWWOWNOW",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "MegaMeeting",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "meetingzone",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "InterCall",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "OnSync",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "YAHOO Small Business",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Exchange Online",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Mail",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SMS",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "BlueTie",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "GMail",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Star",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FastMail",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "webfusion",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "rackspace",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "eclipse",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FuseMail",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "fasthosts",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "INTERMEDIA",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "1&1",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Microsoft Office 365",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Google Apps for Business",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO docs",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Think Free",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "feng OFFICE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Z CUBES",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "myoffice",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Quickoffice",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Live Documents",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "EVERNOTE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "sliderocket",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PREZI",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CARBONITE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "box",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "OpenDrive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ADrive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "storegate",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SugarSync",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FLIPDRIVE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mozy",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Dropbox",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CRASHPLAN",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "elephantdrive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iDrive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "livedrive",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iBackup",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "backupify",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Projects",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "@task",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "mavenlink",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "clarizen",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ProWorkflow",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "HyperOffice",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "WORKetc",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "LiquidPlanner",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CELOXIS",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "blue camroo",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "PROJECTMANAGER.com",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "CollaborateCloud",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "copper",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "projectplace",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Basecamp",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "trafficLIVE",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iManageProject",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "intervals",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Geniusproject",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "glasscubes",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "xero",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "SageOne",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "e-conomic",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ARITHMO",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "liquid",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "kashoo",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FRSHBOOKS",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ClearBooks",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ledgerble",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "KashFlow",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "FreeAgent",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "outright",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "ZOHO Books",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "iCashbook",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "Yendo",
            };
            repository.AddVendor(v);
            v = new Vendor()
            {
                VendorName = "intuit",
            };
            repository.AddVendor(v);
            #endregion

            //// Mock the Products Repository using Moq
            //Mock<ICloudCompareContext> mockCloudCompareRepository = new Mock<ICloudCompareContext>();

            //// Try finding a product by id
            //CloudApplication testCloudApplication = mockCloudCompareRepository.Object.FindById(2);

            //Assert.IsNotNull(testCloudApplication); // Test if null
            //Assert.IsInstanceOfType(typeof(CloudApplication),testCloudApplication); // Test type
            //Assert.AreEqual("TITLE", testCloudApplication.Title); // Verify it is the right product
        }

        public void LoadFakeProductionData(ICloudCompareContext context)
        {
            #region VENDORS SCRATCHPAD
            #endregion

            //now use this fake stub as the repository
            var repository = new QueryRepository(this.FakeContext);
            CloudApplication ca;

            #region APPLICATIONS

            #region VOICE

            #region SKYPE
            ca = new CloudApplication()
            {
                Brand = "Skype",
                ServiceName = "Unlimited World",
                CompanyURL = "www.skype.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                },
                ApplicationCostPerMonth = 7.99M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NO CONTRACT"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("SKYPE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region VONAGE
            ca = new CloudApplication()
            {
                Brand = "Vonage",
                ServiceName = "V-Plan 2",
                CompanyURL = "www.vonage.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("8"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 8.99M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("£27.97"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("Vonage"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region VODAFONE
            ca = new CloudApplication()
            {
                Brand = "Vodafone",
                ServiceName = "One Net Express",
                CompanyURL = "www.vodafone.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("WIN"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 55.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("24 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("Vodafone"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region VOIPTALK
            ca = new CloudApplication()
            {
                Brand = "VoIPtalk",
                ServiceName = "VoIPtalk Unlimited",
                CompanyURL = "www.voiptalk.org",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //repository.FindMobilePlatformByName("WIN"),
                //repository.FindMobilePlatformByName("BB"),
                //repository.FindMobilePlatformByName("ANDROID"),
                //repository.FindMobilePlatformByName("IPHONE")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("6"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.88M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("£14.99"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("VoIPtalk"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region GRADWELL
            ca = new CloudApplication()
            {
                Brand = "Gradwell",
                ServiceName = "Multi-User VoIP",
                CompanyURL = "www.gradwell.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("10"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 8.00M,
                CallsPackageCostPerMonth = 25.00M,
                SetupFee = repository.FindSetupFeeByName("£4.99"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("Gradwell"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region RINGCENTRAL
            ca = new CloudApplication()
            {
                Brand = "RingCentral",
                ServiceName = "RC Call Management",
                CompanyURL = "www.ringcentral.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("10"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 7.99M,
                CallsPackageCostPerMonth = 14.99M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("1 MONTH"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("RingCentral"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region BT
            ca = new CloudApplication()
            {
                Brand = "BT",
                ServiceName = "Hosted VoIP Plus",
                CompanyURL = "www.bt.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("8"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 6.50M,
                CallsPackageCostPerMonth = 21.00M,
                SetupFee = repository.FindSetupFeeByName("£130"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("BT"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region TPAD
            ca = new CloudApplication()
            {
                Brand = "Tpad",
                ServiceName = "4 User",
                CompanyURL = "www.tpad.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    //repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("20"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    //repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.95M,
                CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("£29"),
                MinimumContract = repository.FindMinimumContractByName("36 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("Tpad"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region YOURCHOICE
            ca = new CloudApplication()
            {
                Brand = "yourCHOICE",
                ServiceName = "UK Mobile & Landlines",
                CompanyURL = "www.yourchoicevoip.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    //repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 9.99M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£130"),
                MinimumContract = repository.FindMinimumContractByName("NONE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    //repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("yourCHOICE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region FREESPEECH.CO.UK
            ca = new CloudApplication()
            {
                Brand = "freespeech.co.uk",
                ServiceName = "Small Unlimited",
                CompanyURL = "www.freespeech.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    //repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 15.99M,
                CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("NONE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("freespeech.co.uk"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region MAGICJACK
            ca = new CloudApplication()
            {
                Brand = "magicJack",
                ServiceName = "MagicTalk",
                CompanyURL = "www.magicjack.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    //repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    //repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    //repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    //repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    //repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 0M,
                CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NOT APPLICABLE"),
                //PaymentOptions = new List<PaymentOption>()
                //{
                //    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                //    //repository.FindPaymentOptionByName("CREDIT CARD"),
                //    //repository.FindPaymentOptionByName("PAYPAL"),
                //},
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("magicJack"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region PRESS1.CO.UK
            ca = new CloudApplication()
            {
                Brand = "Press1.co.uk",
                ServiceName = "0870 Switchboard",
                CompanyURL = "www.press1.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    //repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    //repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.99M,
                CallsPackageCostPerMonth = 0.00M,
                SetupFee = repository.FindSetupFeeByName("£24.99"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("Press1.co.uk"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region USOMO
            ca = new CloudApplication()
            {
                Brand = "usomo",
                ServiceName = "Business VoIP",
                CompanyURL = "www.usomo.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("20"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                //SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                //SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    //repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 1.49M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("usomo"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region COLT
            ca = new CloudApplication()
            {
                Brand = "colt",
                ServiceName = "Business VoIP",
                CompanyURL = "www.colt.net",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    //repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    //repository.FindFeatureByName("VIDEO CALLING"),
                    //repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    //repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    //repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 5.99M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("colt"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region SUREVOIP
            ca = new CloudApplication()
            {
                Brand = "sureVoIP",
                ServiceName = "SureVoIP Hosted",
                CompanyURL = "www.sureVoIP.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 10.00M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("sureVoIP"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region NTA:LTD
            ca = new CloudApplication()
            {
                Brand = "NTA:LTD",
                ServiceName = "Business VoIP",
                CompanyURL = "www.ntaltd.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 7.99M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("NTA:LTD"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region SIPGATE
            ca = new CloudApplication()
            {
                Brand = "sipgate",
                ServiceName = "Sipgate Team 3",
                CompanyURL = "www.live.sipgate.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("3"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    //repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("FAQ"),
                    //repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("USE EXISTING HANDSET"),
                    repository.FindFeatureByName("KEEP EXISTING NUMBER"),
                    repository.FindFeatureByName("EMERGENCY CALLS"),
                    //repository.FindFeatureByName("PC REQUIRED"),
                    repository.FindFeatureByName("INCLUSIVE UK LANDLINE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE MOBILE CALLS"),
                    //repository.FindFeatureByName("INCLUSIVE INTERNATIONAL CALLS"),
                    repository.FindFeatureByName("VIRTUAL LANDLINE NUMBER"),
                    repository.FindFeatureByName("LOCAL DIALLING CODE"),
                    repository.FindFeatureByName("FREEPHONE/LOCAL RATE NUMBER"),
                    //repository.FindFeatureByName("DIAL-BY-NAME DIRECTORY"),
                    repository.FindFeatureByName("VIDEO CALLING"),
                    repository.FindFeatureByName("AUTO RECEPTION/CALL HANDLING"),
                    repository.FindFeatureByName("ANSWERING RULES"),
                    //repository.FindFeatureByName("CALL CENTRE/INTERACTIVE VOICE RESPONSE"),
                    repository.FindFeatureByName("MUSIC-ON-HOLD"),
                    repository.FindFeatureByName("VOICEMAIL"),
                    repository.FindFeatureByName("SMS SENDING"),
                    repository.FindFeatureByName("CALL FORWARDING"),
                    //repository.FindFeatureByName("FIXED-TO-MOBILE INTEGRATION"),
                    repository.FindFeatureByName("HARDWARE SUPPLIED"),
                },
                ApplicationCostPerMonth = 14.95M,
                CallsPackageCostPerMonth = 0.00M,
                //SetupFee = repository.FindSetupFeeByName("£20"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                    //repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("VOICE"),
                Vendor = repository.FindVendorByName("sipgate"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #endregion

            #region CUSTOMER MANAGEMENT

            #region SALESFORCE
            ca = new CloudApplication()
            {
                Brand = "Salesforce",
                ServiceName = "Group Edition",
                CompanyURL = "www.salesforce.com/uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("5"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    //repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 17.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("Salesforce"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region SUGARCRM
            ca = new CloudApplication()
            {
                Brand = "SUGARCRM",
                ServiceName = "Professional",
                CompanyURL = "www.sugaruk.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 18.75M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DIRECT DEBIT"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("SUGARCRM"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region ZOHOCRM
            ca = new CloudApplication()
            {
                Brand = "ZOHOCRM",
                ServiceName = "Professional",
                CompanyURL = "www.zoho.com/crm",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("WIN"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 8.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("ZOHOCRM"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region WORKBOOKS.COM
            ca = new CloudApplication()
            {
                Brand = "Workbooks.com",
                ServiceName = "CRM",
                CompanyURL = "www.workbooks.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("IPAD"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 30.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PAYPAL"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("Workbooks.com"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region MICROSOFT DYNAMICS
            ca = new CloudApplication()
            {
                Brand = "Microsoft Dynamics",
                ServiceName = "CRM Online",
                CompanyURL = "http://crm.dynamics.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = repository.GetAllMobilePlatforms(),
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    //repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 22.75M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("INVOICE"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("Microsoft Dynamics"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region MAXIMIZER
            ca = new CloudApplication()
            {
                Brand = "Maximizer",
                ServiceName = "Entrepeneur Edition",
                CompanyURL = "http://www.max.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    //repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("5"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("KNOWLEDGE BASE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                //SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                //SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("GLOBAL"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    //repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    //repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerAnnum = 130.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NOT APPLICABLE"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("Maximizer"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region OPENCRM
            ca = new CloudApplication()
            {
                Brand = "opencrm",
                ServiceName = "Entry",
                CompanyURL = "www.opencrm.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("3"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS (BUSINESS)"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 25.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("DEMO"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("opencrm"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region TACTILECRM
            ca = new CloudApplication()
            {
                Brand = "TactileCRM",
                ServiceName = "Premium",
                CompanyURL = "www.tactilecrm.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    //repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("SAFARI"),
                    repository.FindBrowserByName("OPERA")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("20"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 6.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("TactileCRM"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region WECANDOBIZ
            ca = new CloudApplication()
            {
                Brand = "wecandobiz",
                ServiceName = "Entry",
                CompanyURL = "wecando.biz",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    //repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    //repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    //repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION"),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NONE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("wecandobiz"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region BUDDY
            ca = new CloudApplication()
            {
                Brand = "Buddy",
                ServiceName = "BuddyCRM",
                CompanyURL = "www.buddycrm.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI")
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 25.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("Buddy"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region SAGE
            ca = new CloudApplication()
            {
                Brand = "sage",
                ServiceName = "SageCRM",
                CompanyURL = "www.uksagecrm.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("APPLE"),
                    //repository.FindMobilePlatformByName("IPHONE"),
                    //repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 35.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("INVOICE"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("sage"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region WEBCRM
            ca = new CloudApplication()
            {
                Brand = "webCRM",
                ServiceName = "",
                CompanyURL = "www.webcrm.com/uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("APPLE"),
                    //repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("2"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("10"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("12 HOURS"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    //repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    //repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 15.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("webCRM"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region CAPSULE
            ca = new CloudApplication()
            {
                Brand = "capsule",
                ServiceName = "Professional Edition",
                CompanyURL = "www.capsulecrm.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    repository.FindFeatureByName("UNLIMITED STORAGE"),
                    repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    repository.FindFeatureByName("SALES FORECASTING"),
                    //repository.FindFeatureByName("WEB TO LEAD FORM"),
                    //repository.FindFeatureByName("EMAIL MARKETING"),
                    //repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    //repository.FindFeatureByName("MOBILE INTEGRATION"),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    //repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 8.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NO CONTRACT"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("capsule"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #region SOHOOS
            ca = new CloudApplication()
            {
                Brand = "SohoOS",
                ServiceName = "Start",
                CompanyURL = "www.sohoos.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("APPLE"),
                    //repository.FindMobilePlatformByName("IPHONE"),
                    //repository.FindMobilePlatformByName("BB"),
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("FAQ")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED CONTACTS"),
                    //repository.FindFeatureByName("UNLIMITED STORAGE"),
                    //repository.FindFeatureByName("SALES OPPORTUNITY MANAGEMENT"),
                    //repository.FindFeatureByName("SALES FORECASTING"),
                    repository.FindFeatureByName("WEB TO LEAD FORM"),
                    repository.FindFeatureByName("EMAIL MARKETING"),
                    repository.FindFeatureByName("CAMPAIGN TRACKING AND MANAGEMENT"),
                    repository.FindFeatureByName("EMAIL INTEGRATION"),
                    //repository.FindFeatureByName("CUSTOMER HELPDESK"),
                    //repository.FindFeatureByName("CASE QUEUEING & TRACKING"),
                    //repository.FindFeatureByName("UNLIMITED CASES"),
                    repository.FindFeatureByName("DOCUMENT MANAGEMENT"),
                    repository.FindFeatureByName("CUSTOM REPORTS"),
                    repository.FindFeatureByName("FULL SSL SECURITY"),
                    repository.FindFeatureByName("MOBILE INTEGRATION"),
                    repository.FindFeatureByName("INVOICE CREATION & MANAGEMENT"),
                    repository.FindFeatureByName("INVENTORY & ORDER MANAGEMENT"),
                    repository.FindFeatureByName("OPEN API/3RD PARTY INTEGRATION"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("USER CUSTOMIZATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NO CONTRACT"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("CUSTOMER MANAGEMENT"),
                Vendor = repository.FindVendorByName("SohoOS"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);
            #endregion

            #endregion

            #region WEB CONFERENCE

            #region CISCO WEBEX
            ca = new CloudApplication()
            {
                Brand = "Cisco webex",
                ServiceName = "Meeting Centre",
                CompanyURL = "www.webex.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 25,
                MaximumWebinarAttendees = 3000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 30.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("Cisco webex"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region GOTOMEETING
            ca = new CloudApplication()
            {
                Brand = "GoToMeeting",
                ServiceName = "Go-To-Meeting Flat Plan",
                CompanyURL = "www.gotomeeting.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 25,
                MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 29.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("GoToMeeting"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT LYNC ONLINE
            ca = new CloudApplication()
            {
                Brand = "Microsoft Lync Online",
                ServiceName = "Plan P",
                CompanyURL = "www.lync.microsoft.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 250,
                MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    //repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 4.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("Microsoft Lync Online"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LOTUSLIVE
            ca = new CloudApplication()
            {
                Brand = "LotusLive",
                ServiceName = "Meetings Unlimited",
                CompanyURL = "www.lotuslive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 15,
                MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 39.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("LotusLive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region INFINITE
            ca = new CloudApplication()
            {
                Brand = "Infinite",
                ServiceName = "Web Conferencing",
                CompanyURL = "www.infinite conferencing.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 1000,
                MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    //repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 35.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("Infinite"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MEETING
            ca = new CloudApplication()
            {
                Brand = "ZOHO Meeting",
                ServiceName = "Professional Meeting",
                CompanyURL = "www.zohomeeting.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("5"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 5,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    //repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 12.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("ZOHO Meeting"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FUZE MEETING
            ca = new CloudApplication()
            {
                Brand = "FUZE Meeting",
                ServiceName = "Personal",
                CompanyURL = "www.fuzemeeting.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("IPAD"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                MaximumMeetingAttendees = 25,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    //repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 29.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("FUZE Meeting"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region YUGMA P50
            ca = new CloudApplication()
            {
                Brand = "Yugma",
                ServiceName = "Yugma P50",
                CompanyURL = "www.yugma.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                MaximumMeetingAttendees = 50,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 34.95M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("Yugma"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region POWWOWNOW
            ca = new CloudApplication()
            {
                Brand = "POWWOWNOW",
                ServiceName = "PowWowNow Plus",
                CompanyURL = "www.powwownow.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("EMAIL"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 50,
                MaximumWebinarAttendees = 1000,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    //repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    //repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("POWWOWNOW"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MEGAMEETING
            ca = new CloudApplication()
            {
                Brand = "MegaMeeting",
                ServiceName = "Professional",
                CompanyURL = "www.megameeting.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("2"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("2"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 16384,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    //repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 39.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NO CONTRACT"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("MegaMeeting"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MEETINGZONE
            ca = new CloudApplication()
            {
                Brand = "meetingzone",
                ServiceName = "Web Conference",
                CompanyURL = "www.meetingzone.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("TELEPHONE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                MaximumMeetingAttendees = 16384,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    //repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    //repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    //repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    //repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    //repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 0.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NO CONTRACT"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ON-DEMAND"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("meetingzone"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region INTERCALL
            ca = new CloudApplication()
            {
                Brand = "InterCall",
                ServiceName = "Unified Meeting",
                CompanyURL = "www.intercall.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 16384,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 42.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("InterCall"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ONSYNC
            ca = new CloudApplication()
            {
                Brand = "OnSync",
                ServiceName = "On-Sync Standard 50",
                CompanyURL = "www.digitalsamba.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("50"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                MaximumMeetingAttendees = 50,
                MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("HIGH DEFINITION VIDEO"),
                    repository.FindFeatureByName("PRESENTER PREPARATION MODE"),
                    repository.FindFeatureByName("MULTIPLE MEETING HOSTS/CHAIRMAN"),
                    repository.FindFeatureByName("INDIVIDUAL USAGE REPORTS"),
                    repository.FindFeatureByName("'ON THE FLY' INVITATIONS FOR ADDITIONAL PARTICIPANTS"),
                    repository.FindFeatureByName("INSTANT MEETING FUNCTIONS"),
                    //repository.FindFeatureByName("ACTIVE SPEAKER VIDEO SWITCHING"),
                    repository.FindFeatureByName("FULL DESKTOP SHARING"),
                    repository.FindFeatureByName("SINGLE APPLICATION SHARE"),
                    repository.FindFeatureByName("UPLOAD MULTIPLE PRESENTATIONS"),
                    repository.FindFeatureByName("PRIVATE CHAT MODE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("RECORD & REPLAY SERVICE"),
                    repository.FindFeatureByName("INTERFACE COMPANY BRANDING"),
                    repository.FindFeatureByName("INACTIVITY TIME OUT"),
                    repository.FindFeatureByName("FIXED LINE & MOBILE DIAL-IN"),
                    repository.FindFeatureByName("FREE VOIP CALLING"),
                    repository.FindFeatureByName("MS OUTLOOK INTEGRATION"),
                },
                ApplicationCostPerMonth = 75.00M,
                CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("WEB CONFERENCE"),
                Vendor = repository.FindVendorByName("OnSync"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #region EMAIL

            #region YAHOO SMALL BUSINESS
            ca = new CloudApplication()
            {
                Brand = "YAHOO Small Business",
                ServiceName = "Business Mail",
                CompanyURL = "www.smallbusiness.yahoo.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    //repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    //repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 9.95M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("$25.00"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("YAHOO Small Business"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MICROSOFT EXCHANGE ONLINE
            ca = new CloudApplication()
            {
                Brand = "Microsoft Exchange Online",
                ServiceName = "Exchange Online",
                CompanyURL = "www.office365.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 4.0M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("Microsoft Exchange Online"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO MAIL
            ca = new CloudApplication()
            {
                Brand = "ZOHO Mail",
                ServiceName = "Standard 15Gig",
                CompanyURL = "www.zoho.com/mail",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    //repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    //repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 3.50M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("$25.00"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("ZOHO Mail"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region SMS
            ca = new CloudApplication()
            {
                Brand = "SMS",
                ServiceName = "SMSNexGen",
                CompanyURL = "www.simplymailsolutions.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-6PM"),
                SupportDays = repository.FindSupportDaysByName("MON-FRI"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 100.0M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("SMS"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region BLUETIE
            ca = new CloudApplication()
            {
                Brand = "BlueTie",
                ServiceName = "Business Email",
                CompanyURL = "www.bluetie.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 5.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("BlueTie"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region GMAIL
            ca = new CloudApplication()
            {
                Brand = "GMail",
                ServiceName = "Apps For Business Flexible Plan",
                CompanyURL = "www.google.com/apps",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 3.30M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("GMail"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region STAR
            ca = new CloudApplication()
            {
                Brand = "Star",
                ServiceName = "Star Business Email",
                CompanyURL = "http://email.star.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 8.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("Star"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Business Email",
                CompanyURL = "www.hyperoffice.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 0.0M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("$49.99"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FASTMAIL
            ca = new CloudApplication()
            {
                Brand = "FastMail",
                ServiceName = "FastMail Business",
                CompanyURL = "www.fastmail.fm",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    //repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 0.0M,
                ApplicationCostPerAnnum = 39.95M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("6 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FastMail"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region WEBFUSION
            ca = new CloudApplication()
            {
                Brand = "webfusion",
                ServiceName = "Small Business Exchange",
                CompanyURL = "www.webfusion.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 10.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("webfusion"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region RACKSPACE
            ca = new CloudApplication()
            {
                Brand = "rackspace",
                ServiceName = "Rackspace Email",
                CompanyURL = "www.rackspace.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 150.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("rackspace"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ECLIPSE
            ca = new CloudApplication()
            {
                Brand = "eclipse",
                ServiceName = "Standard Email",
                CompanyURL = "www.eclipse.net.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 5.49M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("eclipse"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FUSEMAIL
            ca = new CloudApplication()
            {
                Brand = "FuseMail",
                ServiceName = "Small Business Email",
                CompanyURL = "www.fusemail.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 2.0M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("FuseMail"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FASTHOSTS
            ca = new CloudApplication()
            {
                Brand = "fasthosts",
                ServiceName = "Business Standard",
                CompanyURL = "www.fasthosts.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 9.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("fasthosts"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region INTERMEDIA
            ca = new CloudApplication()
            {
                Brand = "INTERMEDIA",
                ServiceName = "Hosted Exchange",
                CompanyURL = "www.intermedia.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 150.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("INTERMEDIA"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region 1&1
            ca = new CloudApplication()
            {
                Brand = "1&1",
                ServiceName = "Instant Business Mail",
                CompanyURL = "www.1and1.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF MAILBOXES"),
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE SIZE LIMIT"),
                    repository.FindFeatureByName("NO DAILY MAIL LIMITS"),
                    repository.FindFeatureByName("MIGRATE COMPANY DOMAIN"),
                    repository.FindFeatureByName("ANTI-VIRUS"),
                    repository.FindFeatureByName("SPAM GUARD / ANTI-PHISHING"),
                    repository.FindFeatureByName("BLOCK ADDRESSES / BLACKLIST"),
                    repository.FindFeatureByName("ALIASES"),
                    repository.FindFeatureByName("AD-FREE"),
                    repository.FindFeatureByName("EMAIL ARCHIVING"),
                    repository.FindFeatureByName("QUICK FILTER TOOLBAR"),
                    //repository.FindFeatureByName("SMART FOLDERS"),
                    repository.FindFeatureByName("ACCOUNT GROUPS"),
                    repository.FindFeatureByName("INSTANT MESSAGING"),
                    //repository.FindFeatureByName("TRACK CONVERSATIONS"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("MS OUTLOOK COMPATIBLE"),
                    repository.FindFeatureByName("EMAIL MIGRATION SERVICE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                },
                ApplicationCostPerMonth = 0.69M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("£4.99"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("EMAIL"),
                Vendor = repository.FindVendorByName("1&1"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #region OFFICE

            #region MICROSOFT OFFICE 365
            ca = new CloudApplication()
            {
                Brand = "Microsoft Office 365",
                ServiceName = "Office 365",
                CompanyURL = "www.office365.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("9"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 4.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Microsoft Office 365"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region GOOGLE APPS FOR BUSINESS
            ca = new CloudApplication()
            {
                Brand = "Google Apps for Business",
                ServiceName = "Flexible Plan",
                CompanyURL = "www.google.com/apps",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 5.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Google Apps for Business"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO DOCS
            ca = new CloudApplication()
            {
                Brand = "ZOHO docs",
                ServiceName = "Zoho Docs Standard",
                CompanyURL = "www.zoho.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 3.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("ZOHO docs"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region THINKFREE
            ca = new CloudApplication()
            {
                Brand = "Think Free",
                ServiceName = "Think Free Online",
                CompanyURL = "www.thinkfree.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    //repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Think Free"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FENG OFFICE
            ca = new CloudApplication()
            {
                Brand = "feng OFFICE",
                ServiceName = "Feng Sky",
                CompanyURL = "www.fengoffice.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("ONLINE")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    //repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    //repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    //repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    //repository.FindFeatureByName("LARGE VIDEO FILES"),
                    //repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 10.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("feng OFFICE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ZCUBES
            ca = new CloudApplication()
            {
                Brand = "Z CUBES",
                ServiceName = "Enterprise",
                CompanyURL = "www.zcubes.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLETICKET")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Z CUBES"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Online Collaboration",
                CompanyURL = "www.hyperoffice.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("5"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("250"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24 HOURS"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    //repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    //repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    //repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    //repository.FindFeatureByName("LARGE VIDEO FILES"),
                    //repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 44.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MYOFFICE
            ca = new CloudApplication()
            {
                Brand = "myoffice",
                ServiceName = "O",
                CompanyURL = "www.myoffice.net",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    //repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    //repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    //repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    //repository.FindFeatureByName("LARGE VIDEO FILES"),
                    //repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    repository.FindFeatureByName("EMAIL CLIENT"),
                    repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    repository.FindFeatureByName("INTERNAL WEBSITE"),
                    repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    //repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 49.50M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("myoffice"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region QUICKOFFICE
            ca = new CloudApplication()
            {
                Brand = "Quickoffice",
                ServiceName = "Quickoffice Pro",
                CompanyURL = "www.quickoffice.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    //repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    //repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    //repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    //repository.FindFeatureByName("LARGE VIDEO FILES"),
                    //repository.FindFeatureByName("OWN BRANDING"),
                    //repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    //repository.FindFeatureByName("SHARED CALENDAR"),
                    //repository.FindFeatureByName("WEB MEETINGS"),
                    //repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindFeatureByName("WEB PUBLISHING"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("INTERNAL WEBSITE"),
                    //repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    //repository.FindFeatureByName("READ & EDIT"),
                    //repository.FindFeatureByName("SAVE WEB CONTENT"),
                    //repository.FindFeatureByName("IMAGE CAPTURE"),
                    //repository.FindFeatureByName("AUTOMATIC SYNC"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("£9.21"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ONE-OFF"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Quickoffice"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LIVE DOCUMENTS
            ca = new CloudApplication()
            {
                Brand = "Live Documents",
                ServiceName = "Live Office",
                CompanyURL = "www.live-documents.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    repository.FindFeatureByName("MAILING FEATURES"),
                    repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    repository.FindFeatureByName("DATA MANAGEMENT"),
                    repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    //repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    //repository.FindFeatureByName("SHARED CALENDAR"),
                    //repository.FindFeatureByName("WEB MEETINGS"),
                    //repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindFeatureByName("WEB PUBLISHING"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("INTERNAL WEBSITE"),
                    //repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    //repository.FindFeatureByName("READ & EDIT"),
                    //repository.FindFeatureByName("SAVE WEB CONTENT"),
                    //repository.FindFeatureByName("IMAGE CAPTURE"),
                    //repository.FindFeatureByName("AUTOMATIC SYNC"),
                    //repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NOT APPLICABLE"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("Live Documents"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region EVERNOTE
            ca = new CloudApplication()
            {
                Brand = "EVERNOTE",
                ServiceName = "Evernote Premium",
                CompanyURL = "www.evernote.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    //repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    //repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    //repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    //repository.FindFeatureByName("LARGE VIDEO FILES"),
                    //repository.FindFeatureByName("OWN BRANDING"),
                    //repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    //repository.FindFeatureByName("SHARED CALENDAR"),
                    //repository.FindFeatureByName("WEB MEETINGS"),
                    //repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    repository.FindFeatureByName("WEB PUBLISHING"),
                    //repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("INTERNAL WEBSITE"),
                    //repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    repository.FindFeatureByName("READ & EDIT"),
                    repository.FindFeatureByName("SAVE WEB CONTENT"),
                    repository.FindFeatureByName("IMAGE CAPTURE"),
                    repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    //repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    //repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 5.00M,
                ApplicationCostPerAnnum = 45.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("EVERNOTE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region SLIDEROCKET
            ca = new CloudApplication()
            {
                Brand = "sliderocket",
                ServiceName = "Pro",
                CompanyURL = "www.sliderocket.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    //repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("INTERNAL WEBSITE"),
                    //repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    //repository.FindFeatureByName("READ & EDIT"),
                    //repository.FindFeatureByName("SAVE WEB CONTENT"),
                    //repository.FindFeatureByName("IMAGE CAPTURE"),
                    //repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 24.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NOT APPLICABLE"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("sliderocket"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region PREZI
            ca = new CloudApplication()
            {
                Brand = "PREZI",
                ServiceName = "Enjoy",
                CompanyURL = "www.prezi.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("16384"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    //repository.FindFeatureByName("ADVANCED PROOFING & EDITING"),
                    //repository.FindFeatureByName("ADVANCED REFERENCING & INDEXING"),
                    //repository.FindFeatureByName("MAILING FEATURES"),
                    //repository.FindFeatureByName("FORMULA MANAGEMENT"),
                    //repository.FindFeatureByName("DATA MANAGEMENT"),
                    //repository.FindFeatureByName("ADVANCED CHARTING & TABLES"),
                    repository.FindFeatureByName("ADVANCED DESIGN & ANIMATION"),
                    repository.FindFeatureByName("REAL-TIME COLLABORATION"),
                    repository.FindFeatureByName("AUTOMATIC VERSION MANAGEMENT"),
                    repository.FindFeatureByName("LARGE VIDEO FILES"),
                    repository.FindFeatureByName("OWN BRANDING"),
                    repository.FindFeatureByName("SHARED/COLLABORATION WORKSPACE"),
                    //repository.FindFeatureByName("EMAIL CLIENT"),
                    //repository.FindFeatureByName("CONTACT MANAGEMENT"),
                    //repository.FindFeatureByName("SHARED CALENDAR"),
                    repository.FindFeatureByName("WEB MEETINGS"),
                    repository.FindFeatureByName("PROJECT MANAGEMENT / TASK MANAGER"),
                    //repository.FindFeatureByName("WEB PUBLISHING"),
                    repository.FindFeatureByName("SOCIAL MEDIA INTEGRATION"),
                    //repository.FindFeatureByName("INTERNAL WEBSITE"),
                    //repository.FindFeatureByName("EXTERNAL CUSTOMER WEBSITE"),
                    //repository.FindFeatureByName("READ & EDIT"),
                    //repository.FindFeatureByName("SAVE WEB CONTENT"),
                    //repository.FindFeatureByName("IMAGE CAPTURE"),
                    //repository.FindFeatureByName("AUTOMATIC SYNC"),
                    repository.FindFeatureByName("MS OFFICE COMPATIBLE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("UNLIMITED DOCUMENT STORAGE"),
                    repository.FindFeatureByName("DOCUMENT REVISION HISTORY"),
                    repository.FindFeatureByName("DOCUMENT PASSWORD PROTECTION"),
                    repository.FindFeatureByName("MOBILE/BROWSER EDITING"),
                    //repository.FindFeatureByName("MULTI-USER / GUEST USER"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("SSL SECURITY/ENCRYPTION"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 59.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("NOT APPLICABLE"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("OFFICE"),
                Vendor = repository.FindVendorByName("PREZI"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #region STORAGE & BACKUP

            #region CARBONITE
            ca = new CloudApplication()
            {
                Brand = "CARBONITE",
                ServiceName = "1 Year Plan",
                CompanyURL = "www.carbonite.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("CHAT"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 0.00M,
                ApplicationCostPerAnnum = 41.95M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("ANNUAL"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("CARBONITE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region BOX
            ca = new CloudApplication()
            {
                Brand = "box",
                ServiceName = "Business",
                CompanyURL = "www.box.net",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("3"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("500"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("box"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region OPENDRIVE
            ca = new CloudApplication()
            {
                Brand = "OpenDrive",
                ServiceName = "Office",
                CompanyURL = "www.opendrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("OpenDrive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ADRIVE
            ca = new CloudApplication()
            {
                Brand = "ADrive",
                ServiceName = "Signature",
                CompanyURL = "www.adrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    //repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 6.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("ADrive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region STOREGATE
            ca = new CloudApplication()
            {
                Brand = "storegate",
                ServiceName = "Online BAckup",
                CompanyURL = "www.storegate.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    //repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    //repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("£19.99"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("storegate"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region SUGARSYNC
            ca = new CloudApplication()
            {
                Brand = "SugarSync",
                ServiceName = "100 Gig Plan",
                CompanyURL = "www.sugarsync.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    //repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    //repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 14.99M,
                ApplicationCostPerAnnum = 149.99M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("SugarSync"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FLIPDRIVE
            ca = new CloudApplication()
            {
                Brand = "FLIPDRIVE",
                ServiceName = "Professional 50 Gig",
                CompanyURL = "www.opendrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    //repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    //repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    //repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("FLIPDRIVE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MOZY
            ca = new CloudApplication()
            {
                Brand = "mozy",
                ServiceName = "Mozy Pro",
                CompanyURL = "www.mozy.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 6.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("mozy"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region DROPBOX
            ca = new CloudApplication()
            {
                Brand = "Dropbox",
                ServiceName = "Pro 50",
                CompanyURL = "www.dropbox.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    //repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    //repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    //repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("Dropbox"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region CRASHPLAN
            ca = new CloudApplication()
            {
                Brand = "CRASHPLAN",
                ServiceName = "CrashPlan Pro",
                CompanyURL = "www.crashplan.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    //repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 7.49M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("CRASHPLAN"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ELEPHANTDRIVE
            ca = new CloudApplication()
            {
                Brand = "elephantdrive",
                ServiceName = "Professional Edition",
                CompanyURL = "www.elephantdrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    //repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 99.50M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("elephantdrive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region IDRIVE
            ca = new CloudApplication()
            {
                Brand = "iDrive",
                ServiceName = "iDrivePro 50",
                CompanyURL = "www.idrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("iDrive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LIVEDRIVE
            ca = new CloudApplication()
            {
                Brand = "livedrive",
                ServiceName = "Business Express",
                CompanyURL = "www.livedrive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 14.95M,
                ApplicationCostPerAnnum = 129.95M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("livedrive"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region IBACKUP
            ca = new CloudApplication()
            {
                Brand = "iBackup",
                ServiceName = "iBackup 50",
                CompanyURL = "www.ibackup.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("TROUBLETICKET"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    repository.FindFeatureByName("ONE-CLICK SHARING"),
                    repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 99.50M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("iBackup"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region BACKUPIFY
            ca = new CloudApplication()
            {
                Brand = "backupify",
                ServiceName = "MyCloud100",
                CompanyURL = "www.backupify.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("1"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("STORAGE LIMIT"),
                    repository.FindFeatureByName("INDIVIDUAL FILE LIMIT"),
                    repository.FindFeatureByName("ADJUST TRANSFER SPEED"),
                    repository.FindFeatureByName("MILITARY GRADE DATA TRANSFER"),
                    repository.FindFeatureByName("MILITARY GRADE STORAGE"),
                    repository.FindFeatureByName("VERSION HISTORY"),
                    repository.FindFeatureByName("UNDELETE FILES"),
                    repository.FindFeatureByName("NO BANDWIDTH THROTTLING"),
                    //repository.FindFeatureByName("ONE-CLICK SHARING"),
                    //repository.FindFeatureByName("DRAG & DROP MULTIPLE FILES"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    //repository.FindFeatureByName("PASSWORD PROTECTED FOLDER SHARING"),
                    //repository.FindFeatureByName("ROLE BASED ACCESS"),
                    //repository.FindFeatureByName("SEARCH WITHIN DOCUMENTS"),
                    //repository.FindFeatureByName("LOCAL BACK-UP"),
                    //repository.FindFeatureByName("SERVER BACK-UP"),
                    repository.FindFeatureByName("AUTOMATIC BACK-UP"),
                    repository.FindFeatureByName("STORE VIDEO"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("SOCIAL MEDIA BACK-UP"),
                },
                ApplicationCostPerMonth = 4.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("STORAGE & BACKUP"),
                Vendor = repository.FindVendorByName("backupify"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #region PROJECT MANAGEMENT

            #region ZOHO PROJECTS
            ca = new CloudApplication()
            {
                Brand = "ZOHO Projects",
                ServiceName = "Premium",
                CompanyURL = "www.zoho.com/projects",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    //repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ZOHO Projects"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ATTASK
            ca = new CloudApplication()
            {
                Brand = "@task",
                ServiceName = "Full User",
                CompanyURL = "www.attask.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    //repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 39.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("@task"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MAVENLINK
            ca = new CloudApplication()
            {
                Brand = "mavenlink",
                ServiceName = "Expert",
                CompanyURL = "www.mavenlink.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    //repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("NOT APPLICABLE"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("mavenlink"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region CLARIZEN
            ca = new CloudApplication()
            {
                Brand = "clarizen",
                ServiceName = "Professional",
                CompanyURL = "www.clarizen.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("36 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("clarizen"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region PROWORKFLOW
            ca = new CloudApplication()
            {
                Brand = "ProWorkflow",
                ServiceName = "Professional",
                CompanyURL = "www.proworkflow.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("ProWorkflow"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region HYPEROFFICE
            ca = new CloudApplication()
            {
                Brand = "HyperOffice",
                ServiceName = "Online Project",
                CompanyURL = "www.hyperoffice.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 44.99M,
                ApplicationCostPerAnnum = 431.90M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("HyperOffice"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region WORKETC
            ca = new CloudApplication()
            {
                Brand = "WORKetc",
                ServiceName = "Project Management",
                CompanyURL = "www.attask.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 39.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("WORKetc"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LIQUIDPLANNER
            ca = new CloudApplication()
            {
                Brand = "LiquidPlanner",
                ServiceName = "Monthly Plan",
                CompanyURL = "www.liquidplanner.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("LiquidPlanner"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region CELOXIS
            ca = new CloudApplication()
            {
                Brand = "CELOXIS",
                ServiceName = "Hosted Version",
                CompanyURL = "www.celoxis.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 14.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("CELOXIS"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region BLUECAMROO
            ca = new CloudApplication()
            {
                Brand = "blue camroo",
                ServiceName = "Single User",
                CompanyURL = "www.bluecamroo.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("AUSTRALIA"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("blue camroo"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTMANAGER.COM
            ca = new CloudApplication()
            {
                Brand = "PROJECTMANAGER.com",
                ServiceName = "Starter",
                CompanyURL = "www.projectmanager.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 25.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("PROJECTMANAGER.com"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region COLLABORATECLOUD
            ca = new CloudApplication()
            {
                Brand = "CollaborateCloud",
                ServiceName = "Basic Plus",
                CompanyURL = "www.collaboratecloud.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("CollaborateCloud"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region COPPER
            ca = new CloudApplication()
            {
                Brand = "copper",
                ServiceName = "Studio",
                CompanyURL = "www.copperproject.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("copper"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region PROJECTPLACE
            ca = new CloudApplication()
            {
                Brand = "projectplace",
                ServiceName = "Team Edition",
                CompanyURL = "www.projectplace.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 16.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("projectplace"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region BASECAMP
            ca = new CloudApplication()
            {
                Brand = "Basecamp",
                ServiceName = "Plus",
                CompanyURL = "www.basecamphg.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 49.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Basecamp"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region TRAFFICLIVE
            ca = new CloudApplication()
            {
                Brand = "trafficLIVE",
                ServiceName = "Project",
                CompanyURL = "www.trafficlive.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FREEPHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 37.00M,
                ApplicationCostPerAnnum = 348.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("trafficLIVE"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region IMANAGEPROJECT
            ca = new CloudApplication()
            {
                Brand = "iManageProject",
                ServiceName = "Premium",
                CompanyURL = "www.imanageproject.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    //repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("iManageProject"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region MYINTERVALS
            ca = new CloudApplication()
            {
                Brand = "intervals",
                ServiceName = "Basic",
                CompanyURL = "www.myintervals.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    repository.FindFeatureByName("CLIENT INVOICING"),
                    repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    //repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("intervals"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region GENIUSPROJECT
            ca = new CloudApplication()
            {
                Brand = "Geniusproject",
                ServiceName = "On-demand PPM",
                CompanyURL = "www.geniusinside.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    //repository.FindMobilePlatformByName("IPAD")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 29.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("Geniusproject"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region GLASSCUBES
            ca = new CloudApplication()
            {
                Brand = "glasscubes",
                ServiceName = "Standard",
                CompanyURL = "www.glasscubes.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    //repository.FindOperatingSystemByName("MAC"),
                    //repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //    //repository.FindMobilePlatformByName("IPAD")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    //repository.FindBrowserByName("CHROME"),
                    //repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("NUMBER OF PROJECTS"),
                    repository.FindFeatureByName("FILE STORAGE"),
                    repository.FindFeatureByName("MULTI-USERS PER ACCOUNT"),
                    repository.FindFeatureByName("DOCUMENT SHARING"),
                    repository.FindFeatureByName("SHARED WORKSPACE"),
                    repository.FindFeatureByName("EDITED DOCUMENT TRACKING"),
                    repository.FindFeatureByName("LOCKFILES"),
                    repository.FindFeatureByName("UPDATE & DEADLINE ALERTS"),
                    repository.FindFeatureByName("INTERACTIVE GANTT CHARTS"),
                    repository.FindFeatureByName("BUDGET TRACKING"),
                    //repository.FindFeatureByName("CLIENT INVOICING"),
                    //repository.FindFeatureByName("PROJECT WIKI"),
                    repository.FindFeatureByName("CUSTOMIZED REPORTS"),
                    repository.FindFeatureByName("MS PROJECT COMPATIBLE"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("MILITARY GRADE DOCUMENT SECURITY"),
                    repository.FindFeatureByName("GUARANTEED RESTORE"),
                    repository.FindFeatureByName("OFFLINE MODE"),
                    repository.FindFeatureByName("3RD PARTY APIS"),
                    //repository.FindFeatureByName("BUG TRACKER"),
                },
                ApplicationCostPerMonth = 30.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("PROJECT MANAGEMENT"),
                Vendor = repository.FindVendorByName("glasscubes"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #region FINANCIAL

            #region XERO
            ca = new CloudApplication()
            {
                Brand = "xero",
                ServiceName = "Medium",
                CompanyURL = "www.xero.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 19.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("1 MONTH"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("xero"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region SAGEONE
            ca = new CloudApplication()
            {
                Brand = "SageOne",
                ServiceName = "Accounts",
                CompanyURL = "www.sageone.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 10.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("1 MONTH"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("SageOne"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region E-CONOMIC
            ca = new CloudApplication()
            {
                Brand = "e-conomic",
                ServiceName = "Small",
                CompanyURL = "www.e-conomic.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 12.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("1 MONTH"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("e-conomic"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ARITHMO
            ca = new CloudApplication()
            {
                Brand = "ARITHMO",
                ServiceName = "Small Business",
                CompanyURL = "www.arithmo.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("CALLBACK"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-6PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 35.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("NO"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ARITHMO"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LIQUID
            ca = new CloudApplication()
            {
                Brand = "liquid",
                ServiceName = "Business Accounting",
                CompanyURL = "www.liquidaccounts.net",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("LINUX")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                //MobilePlatforms = new List<MobilePlatform>()
                //{
                //    repository.FindMobilePlatformByName("ANDROID"),
                //    repository.FindMobilePlatformByName("IPHONE"),
                //    repository.FindMobilePlatformByName("BB"),
                //    repository.FindMobilePlatformByName("WIN")
                //},
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("5"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 20.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("liquid"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region KASHOO
            ca = new CloudApplication()
            {
                Brand = "kashoo",
                ServiceName = "Accounting",
                CompanyURL = "www.kashoo.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("kashoo"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FRESHBOOKS
            ca = new CloudApplication()
            {
                Brand = "FRSHBOOKS",
                ServiceName = "Evergreen Plan",
                CompanyURL = "www.freshbooks.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 19.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FRSHBOOKS"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region CLEARBOOKS
            ca = new CloudApplication()
            {
                Brand = "ClearBooks",
                ServiceName = "Premium",
                CompanyURL = "www.clearbooks.co.uk",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("9AM-5PM"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 15.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ClearBooks"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region LEDGERBLE
            ca = new CloudApplication()
            {
                Brand = "ledgerble",
                ServiceName = "Premium",
                CompanyURL = "www.ledgerble.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    //repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    //repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 14.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ledgerble"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region KASHFLOW
            ca = new CloudApplication()
            {
                Brand = "KashFlow",
                ServiceName = "Accounting",
                CompanyURL = "www.kashflow.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = true,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 15.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("PRE-PAY"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("KashFlow"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region FREEAGENT
            ca = new CloudApplication()
            {
                Brand = "FreeAgent",
                ServiceName = "Sole Trader",
                CompanyURL = "www.freeagentcentral.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 25.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("FreeAgent"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region OUTRIGHT
            ca = new CloudApplication()
            {
                Brand = "outright",
                ServiceName = "Accounting",
                CompanyURL = "www.outright.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    //repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 9.95M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("outright"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ZOHO BOOKS
            ca = new CloudApplication()
            {
                Brand = "ZOHO Books",
                ServiceName = "Books",
                CompanyURL = "www.zoho.com/books",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 24.00M,
                ApplicationCostPerAnnum = 240.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("ZOHO Books"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region ICASHBOOK
            ca = new CloudApplication()
            {
                Brand = "iCashbook",
                ServiceName = "Standard",
                CompanyURL = "www.icashbook.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("US"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    //repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    //repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    //repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    //repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    //repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    //repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    //repository.FindFeatureByName("PAYROLL"),
                    //repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 19.50M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("iCashbook"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region YENDO
            ca = new CloudApplication()
            {
                Brand = "Yendo",
                ServiceName = "Standard",
                CompanyURL = "www.yendo.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    repository.FindSupportTypeByName("FAQ"),
                    repository.FindSupportTypeByName("TROUBLESHOOT"),
                    //repository.FindSupportTypeByName("EMAIL")
                },
                SupportHours = repository.FindSupportHoursByName("24"),
                SupportDays = repository.FindSupportDaysByName("7"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 26.00M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("Yendo"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #region INTUIT
            ca = new CloudApplication()
            {
                Brand = "intuit",
                ServiceName = "Online Essentials",
                CompanyURL = "www.intuit.com",
                OperatingSystems = new List<Domain.Models.OperatingSystem>()
                {
                    repository.FindOperatingSystemByName("WIN"),
                    repository.FindOperatingSystemByName("MAC"),
                    repository.FindOperatingSystemByName("IPAD")
                },
                //MobilePlatforms = repository.GetAllMobilePlatforms(),
                MobilePlatforms = new List<MobilePlatform>()
                {
                    repository.FindMobilePlatformByName("ANDROID"),
                    repository.FindMobilePlatformByName("IPHONE"),
                    repository.FindMobilePlatformByName("BB"),
                    repository.FindMobilePlatformByName("WIN")
                },
                Browsers = new List<Browser>()
                {
                    repository.FindBrowserByName("Internet Explorer 6"),
                    repository.FindBrowserByName("Internet Explorer 7"),
                    repository.FindBrowserByName("Internet Explorer 8"),
                    repository.FindBrowserByName("Internet Explorer 9"),
                    repository.FindBrowserByName("FIREFOX"),
                    repository.FindBrowserByName("CHROME"),
                    repository.FindBrowserByName("SAFARI"),
                },
                LicenceTypeMinimum = repository.FindLicenceTypeMinimumByName("1"),
                LicenceTypeMaximum = repository.FindLicenceTypeMaximumByName("99"),
                Languages = new List<Language>()
                {
                    repository.FindLanguageByName("ENGLISH")
                },
                SupportTypes = new List<SupportType>()
                {
                    //repository.FindSupportTypeByName("PHONE"),
                    repository.FindSupportTypeByName("ONLINE"),
                    repository.FindSupportTypeByName("COMMUNITY")
                },
                SupportHours = repository.FindSupportHoursByName("NOT APPLICABLE"),
                SupportDays = repository.FindSupportDaysByName("NOT APPLICABLE"),
                SupportTerritories = new List<SupportTerritory>()
                {
                    repository.FindSupportTerritoryByName("UK"),
                },
                VideoTrainingSupport = false,
                //MaximumMeetingAttendees = 50,
                //MaximumWebinarAttendees = 0,
                CloudApplicationFeatures = new List<CloudApplicationFeature>()
                {
                    repository.FindFeatureByName("UNLIMITED TRANSACTIONS"),
                    repository.FindFeatureByName("UNLIMITED CUSTOMER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED SUPPLIER RECORDS"),
                    repository.FindFeatureByName("UNLIMITED PRODUCT & SERVICE DESCRIPTIONS"),
                    repository.FindFeatureByName("CREATE INVOICES"),
                    repository.FindFeatureByName("INVOICE-TO-PAYMENT MATCHING"),
                    repository.FindFeatureByName("MULTI-CURRENCY INVOICING"),
                    repository.FindFeatureByName("RECORD BANK PAYMENTS"),
                    repository.FindFeatureByName("CUSTOMISED REPORTS"),
                    repository.FindFeatureByName("SSL SECURITY"),
                    repository.FindFeatureByName("PROJECT ACCOUNTING"),
                    repository.FindFeatureByName("EXTERNAL ACCESS (FOR ACCOUNTANTS)"),
                    repository.FindFeatureByName("MULTI-USER ACCESS"),
                    repository.FindFeatureByName("MS EXCEL COMPATIBLE"),
                    repository.FindFeatureByName("FIXED ASSET DEPRECIATION TOOL"),
                    repository.FindFeatureByName("CUSTOMER STATEMENTS"),
                    repository.FindFeatureByName("PURCHASE ORDER SYSTEM"),
                    repository.FindFeatureByName("PAYROLL"),
                    repository.FindFeatureByName("VAT FILING"),
                    repository.FindFeatureByName("3RD PARTY API"),
                },
                ApplicationCostPerMonth = 24.99M,
                ApplicationCostPerAnnum = 0.00M,
                //CallsPackageCostPerMonth = 0M,
                SetupFee = repository.FindSetupFeeByName("NOT APPLICABLE"),
                MinimumContract = repository.FindMinimumContractByName("12 MONTHS"),
                PaymentFrequency = repository.FindPaymentFrequencyByName("MONTHLY"),
                PaymentOptions = new List<PaymentOption>()
                {
                    repository.FindPaymentOptionByName("CREDIT CARD"),
                    repository.FindPaymentOptionByName("DEBIT CARD"),
                },
                FreeTrialPeriod = repository.FindFreeTrialPeriodByName("YES"),
                Category = repository.FindCategoryByName("FINANCIAL"),
                Vendor = repository.FindVendorByName("intuit"),
                Description = repository.GetDescription(),
                AddDate = DateTime.Now,
            };

            repository.AddCloudApplication(ca);

            #endregion

            #endregion

            #endregion
        }
    }
}
