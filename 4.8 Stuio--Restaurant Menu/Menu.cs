using System;
using System.Collections.Generic;
using System.Text;

namespace _4._8_Stuio__Restaurant_Menu
{
   public class Menu
    {
        public string MenuName;
        private List<MenuItem> foodOptions;
        public List<MenuItem> Update()
        {
            LastUpdated = DateTime.Now;
            return foodOptions;
        }
        public DateTime LastUpdated { get; set; }

        public Menu(string menuName, List<MenuItem> listOfItems)
        {
            MenuName = menuName;
            foodOptions = listOfItems;
            LastUpdated = DateTime.Now;
        }
       
    }
}
