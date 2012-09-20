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

namespace CloudCompare.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CloudCompare.Domain.CloudCompareContext>());
            Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());
            //InsertVendor();
            StageData();
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
    }
}
