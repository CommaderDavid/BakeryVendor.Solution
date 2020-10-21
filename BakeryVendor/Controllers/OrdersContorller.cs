using Microsoft.AspNetCore.Mvc;
using BakeryVendor.Models;
using System.Collections.Generic;

namespace BakeryVendor.Controllers
{
    public class OrdersController : Controller
    {
        

        [HttpPost("/orders/delete")]
        public ActionResult DeleteAll()
        {
            Order.ClearAll();
            return View();
        }
    }
}