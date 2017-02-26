using DrinksOrdering.Models;
using DrinksOrdering.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrinksOrdering.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            DrinksViewModel dvm = new DrinksViewModel();
            dvm.Drinks = Drinks.Get_AllDrinks();
			return View(dvm);
		}

        [HttpPost]
        public ActionResult Add_Drink(Drink newDrink)
        {
            if (newDrink != null)
                Drinks.Add_Drink(newDrink.Name, newDrink.Quantity);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_DrinkQuantity(string drink, int amt)
        {
            if (!string.IsNullOrEmpty(drink))
                Drinks.Update_DrinkQuantity(drink, amt);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete_Drink(string drink)
        {
            if (!string.IsNullOrEmpty(drink))
                Drinks.Delete_Drink(drink);
            return RedirectToAction(nameof(Index));
        }
	}
}