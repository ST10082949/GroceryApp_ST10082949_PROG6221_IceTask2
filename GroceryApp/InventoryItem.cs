using System;
using System.Collections.Generic;
using System.Linq;



namespace GroceryApp
{
        public class InventoryItem
        {
            // Properties and methods of the InventoryItem class
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; }

            // Constructor
            public InventoryItem(string name, double price, int quantity, string category)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Category = category;
            }
        }
    }
