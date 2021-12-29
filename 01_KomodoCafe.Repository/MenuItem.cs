using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    public class MenuItem
    {
        public MenuItem(string mealName, ItemType itemtype, string ingredients)
        {
            MealName = mealName;
            ItemType = itemtype;
            Ingredients = ingredients;
        }

        public MenuItem()
        {

        }

        public string MealName { get; set; }
        public int MealNumber { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public ItemType ItemType { get; set; }

        public string Ingredients { get; set; }

        public MenuItem
           (string mealName,
            int mealNumber,
           string description,
           double price
,          string ingredients)

        {
            MealName = mealName;
            MealNumber = mealNumber;
            Description = description;
            Price = price;
            Ingredients = ingredients;
         }
    }
}
