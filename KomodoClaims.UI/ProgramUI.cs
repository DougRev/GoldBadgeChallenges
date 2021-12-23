using _02_KomodoClaims.Reposiory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaims.UI
{
    public class ProgramUI
    {

        public ProgramUI()
        {

        }
        public void Run()
        {
            OpeningMenu();
            /*SeedContent();*/
        }

        public void OpeningMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Choose a menu item: \n" +
                "1. See all claims \n" +
                "2. Take care of next claim \n" +
                "3. Enter a new claim \n" +
                "4. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        NextInQueue();
                        break;
                    case "3":
                        CreateNewClaim();
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
        public void NextInQueue()
        {
            Console.WriteLine("ClaimID, Type, Description, Amount, DateOfAccident, DateOfClaim, IsValid");
        }

        public void ViewAllClaims()
        {
            Console.WriteLine("AllClaimsShowHERE.");
        }
        public void CreateNewClaim()
        {
            Console.Clear();
            Claim claim;
            bool inputIsValid;
            do
            {
                inputIsValid = true;
                Console.WriteLine("What is the ClaimType?\n" +
                    "1. Car\n" +
                    "2. Home\n" +
                    "3. Theft");
                string claimtype = Console.ReadLine();
                switch (claimtype)
                {
                    case "1":
                        claim = new Claim();
                        break;
                    case "2":
                        claim = new Claim();
                        break;
                    case "3":
                        claim = new Claim();
                        break;
                    default:
                        inputIsValid = false;
                        Console.WriteLine("Please enter a Number between 1-3");
                        Console.ReadKey();
                        break;
                }
            Console.WriteLine("What is the Claim ID?");
            string claimID = Console.ReadLine();

            Console.WriteLine("Write the Description here:");
            string description = Console.ReadLine();

            Console.WriteLine("What is the Claim Amount?");
            string claimAmount = Console.ReadLine();

            Console.WriteLine("What is the Date of Incident?");
            string dateofinc = Console.ReadLine();

            Console.WriteLine("What is the Date of Claim?");
            string dateofclaim = Console.ReadLine();
                break;
                Console.ReadKey();

            } while (inputIsValid);

        }

        public void SeedContent()
        {
            // Make some movies and shows, add them to the repo
            Claim carclaim = new Claim();
            carclaim.ClaimID = 1510;
            carclaim.Description = "Mr Simpson was in a fender bender accident at a red light.";
            carclaim.ClaimAmount = 12000;
            carclaim.DateOfIncident = DateTime.Now;
            carclaim.DateOfClaim = DateTime.Now;

            Claim homeclaim = new Claim();
            homeclaim.ClaimID = 2525;
            homeclaim.Description = "Mr Squarepants reported significants amount of water damage due to a leak in the roof.";
            homeclaim.ClaimAmount = 23402;
            homeclaim.DateOfIncident = DateTime.Now;
            homeclaim.DateOfClaim = DateTime.Now;

            Claim theftclaim = new Claim();
            theftclaim.ClaimID = 42;
            theftclaim.Description = "Mrs Clause reported a break in at her North Pole home with significant amount of stolen goods.";
            theftclaim.ClaimAmount = 450000;
            theftclaim.DateOfIncident = DateTime.Now;
            theftclaim.DateOfClaim = DateTime.Now;
        }
    }
           
 
 /*private readonly IConsole _console;
        private readonly StreamingRepository _repo = new StreamingRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContent();
            ShowMenu();
        }

        private void DisplayContentListItem(StreamingContent content)
        {
            Console.WriteLine($"{content.Title} ({content.GetType().Name})\n" +
                $"================================");
        }

        private void DisplayContentItemDetails(StreamingContent content)
        {
            Console.WriteLine($"={content.GetType().Name}=\n" +
                $"Title: {content.Title}/n" +
                $"Description: {content.Description}\n" +
                $"Star Rating: {content.StarRating}\n" +
                $"Genre: {content.TypeOfGenre}" +
                $"{content is Movie ? "RunTime" + ((Movie) content).RunTime + "\n" : "")}" +
                $"================================");
        }
        private void WaitForKeyPress()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        private void ShowMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {

                Console.Clear();
                Console.WriteLine(
                    "Enter the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new content\n" +
                    "4. Remove content item\n" +
                    "5. Exit\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowAllContentByTitle();
                        break;
                    case "3":
                        CreateNewContent();
                        break;
                    case "4":
                        RemoveContent();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-5\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }
        }

        // Menu options refer to methods...
        private void ShowAllContent()
        {
            Console.WriteLine("Streaming content available:");
            List<StreamingContent> content = _repo.GetAllContents();
            foreach (StreamingContent item in content)
            {
                DisplayContentItem(item);
            }

            WaitForKeyPress();
        }


        private void ShowAllContentByTitle()
        {
            Console.Clear();
            Console.Write("Pleaes enter a title: ");
            string title = Console.ReadLine();
            StreamingContent item = _repo.GetContentByTitle(title);

            if (item == null)
            {
                Console.WriteLine("Item not found :(");

            }
            else
            {
                DisplayContentItem(item);
            }
            WaitForKeyPress();
        }

        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent content;
            bool inputIsValid;
            do
            {
                inputIsValid = true;
                Console.WriteLine("Is this a Movie or a Show?\n" +
                "1. Movie\n" +
                "2. Show");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        content = new Movie();
                        break;
                    case "2":
                        content = new Show();
                        break;
                    default:
                        inputIsValid = false;
                        Console.WriteLine("Please enter a valid selection");
                        WaitForKeyPress();
                        break;
                }
            } while (!inputIsValid);
        }

        private void RemoveContent()
        {
            Console.Clear();
            Console.WriteLine("Which item would you like to removve?");

            int index = 0;
            foreach (StreamingContent item in _repo.GetAllContents())
            {
                Console.WriteLine($"{index + 1}. {item.Title}");
                index++;
            }
            string optionString = Console.ReadLine();
            int option = Convert.ToInt32(optionString);

            StreamingContent itemToDelete = _repo.GetAllContents()[option - 1];
            _repo.DeleteExistingContent(itemToDelete);
        }
    private void SeedContent()
    {

        // Make some movies and shows, add them to the repo
        Movie futureWar = new Movie();
        futureWar.Title = "Future War";
        futureWar.Description = "Jean-Claude fights dinosaurs.";
        futureWar.TypeOfGenre = GenreType.SciFi;
        _repo.AddContentToDirectory(futureWar);

        Movie stepbrothers = new Movie();
        stepbrothers.Title = "Step Brothers";
        stepbrothers.Description = "Will Ferrel and John C Rieley are super funny.";
        stepbrothers.TypeOfGenre = GenreType.RomCom;
        _repo.AddContentToDirectory(stepbrothers);*/
 }