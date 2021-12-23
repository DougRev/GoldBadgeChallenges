using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe.Repository
{
    public class MenuItem
    {
        public MenuItem() { }
        
        public MenuItem
            (string title,
            string description,
            double price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}
