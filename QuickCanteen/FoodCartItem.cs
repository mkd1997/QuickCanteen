using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickCanteen
{    
    public class FoodCartItem
    {
        public string name { get; set; }
        public int qty { get; set; }

        public FoodCartItem()
        {
            name = "_food";
            qty = 0;
        }

        public FoodCartItem(string tname, int tqty)
        {
            name = tname;
            qty = tqty;
        }
    }    
}