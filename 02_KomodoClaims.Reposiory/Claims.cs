using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Reposiory
{
    public class Claim
    {
        public Claim(string description, ClaimType claimType)
        {
            Description = description;
            ClaimType = claimType;
        }

        public Claim()
        {

        }

        public int ClaimID { get; set; }
        public string Description { get; set; }
        public ClaimType ClaimType { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        
    }
}

