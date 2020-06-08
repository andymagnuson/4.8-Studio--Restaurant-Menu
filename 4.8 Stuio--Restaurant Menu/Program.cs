using System;
using System.Collections.Generic;

namespace _4._8_Stuio__Restaurant_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem beans = new MenuItem(3.50, "Beans, full of fiber", "Main Course", false);
            MenuItem burger = new MenuItem(8.50,"Hamburger, Stand Beef", "Main Course", true);
            MenuItem chocCake = new MenuItem(4.75,"Chocolate Cake",  "Dessert", false);
            List<MenuItem> testItems = new List<MenuItem>();
            testItems.Add(beans);
            testItems.Add(burger);
            testItems.Add(chocCake);
            Menu sampleMenu = new Menu("First Menu", testItems);

            Console.WriteLine(sampleMenu.MenuName);
            Console.WriteLine(sampleMenu.FoodOptions[0].Description);
            Console.WriteLine(testItems[0].Price);
            Console.WriteLine(testItems[1].Price);
            sampleMenu.AddItem(burger);
            Console.WriteLine(sampleMenu.FoodOptions.Count);
            Console.WriteLine(sampleMenu.LastUpdated);

            sampleMenu.Print();
            beans.Print();
            Console.WriteLine(beans.Equals(beans));
            Console.WriteLine(beans.Equals(burger));
           sampleMenu.AddItem(beans);
         
            {

            }
        }
    }
}
