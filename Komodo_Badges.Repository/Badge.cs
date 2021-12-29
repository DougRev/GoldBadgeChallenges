using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Badges.Repository
{
    public class Badge
    {
        public Badge(int badgeID, List<string> badgeAccess)
        {
            BadgeID = badgeID;
            BadgeAccess = badgeAccess;
        }

        public Badge()
        {

        }

        public int BadgeID { get; set; }
        public AccessType AccessType { get; set; }
        public List<string> BadgeAccess { get; set; } = new List<string>();

        
    }
}
