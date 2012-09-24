using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudCompare.Domain.Models;
using CloudCompare.POCOQueryRepository;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;
using ManagedWinapi;
using GhostscriptSharp;

namespace CloudCompare.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            string TEST_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf";
            string SINGLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CloudCompare.Domain.CloudCompareContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());
            //InsertVendor();
            StageData();

            //string outputFile = SINGLE_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg";
            //GetThumbnail("J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf");
            //var x = GhostscriptWrapper.GetPageThumb(TEST_FILE_LOCATION, outputFile, 3, 100, 100);

        }

        private static void InsertVendor()
        {
            var vendor = new Vendor
            {
                VendorName = "XERO"
            };

            using (var context = new CloudCompareContext())
            {
                context.Vendors.Add(vendor);
                context.SaveChanges();
            }
        }

        #region StageData
        private static void StageData()
        {
            var data = new FakeData();
            //var context = new FakeCloudCompareContext();
            var context = new CloudCompareContext();
            data.LoadFakeReferenceData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }



            data.LoadFakeProductionData(context);
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                foreach (var validationErrors in dbEx.Entries)
                {
                    //foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

        }
        #endregion

        private static void GetThumbnail(string fileName)
        {

            var document = ShellObject.FromParsingName(fileName);


        }
    }
}
