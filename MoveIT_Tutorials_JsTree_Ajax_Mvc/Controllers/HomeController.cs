using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoveIT_Tutorials_JsTree_Ajax_Mvc.Models;

namespace MoveIT_Tutorials_JsTree_Ajax_Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }
        public JsonResult TreeViewTestContent(string id)
        {
            List<TreeViewItemModel> items = new List<TreeViewItemModel>();
            TreeViewItemModel aItem = new TreeViewItemModel();
            aItem.data = new TreeViewItemModelData
                         {
                             title = "Node 1",
                             icon = "folder"
                         };
            aItem.attr = new TreeViewItemModelAttributes
                         {
                             id = "1",
                             other_attribute = "additional data can go here"
                         };
            aItem.state = "closed";

            items.Add(aItem);

            aItem = new TreeViewItemModel();
            aItem.data = new TreeViewItemModelData
            {
                title = "Node 2",
                icon = "folder"
            };
            aItem.attr = new TreeViewItemModelAttributes
            {
                id = "2",
                other_attribute = "additional data can go here"
            };
            aItem.state = "closed";

            items.Add(aItem);
            return Json(items, JsonRequestBehavior.AllowGet);
        }
    }
}


