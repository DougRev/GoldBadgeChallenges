using _01_KomodoCafe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.UI
{
    public class ProgramUI
    {
        private readonly MenuItemRepository _menuRepo = new MenuItemRepository();
        public void Run()
        {
            SeedContent();
            Directory();
        }
        public void Directory()
        {
            bool isRunning = true;
            while (isRunning)
            {
         
                Console.WriteLine("Please make a selection from the following:\n" +
                "1. Create New Menu Item\n" +
                "2. Delete Menu Items\n" +
                "3. View All Menu Items\n" +
                "4. Get Grocery List\n" +
                "10. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ViewAllMenuItems();
                        break;
                    case "4":
                        GetIngredients();
                        break;
                    case "10":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-4.\n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

        private void GetIngredients()
        {
            Console.Clear();
            List<MenuItem> ingredientList = _menuRepo.GetMenuItems();
            foreach (var item in ingredientList)
            {
                DisplayIngredients(item);
            }
            Console.ReadKey();
        }

        public void ViewAllMenuItems()
        {
            Console.Clear();
            List<MenuItem> allMenuItems = _menuRepo.GetMenuItems();
            foreach (var item in allMenuItems)
            {
                DisplayItemDetails(item);
            }
            Console.ReadKey();
        }

        private void DisplayItemDetails(MenuItem item)
        {
            Console.WriteLine($"Item.MealName: {item.MealName}\n" +
                $"Item.MealNumber: {item.MealNumber}\n" +
                $"Item.ItemType: {item.ItemType}\n" +
                $"Item.Ingredients: {item.Ingredients}\n" +
                $"Item.Description: {item.Description}\n" +
                $"Item.Price: {item.Price}\n" +
                $"------------------------------------------------\n");
        }

        private void DisplayIngredients(MenuItem item)
        {
            Console.WriteLine($"Item.Ingredients: {item.Ingredients}\n");
        }
           

        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuItem item = new MenuItem();

            Console.WriteLine("Are you adding a Food or Beverage?\n" +
            "1. Food\n" +
            "2. Beverage\n");

            var itemType = int.Parse(Console.ReadLine());
            item.ItemType = (ItemType)itemType;

            Console.WriteLine("What is the Meal Number?");
            var mealNumber = int.Parse((Console.ReadLine()));
            item.MealNumber = mealNumber;

            Console.WriteLine("What is the Meal Name?");
            var mealName = Console.ReadLine();
            item.MealName = mealName;

            Console.WriteLine("What are the ingredients?");
            var ingredients = Console.ReadLine();
            item.Ingredients = ingredients;

            Console.WriteLine("What is the description of the item?");
            var description = Console.ReadLine();
            item.Description = description;

            Console.WriteLine("What is the price of the item?");
            double price = int.Parse(Console.ReadLine());
            item.Price = price;

            bool success = _menuRepo.AddNewMenuItem(item);
            if (success)
            {
                Console.WriteLine($"{item.MealName} has been added to the database");
            }
            else
            {
                Console.WriteLine("Item was not added to menu.");
            }
            Console.ReadKey();
        }

        public void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the item you want to remove?");
            string mealName = Console.ReadLine();
            bool success = _menuRepo.DeleteMenuItem(mealName);
            if (success)
            {
                Console.WriteLine($"{mealName} has been removed.");
            }
            else
            {
                Console.WriteLine("Item was not removed.");
            }
            Console.ReadKey();


        }

        public void SeedContent()
        {
          MenuItem itemA = new MenuItem("CheeseBurger",ItemType.Food, "2 Beef Patties + Garden Veggies.");
          MenuItem itemB = new MenuItem("HotDog", ItemType.Food, "1 Hot Dog + Ketchup, Mustard, Relish");
          MenuItem itemC = new MenuItem("Soda", ItemType.Beverage, "6 total sodas from Coke");
          MenuItem itemD = new MenuItem("Milkshake", ItemType.Beverage, "Vanilla, Chocolate, Strawberry Ice Cream, Whole Milk");
         _menuRepo.AddNewMenuItem(itemA);
         _menuRepo.AddNewMenuItem(itemB);
         _menuRepo.AddNewMenuItem(itemC);
         _menuRepo.AddNewMenuItem(itemD);
        }
    }
}

