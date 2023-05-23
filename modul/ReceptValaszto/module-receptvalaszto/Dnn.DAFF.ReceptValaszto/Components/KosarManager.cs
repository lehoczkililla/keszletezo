using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Services.Exceptions;
using Hotcakes.Commerce;
using Hotcakes.Commerce.Catalog;
using Hotcakes.Commerce.Extensions;
using Hotcakes.Commerce.Orders;
using Hotcakes.Commerce.Urls;
using Hotcakes.Commerce.Reporting;


namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components
{
    
    public partial class View : AddToCartModuleBase
    {
     
        #region Private Members
        private Product product = null;
        #endregion
        #region Event Handlers


        protected void lnkAddToCart_OnClick(object sender, EventArgs e)
        {
            //AddProductToCart();
        }

        #endregion

        #region Helper Methods


        //private void GetProductFromTheStore()
        //{
        //    var context = HccRequestContext.Current;


        //    var searchCriteria = new OrderSearchCriteria
        //    {
        //        StartDateUtc = DateTime.UtcNow.AddDays(-7),
        //        EndDateUtc = DateTime.UtcNow
        //    };

        //    var totalResults = 0;
        //    var ordersByDateRange = Factory.CreateService<OrderService>(context).Orders.FindByCriteriaPaged(searchCriteria, 1, 10, ref totalResults);

        //    // now do something with the orders


        //        //-----------------------------------

        //    // create a reference to the Hotcakes store
        //    var HccApp = HccAppHelper.InitHccApp();

        //    // get a collection of the products in the store already
        //    var products = HccApp.CatalogServices.Products.FindAllPaged(1, int.MaxValue);

        //    // make sure we don't throw an error
        //    if (products == null || !products.Any()) return;

        //    // see if any are available that don't have any choices assigned
        //    if (products.Any(p => !p.HasOptions() && !p.HasVariants()))
        //    {
        //        // find the first product returned that doesn't have options or variants
        //        product = products.FirstOrDefault(p => !p.HasOptions() && !p.HasVariants());
        //    }
        //}

        private void AddProductToCart()
        {

            var context = HccRequestContext.Current;
            var applic = HotcakesApplication.Current;
           

            var p = applic.CatalogServices.Products.FindBySku("SAMPLE001");

            // set the quantity
            var quantity = 1;

            // create a reference to the current shopping cart
            Order currentCart = applic.OrderServices.EnsureShoppingCart();

            // create a line item for the cart using the product
            LineItem li = product.ConvertToLineItem(applic, quantity, new OptionSelections());

            // add the line item to the current cart
            applic.AddToOrderWithCalculateAndSave(currentCart, li);

            // send the customer to the shopping cart page
            Response.Redirect(HccUrlBuilder.RouteHccUrl(HccRoute.Cart));

        }

        #endregion
    }




}