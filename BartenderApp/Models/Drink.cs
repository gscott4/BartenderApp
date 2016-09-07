using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class Drink
    {
        // The values that the Drink object should hold.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double AlcoholPercentage { get; set; }

    }
}