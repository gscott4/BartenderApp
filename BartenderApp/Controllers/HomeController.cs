using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        // Creates a list that holds all the drinks in the menu
        private static List<Drink> drinkList = new List<Drink>()
        {
            new Drink {Name = "Manhattan", Description = "This drink will make you feel like you're Don Draper.", Price = 8.00, AlcoholPercentage = 40 },
            new Drink {Name = "Margarita", Description = "This drink will transport you to a Carribbean Island.", Price = 6.00, AlcoholPercentage = 35 },
            new Drink {Name = "Moscow Mule", Description = "Comes in a cool copper mug!", Price = 8, AlcoholPercentage = 40  },
            new Drink {Name = "Gin & Tonic", Description = "Classic summer drink.", Price = 7, AlcoholPercentage = 42 },
            new Drink {Name = "4 Loko", Description = "The finest malt liquor to ever be crafted. Only drink if you intend on waking up in a gutter.", Price = 2.50, AlcoholPercentage = 12 }
        };

        // Creates two lists, one for ordered drinks and the other for prepared drinks
        public static List<Drink> OrderedList = new List<Drink>();
        public static List<Drink> PreparedList = new List<Drink>();

        //GET: Home
        public ActionResult Index()
        {
            return View(drinkList); //returns Index view
        }
    }
}