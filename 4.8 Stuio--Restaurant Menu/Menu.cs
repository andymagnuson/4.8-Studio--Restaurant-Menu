using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _4._8_Stuio__Restaurant_Menu
{
   public class Menu
    {
        public string MenuName;
        public List<MenuItem> FoodOptions { get; set; }
  
        public DateTime LastUpdated { get; set; }

        public Menu(string menuName, List<MenuItem> foodOptions)
        {
            MenuName = menuName;
            FoodOptions = foodOptions;
            LastUpdated = DateTime.Now;
        }

        // public class Menus : IEnumerable
        //  {

        // }
        public void AddItem(MenuItem newItem)
        {
            int temp = 1;
            List<MenuItem> listOfItems = this.FoodOptions;
            foreach (MenuItem i in listOfItems)
            {
                if (newItem.Equals(i) == true)
                {
                    temp = temp * (-1);
                }
            }
                if (temp > 0)
                {
                    this.FoodOptions.Add(newItem);
                    LastUpdated = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("Item is already on the Menu");
                }
           

        }

        public void RemoveItem(MenuItem oldItem)
        {
            FoodOptions.Remove(oldItem);
            LastUpdated = DateTime.Now;
        }
        public void Print()
        {
            int i = 1;
            List<MenuItem> listedItems = this.FoodOptions;
            foreach (MenuItem item in listedItems)
            {
                
                Console.WriteLine("****************************");
                Console.WriteLine($"{ i} ) {item.Description} : $:{item.Price}");
                Console.WriteLine("****************************");
                Console.WriteLine();
                i++;
            }
        }

        public void Print2()
        {
            foreach (MenuItem item in FoodOptions)
            {
                Console.WriteLine("****************************");
                Console.WriteLine($") {item.Description} : $:{item.Price}");
                Console.WriteLine("****************************");
                Console.WriteLine();
            }
        }

       
    }
}
