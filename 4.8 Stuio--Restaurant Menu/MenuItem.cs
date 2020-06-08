using System;
using System.Collections.Generic;
using System.Text;

namespace _4._8_Stuio__Restaurant_Menu
{
    public class MenuItem
    {

        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }


        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public Boolean IsThisNew(MenuItem itemInQuestion)
        {
            return IsNew;
        }

        public override Boolean Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem x = toBeCompared as MenuItem;
            return x.Description == Description;
        }
        public void Print()
        {
            Console.WriteLine("****************************");
            Console.WriteLine($" {this.Description} : ${this.Price}");
            Console.WriteLine("****************************");
        }
    }
}
