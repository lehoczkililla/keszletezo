using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models;
using Hotcakes.Commerce.Urls;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Orders;
using Hotcakes.Commerce;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Controllers
{
    public class ReceptController : DnnController
    {
        //#region Private Members
        //private Product product = null;
        //#endregion

        //public ActionResult AddButtonClick()
        //{
            
        //    var context = HccRequestContext.Current;
        //    var applic = HotcakesApplication.Current;


        //    var p = applic.CatalogServices.Products.FindBySku("SAMPLE001");

        //    // set the quantity
        //    var quantity = 1;

        //    // create a reference to the current shopping cart
        //    Order currentCart = applic.OrderServices.EnsureShoppingCart();

        //    // create a line item for the cart using the product
        //    LineItem li = product.ConvertToLineItem(applic, quantity, new OptionSelections());

        //    // add the line item to the current cart
        //    applic.AddToOrderWithCalculateAndSave(currentCart, li);

        //    // send the customer to the shopping cart page
        //    Response.Redirect(HccUrlBuilder.RouteHccUrl(HccRoute.Cart));

        //    return View();

        //}

        // GET: Recept
        public ActionResult Index()
        {
            //Recept recept = new Recept();
            //recept.ReceptSK = 1;
            //recept.ReceptNev = "Brownie";
            //recept.Leiras = "Jóóóó";

            var rec = ReceptManager.Instance.GetRecepts();
            ViewBag.ReceptMicsoda = rec;
            return View(rec);
        }
         
        // GET: Recept/Details/5
        public ActionResult Details(int id)
        {
            var receptek = ReceptManager.Instance.GetRecept(id);

            return View(receptek);
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

       

        public ActionResult Hiba()
        {
            ViewBag.hibakod = "Sajnáljuk, de a szolgáltatás jelenleg nem elérhető!";
            return View(ViewBag.hibakod);
        }
    }
}
