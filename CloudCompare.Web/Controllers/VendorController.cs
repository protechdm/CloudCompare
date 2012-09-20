using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CloudCompare.Web.Models;

//using FluentSecurity;
//using FluentSecurity.Policy;
using CloudCompare.Web.FluentSecurity.Policy;

namespace CloudCompare.Web.Controllers
{
    public class VendorController : Controller
    {
        //
        // GET: /Vendor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Vendor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vendor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vendor/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Vendor/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vendor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vendor/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vendor/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult AddNewVendor()
        {
            return View(new VendorModel());

        }

        [HttpPost]
        public ActionResult AddNewVendor(VendorModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("AddNewVendor");
        }
    }


    //public class AdministratorPolicy : RequireRolePolicy
    //{
    //    public AdministratorPolicy()
    //        : base(new List<object> { UserRole.Administrator }.ToArray())
    //    { }
    //}
}
