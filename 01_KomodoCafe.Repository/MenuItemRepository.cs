using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    public class MenuItemRepository
    {
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        private int _count;
        public bool AddNewMenuItem(MenuItem item)
        {
            if (item is null)
            {
                return false;
            }
            else
            {
                _count++;
                item.MealNumber = _count;
                _menuItems.Add(item);
                return true;
            }
        }
        public List<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        public bool DeleteMenuItem(string mealName)
        {
            foreach (var item in _menuItems)
            {
                if (item.MealName == mealName)
                {
                    _menuItems.Remove(item);
                    return true;
                }
            }
            return false;
        }

    }
}
