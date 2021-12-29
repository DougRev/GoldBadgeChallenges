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
        private readonly Claims_Queue_Repo _claimRepo = new Claims_Queue_Repo();
        //private readonly ClaimsRepository _claimsRepository = new ClaimsRepository();

        public void Run()
        {
            SeedContent();
            OpeningMenu();
        }

        public void OpeningMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu item: \n" +
                "1. See all claims \n" +
                "2. Take care of next claim \n" +
                "3. Enter a new claim \n" +
                "10. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ViewAllClaims();
                        break;
                    case "2":
                        TakeCareOfNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "10":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Number Between 1-3.\n" +
                            "Press any key to continue......");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

        public void TakeCareOfNextClaim()
        {
            Console.Clear();
            {
                SeeNextInQueue();
            }
        }

        public void SeeNextInQueue()
        {
            Console.Clear();
            Claim seeNext = _claimRepo.PeekQueue();
            {
            
            }
           
            
        }
        public void ViewAllClaims()
        {
            Console.Clear();
            Queue<Claim> viewAllClaims = _claimRepo.GetClaims();
            foreach (var claim in viewAllClaims)
            {
                DisplayClaimDetails(claim);
            }
            Console.ReadKey();
        }

        private void DisplayClaimDetails(Claim claim)
        {
            Console.WriteLine($"Claim.ClaimType: {claim.ClaimType}\n" +
                $"Claim.Description: {claim.Description}\n" +
                $"Claim.ClaimAmount: {claim.ClaimAmount}\n" +
                $"Claim.DateOfIncident: {claim.DateOfIncident}\n" +
                $"Claim.DateOfClaim: {claim.DateOfClaim}\n" +
                $"----------------------------------------\n");
        }
        public void CreateNewClaim()
        {
            Console.Clear();
            Claim claim = new Claim();

            Console.WriteLine("What is the ClaimType?\n" +
             "1.Car\n" +
             "2.Home\n" +
             "3.Theft");

            int claimType = int.Parse(Console.ReadLine());
            claim.ClaimType = (ClaimType)claimType;

            Console.WriteLine("What is the Claim ID?");
            int claimID = int.Parse(Console.ReadLine());

            Console.WriteLine("Write the Description here:");
            string description = Console.ReadLine();
            claim.Description = description;

            Console.WriteLine("What is the Claim Amount?");
            double claimAmount = int.Parse(Console.ReadLine());
            claim.ClaimAmount = claimAmount;

            Console.WriteLine("What is the Date of Incident(YYYY,MM,DD)?");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());
            claim.DateOfIncident = dateOfIncident;

            Console.WriteLine("What is the Date of Claim?(YYYY,MM,DD)");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());
            claim.DateOfClaim = dateOfClaim;

            bool success = _claimRepo.AddClaimToQueue(claim);
            if (success)
            {
                Console.WriteLine($"{claim.ClaimID} has been added to the database");
            }
            else
            {
                Console.WriteLine("Claim was not added to the database");
            }
            Console.ReadKey();
        }

        private void SeedContent()
        {
           Claim claimA = new Claim("Fender Bender", ClaimType.Car);
           Claim claimB = new Claim("Flooded Basement", ClaimType.Home);
           Claim claimC = new Claim("Home Robbery", ClaimType.Theft);
            _claimRepo.AddClaimToQueue(claimA);
            _claimRepo.AddClaimToQueue(claimB);
            _claimRepo.AddClaimToQueue(claimC);
            
        }
    }
}
           