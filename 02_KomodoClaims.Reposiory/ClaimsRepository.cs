using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Reposiory
{
    /*public class ClaimsRepository
    {
        private readonly List<Claim> _claimsDirectory = new List<Claim>();

        private int _count;

        public bool AddAClaim(Claim claim)
        {
            if (claim is null)
            {
                return false;
            }
            else
            {
                _count++;
                claim.ClaimID = _count;
                _claimsDirectory.Add(claim);
                return true;
            }
        }
        public List<Claim> GetClaims()
        {
            return _claimsDirectory;
        }

        public bool DelteClaim(int claimID)
        {
            foreach (var claim in _claimsDirectory)
            {
                if (claim.ClaimID == claimID)
                {
                    _claimsDirectory.Remove(claim);
                    return true;
                }
            }
            return false;
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
        public bool UpdateExistingClaim(int claimId, Claim claim)
        {
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
    }*/
}

