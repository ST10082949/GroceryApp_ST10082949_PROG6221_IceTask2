using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp
{
    // Inventory class representing the grocery store inventory
    public class Inventory
    {
        private Dictionary<string, List<InventoryItem>> itemsByCategory;

        public Inventory()
        {
            itemsByCategory = new Dictionary<string, List<InventoryItem>>();
        }

        public void AddItem(InventoryItem item)
        {
            if (!itemsByCategory.ContainsKey(item.Category))
            {
                itemsByCategory[item.Category] = new List<InventoryItem>();
            }
            itemsByCategory[item.Category].Add(item);
        }

        public void RemoveItem(InventoryItem item)
        {
            if (itemsByCategory.ContainsKey(item.Category))
            {
                itemsByCategory[item.Category].Remove(item);
            }
        }
       

        public Dictionary<string, List<InventoryItem>> GetInventoryByCategory()
        {
            return itemsByCategory;
        }

        public IEnumerable<InventoryItem> GetAllItems()
        {
            List<InventoryItem> allItems = new List<InventoryItem>();

            foreach (var categoryList in itemsByCategory.Values)
            {
                allItems.AddRange(categoryList);
            }

            return allItems;
        }

        public InventoryItem GetItemByName(string selectedItemName)
        {
            foreach (var categoryList in itemsByCategory.Values)
            {
                foreach (var item in categoryList)
                {
                    if (item.Name == selectedItemName)
                    {
                        return item;
                    }
                }
            }

            return null; // If item not found
        }

    }
}

