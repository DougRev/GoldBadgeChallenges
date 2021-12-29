using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaims.Reposiory
{
    public class Claims_Queue_Repo
    {
        private readonly Queue<Claim> _claimQueue = new Queue<Claim>();
        private int _count;

        public bool AddClaimToQueue(Claim claim)
        {
            if (claim == null)
            {
                return false;
            }

            _count++;
            claim.ClaimID = _count;
            _claimQueue.Enqueue(claim);
            return true;
        }

        public Queue<Claim> GetClaims()
        {
            return _claimQueue;
        }

        public Claim PeekQueue()
        {
            if (_claimQueue.Count > 0)
            {
                return _claimQueue.Peek();
            }
            return null;
        }

        public bool RemoveFromQueue()
        {
            if (_claimQueue.Count > 0)
            {
                _claimQueue.Dequeue();
                return true;
            }
            return false;
        }
    }
}
