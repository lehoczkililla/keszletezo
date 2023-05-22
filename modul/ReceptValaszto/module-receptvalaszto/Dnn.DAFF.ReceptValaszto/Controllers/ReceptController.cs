using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Controllers
{
    public class ReceptController : DnnController
    {
        // GET: Recept
        public ActionResult Index()
        {
           var receptek =  ReceptManager.Instance.GetRecepts();
            return View(receptek);
        }
         
        // GET: Recept/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recept/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recept/Create
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

        // GET: Recept/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recept/Edit/5
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

        // GET: Recept/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recept/Delete/5
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
    }
}
