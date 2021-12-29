using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Badges.Repository
{
    public class BadgeRepository
    {
        private readonly Dictionary<int, Badge> _badgeDatabase = new Dictionary<int, Badge>();
        private int _count;

        public bool AddBadgeToDatabase(Badge badge)
        {
            if (badge == null)
            {
                return false;
            }
            else
            {
                _count++;
                badge.BadgeID = _count;
                _badgeDatabase.Add(badge.BadgeID, badge);
                return true;
            }
        }

        public Dictionary<int, Badge> GetBadges()
        {
            return _badgeDatabase;
        }

        public Badge GetBadgebyID(int badgeID)
        {
            foreach (var badge in _badgeDatabase)
            {
                if (badge.Key == badgeID)
                {
                    return badge.Value;
                }
            }
            return null;
        }

        public bool AddBadgeAccess(int key, string doorName)
        {
            var badge = GetBadgebyID(key);
            if (badge != null)
            {
                badge.BadgeAccess.Add(doorName);
                return true;
            }

            return false;
        }

        public bool RemoveBadgeAccess(int key, string doorName)
        {
            Badge badge = GetBadgebyID(key);
            if (badge != null)
            {
                foreach (var door in badge.BadgeAccess)
                {
                    if (door == doorName)
                    {
                        badge.BadgeAccess.Remove(door);
                        return true;
                    }
                }
                
            }
            return false;
        }

        public bool RemoveBadge(int key)
        {
            foreach (var badge in _badgeDatabase)
            {
                if (badge.Key ==key)
                {
                    _badgeDatabase.Remove(badge.Key);
                    return true;
                }
            } return false;
        }

    }
}
