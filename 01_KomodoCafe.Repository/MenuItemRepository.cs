using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    public class MenuItemRepository
    {
        protected readonly List<MenuItem> _menuItems = new List<MenuItem>();

        public bool AddMenuItem(MenuItem items)
        {
            int startingcount = _menuItems.Count;
            _menuItems.Add(items);

            bool wasAdded = (_menuItems.Count > startingcount);
            return wasAdded;
        }

        public List<MenuItem> ViewAllMenuItems()
        {
            return _menuItems;
        }

        public bool DeleteMenuItem(MenuItem existingitem)
        {
            bool deleteResult = _menuItems.Remove(existingitem);
            return deleteResult;
        }
    }
}
