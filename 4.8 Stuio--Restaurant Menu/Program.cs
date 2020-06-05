using System;
using System.Collections.Generic;

namespace _4._8_Stuio__Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem beans = new MenuItem("Beans", "full of fiber", 3.50, "Main Course");
            MenuItem burger = new MenuItem("Hamburger", "Stand Beef", 8.50, "Main Course");
            MenuItem chocCake = new MenuItem("Chocolate Cake", "German Chocolate", 4.70, "Dessert");
            List<MenuItem> testItems = new List<MenuItem>();
            testItems.Add(beans);
            testItems.Add(burger);
            testItems.Add(chocCake);
            Menu sampleMenu = new Menu("First Menu", testItems);

            Console.WriteLine(sampleMenu.MenuName);
            Console.WriteLine(sampleMenu.LastUpdated);
            Console.WriteLine(testItems[0].Price);
            Console.WriteLine(testItems[1].Name);
         
            {

            }
        }
    }
}
