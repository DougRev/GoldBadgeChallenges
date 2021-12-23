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
        public void Run()
        {
            Directory();
        }
        public void Directory()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Please make a selection from the following:\n" +
                "1. Create New Menu Item\n" +
                "2. Delete Menu Items\n" +
                "3. View All Menu Items\n" +
                "4. Exit\n");

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
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-4.\n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void ViewAllMenuItems()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Choose your Menu Item Selection:\n" +
                    "1. Cheeseburger\n" +
                    "2. Hot Dog\n" +
                    "3. Salad\n" +
                    "4. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CheeseburgerMeal();
                        break;
                    case "2":
                        HotDogMeal();
                        break;
                    case "3":
                        SaladMeal();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-4.\n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
            }
        }
            public void CheeseburgerMeal()
            {
                Console.Clear();
                Console.WriteLine("This 8oz 80/20 Burger comes with lettuce,tomato,onion,pickle on the side and you can add as much ketchup, mayo, and mustard as you like.\n" +
                   "Price is 6.99");
                Console.ReadKey(true);
            }

            public void HotDogMeal()
            {
                Console.WriteLine("This is a hodog with and it comes standard with ketchup, mustard and a run through the garden!\n" +
                    "Price 5.99");
            Console.ReadKey();
            }

            public void SaladMeal()
            {
                Console.WriteLine("This is our Seasonal salad with fresh greens and 8oz of our Organic grilled chicken.\n" +
                    "Price 8.99");
            Console.ReadKey();
            }

            private void CreateNewMenuItem()
            {
                Console.Clear();
                MenuItem item;
                bool inputIsValid;
                do
                {
                    inputIsValid = true;
                    Console.WriteLine("Are you adding a Food or Beverage?\n" +
                    "1. Food\n" +
                    "2. Beverage");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            item = new MenuItem();
                            break;
                        case "2":
                            item = new MenuItem();
                            break;
                        default:
                            inputIsValid = false;
                            Console.WriteLine("Please enter a valid selection");
                            Console.ReadKey();
                            break;
                    }
                } while (!inputIsValid);
            }

            public void DeleteMenuItem()
            {
                Console.Clear();
                Console.WriteLine("Which item would you like to remove?");

                int index = 0;
            /*foreach (MenuItem item in GetAllMenuItems())
                {
                    Console.WriteLine($"{index + 1}. {item.Title}");
                }
                string optionString = Console.ReadLine();
                int option = Convert.ToInt32(optionString);

            MenuItem itemToDelete = ViewAllMenuItems() [option - 1];
            _repo.DeleteExistingContent(itemToDelete);*/
        }
    }
}

