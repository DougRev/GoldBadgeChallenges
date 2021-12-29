using Komodo_Badges.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadge.UI
{
    public class ProgramUI
    {
        private readonly BadgeRepository _eRepo = new BadgeRepository();

        public void Run()
        {
            SeedContent();
            RunApplication();
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello Security Admin. What would you like to do?\n" +
                    "1. Add A Badge\n" +
                    "2. View All Badges\n" +
                    "3. Update A Badge\n" +
                    "10. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        ViewAllBadges();
                        break;
                    case "3":
                        UpdateBadge();
                        break;
                    case "10":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1-3.\n");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
        private void AddBadge()
        {
            bool isRunning = false;
            while (!isRunning)
            {
                Console.Clear();
                Badge badge = new Badge();
                Console.WriteLine("Please  enter the Badge Number?\n");
                badge.BadgeID = int.Parse(Console.ReadLine());

                Console.WriteLine("If you would like to add Door Access now press 1\n" +
                    "Or press 2 to exit.");
                var userResponse = int.Parse(Console.ReadLine());
                switch (userResponse)
                {
                    case 1:
                        AddDoorAccess(userResponse);
                        break;
                    case 2:
                        isRunning = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.ReadKey();
            }
        }


        public void AddDoorAccess(int userInput)
        {
            bool hasAddedAllDoors = false;
            while (!hasAddedAllDoors)
            {
                Console.Clear();
                Console.WriteLine("Please enter door name. ");
                var userResponse = Console.ReadLine();
                if (userResponse != null)
                {
                    _eRepo.AddBadgeAccess(userInput, userResponse);
                    Console.WriteLine("Do you want to add another door y/n?");
                    userResponse = Console.ReadLine();
                    if (userResponse == "Y".ToLower())
                    {
                        continue;
                    }
                }
                else
                {
                    hasAddedAllDoors = true;
                }
            }
        Console.ReadKey();
        }
           

        public void DeleteDoorAccess(int userInput)
        {
            bool hasAddedAllDoors = false;
            while (!hasAddedAllDoors)
            {
                Console.Clear();
                Console.WriteLine("Please enter the door name.");
                var userReponse = Console.ReadLine();
                if (userReponse != null)
                {
                    _eRepo.RemoveBadgeAccess(userInput, userReponse);
                    Console.WriteLine("Do you want to remove another room y/n?");
                    userReponse = Console.ReadLine();
                    if(userReponse == "Y".ToLower())
                    {
                        continue;
                    }
                    else
                    {
                        hasAddedAllDoors = true;
                    }
                }
            }
        }


        private void ViewAllBadges()
        {
            Console.Clear();
            Dictionary<int, Badge> badgesMade = _eRepo.GetBadges();
            foreach (var badge in badgesMade)
            {
                ViewBadgeDetails(badge.Value);
            }
        }

        public void ViewBadgeDetails(Badge badge)
        {
            Console.WriteLine($"BadgeNumber: {badge.BadgeID}\n" +
                 $"BadgeAccess: {badge.BadgeAccess}\n" +
                 $"------------------------------------------------\n");
        }

        public void UpdateBadge()
        {
            Console.Clear();

            Console.WriteLine("Please enter Badge ID:");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please make a selection:\n" +
                "1. Add Badge Door Access\n" +
                "2. Remove Badge Door Access\n");

            var userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    AddDoorAccess(userInput);
                    break;
                case 2:
                    DeleteDoorAccess(userInput);
                    break;
                    default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            Console.ReadKey();
        }

        public void SeedContent()
        {
            Badge badgeA = new Badge(1234, new List<string> { "X1, X2, X3, X4" });
            Badge badgeB = new Badge(1234, new List<string> { "Y1, Y2, Y3, Y4" });
            Badge badgeC = new Badge(1234, new List<string> { "Y1, Y2, Y3, Y4, Z1, Z2" });

           
            _eRepo.AddBadgeToDatabase(badgeA);
            _eRepo.AddBadgeToDatabase(badgeB);
            _eRepo.AddBadgeToDatabase(badgeC);
        }
    }
}

