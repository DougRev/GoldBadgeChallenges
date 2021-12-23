using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Reposiory
{
    public class Claim
    {
        public Claim() { }

        public Claim
            (int claimId,
            string claimType,
            string description,
            double claimAmount,
            DateTime dateOfIncident,
            DateTime dateOfClaim,
            bool isValid)
        {
            ClaimID = claimId;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            bool IsValid = isValid;
        }

        public int ClaimID { get; set; }

        public string ClaimType { get; set;}

        public string Description { get; set; }

        public double ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set;}

        public DateTime DateOfClaim { get; set; }

        public bool IsValid { get; set; }
    }
}
