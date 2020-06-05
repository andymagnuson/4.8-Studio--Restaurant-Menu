using System;
using System.Collections.Generic;
using System.Text;

namespace _4._8_Stuio__Restaurant_Menu
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; private set; }
        public string Category { get; private set; }

        public MenuItem(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}
