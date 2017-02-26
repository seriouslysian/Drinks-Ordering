using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DrinksOrdering.Models
{
    public static class Drinks
    {
        public static List<Drink> _Drinks;

        private static void InitialiseDrinks()
        {
            if (_Drinks == null)
                _Drinks = new List<Drink>();
        }

        public static bool Add_Drink(string drinkName, int qty)
        {
            Drinks.InitialiseDrinks();

            if (_Drinks.Any(x => x.Name.ToLower() == drinkName.ToLower()))
                return Update_DrinkQuantity(drinkName, qty);

            Drink newDrink = new Drink()
            {
                Name = drinkName,
                Quantity = qty
            };

            _Drinks.Add(newDrink);

            return true;
        }

        public static bool Update_DrinkQuantity(string drinkName, int increase)
        {
            Drinks.InitialiseDrinks();

            Drink drink = _Drinks.FirstOrDefault(x => x.Name.ToLower() == drinkName.ToLower());

            if (drink == null)
                return false;

            drink.Quantity += increase;
            return true;
        }

        public static bool Delete_Drink(string drinkName)
        {
            Drinks.InitialiseDrinks();

            Drink drink = _Drinks.FirstOrDefault(x => x.Name.ToLower() == drinkName.ToLower());

            if (drink == null)
                return false;

            _Drinks.Remove(drink);
            return true;
        }

        public static Drink Get_Drink(string drinkName)
        {
            Drinks.InitialiseDrinks();
            Drink drink = _Drinks.FirstOrDefault(x => x.Name.ToLower() == drinkName.ToLower());
            return drink;
        }

        public static List<Drink> Get_AllDrinks()
        {
            Drinks.InitialiseDrinks();
            return _Drinks;
        }
    }
}