/*
' Copyright (c) 2023 DAFF Gonosz Rt.
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components;
using DAFF.Modules.Dnn.DAFF.ReceptValaszto.Models;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;


namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Controllers
{
    [DnnHandleError]
    public class ItemController : DnnController
    {
        public ActionResult AddProductToCart(object sender, EventArgs e)
        {

            //// create a reference to the Hotcakes store
            //var HccApp = HccAppHelper.InitHccApp();
            //// get an instance of the product to add
            //var p = HccApp.CatalogServices.Products.FindBySku("SAMPLE001");

            //// set the quantity
            //int qty = 1;

            //// create a reference to the current shopping cart
            //Order currentCart = HccApp.OrderServices.EnsureShoppingCart();

            //// create a line item for the cart using the product
            //LineItem li = HccApp.CatalogServices.ConvertProductToLineItem(p, new OptionSelections(), qty, HccApp);

            //// add the line item to the current cart
            //HccApp.AddToOrderWithCalculateAndSave(currentCart, li);

            //// send the customer to the shopping cart page
            //Response.Redirect(HccUrlBuilder.RouteHccUrl(HccRoute.Cart));

            ////return View();



            return Content("Hi there!");

        }


        public ActionResult Delete(int itemId)
        {
            ItemManager.Instance.DeleteItem(itemId, ModuleContext.ModuleId);
            return RedirectToDefaultRoute();
        }

        public ActionResult Edit(int itemId = -1)
        {
            DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins);

            var userlist = UserController.GetUsers(PortalSettings.PortalId);
            var users = from user in userlist.Cast<UserInfo>().ToList()
                        select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

            ViewBag.Users = users;

            var item = (itemId == -1)
                 ? new Item { ModuleId = ModuleContext.ModuleId }
                 : ItemManager.Instance.GetItem(itemId, ModuleContext.ModuleId);

            return View(item);
        }

        [HttpPost]
        [DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken]
        public ActionResult Edit(Item item)
        {
            if (item.ItemId == -1)
            {
                item.CreatedByUserId = User.UserID;
                item.CreatedOnDate = DateTime.UtcNow;
                item.LastModifiedByUserId = User.UserID;
                item.LastModifiedOnDate = DateTime.UtcNow;

                ItemManager.Instance.CreateItem(item);
            }
            else
            {
                var existingItem = ItemManager.Instance.GetItem(item.ItemId, item.ModuleId);
                existingItem.LastModifiedByUserId = User.UserID;
                existingItem.LastModifiedOnDate = DateTime.UtcNow;
                existingItem.ItemName = item.ItemName;
                existingItem.ItemDescription = item.ItemDescription;
                existingItem.AssignedUserId = item.AssignedUserId;

                ItemManager.Instance.UpdateItem(existingItem);
            }

            return RedirectToDefaultRoute();
        }


        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public ActionResult Index()
        {
            var items = ItemManager.Instance.GetItems(ModuleContext.ModuleId);
            //return View(items);

            return Content("Hiiiiii");
        }

    }
}
