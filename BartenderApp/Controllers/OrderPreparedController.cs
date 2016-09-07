using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class OrderPreparedController : Controller
    {
        private static int id = 0;

        // GET: OrderPrepared
        public ActionResult Order()
        {
            return View(HomeController.OrderedList);
        }

        // Returns prepared drink list
        public ActionResult Prepared()
        {
            return View(HomeController.PreparedList);
        }

        // Adds a drink to the Ordered List
        public ActionResult AddOrderDrink (Drink drink)
        {
            drink.Id = id++;
            HomeController.OrderedList.Add(drink);
            return RedirectToAction("Index", "Home");
        }

        // Adds a drink to the Prepared List
        public ActionResult AddPreparedDrink (Drink drink)
        {
            HomeController.PreparedList.Add(drink);
            RemoveOrderedDrink(drink);
            return RedirectToAction("Order", "OrderPrepared");
        }

        // Removes a drink from the Ordered List
        public ActionResult RemoveOrderedDrink (Drink drink)
        {
            HomeController.OrderedList.RemoveAll(d => d.Id == drink.Id);
            return RedirectToAction("Order");
        }

        //Removes a drink from the Prepared List
        public ActionResult RemovePreparedDrink (Drink drink)
        {
            HomeController.PreparedList.RemoveAll(d => d.Id == drink.Id);
            return RedirectToAction("Prepared");
        }


    }
}