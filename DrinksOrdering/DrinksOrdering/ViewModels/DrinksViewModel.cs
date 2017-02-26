using DrinksOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksOrdering.ViewModels
{
    public class DrinksViewModel
    {
        public List<Drink> Drinks { get; set; }
        public Drink NewDrink { get; set; }
    }
}