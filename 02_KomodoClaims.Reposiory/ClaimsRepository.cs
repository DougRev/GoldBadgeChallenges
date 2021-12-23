using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Reposiory
{
    public class ClaimsRepository
    {
        private readonly List<Claim> _claimsDirectory = new List<Claim>();

        public bool AddAClaim(Claim claim)
        {
            int startingcount = _claimsDirectory.Count;
            _claimsDirectory.Add(claim);

            bool wasAdded = (_claimsDirectory.Count > startingcount);
            return wasAdded;
        }

        public List<Claim> ViewAllClaims()
        {
            return _claimsDirectory;
        }

        public Claim GetClaimbyID(int claimId)
        {
            foreach (Claim claim in _claimsDirectory)
                if (claim.ClaimID == claimId)
                {
                    return claim;
                }
            return null;
        }
        //Update.
        public bool UpdateExistingClaim(int claimId, Claim claim)
        {
            //find the old content...
            Claim oldClaim = GetClaimbyID(claimId);

            if (oldClaim != null)
            {
                oldClaim.ClaimID = claim.ClaimID;
                oldClaim.Description = claim.Description;
                oldClaim.ClaimType = claim.ClaimType;
                oldClaim.ClaimAmount = claim.ClaimAmount;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool DeleteClaim(Claim existingclaim)
        {
            bool deleteResult = _claimsDirectory.Remove(existingclaim);
            return deleteResult;
        }
    }
}
