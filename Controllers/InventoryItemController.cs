using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqApplication.Models;
using System.Data.SqlClient;
using System.Configuration;


namespace LinqApplication.Controllers
{
    public class InventoryItemController : Controller
    {
        // GET: InventoryItem
        public ActionResult Index(string option, string search)
        {
            IM_importEntities import = new IM_importEntities(); //our object to work with
            List<InventoryItem> items = import.inventory_items.Where(x => x.itemnum == "480-15" && x.item_type == "moulding").Select(x => new InventoryItem{itemnum = x.itemnum}).ToList();
            items.ToList().ForEach(x => Console.WriteLine(x.itemnum)); //foreach loop for items

            //if (option == "480")
            //{
            //Index action method will return a view with a item records based on what a user specify the value in textbox  
            //return View(items = import.inventory_items.Where(x => x.itemnum == search || search == null).Select(x => new InventoryItem { itemnum = x.itemnum }).ToList());
            // }

            /*else
            {
                return View(items = import.inventory_items.Where(x = > x.itemnum.StartsWith(search) || search == null).ToList());
            }
            */

            return View(items.ToList());
           
            }
        }
    }
