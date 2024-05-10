using System;

namespace GroceryApp
{
    public class GroceryStore
    {
        public Inventory Inventory { get; }
        public static GroceryStore Instance { get; } = new GroceryStore();

        private GroceryStore()
        {
            Inventory = new Inventory();
        }
    }
}
