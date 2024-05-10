using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            DisplayInventory();
        }

        private void DisplayInventory()
        {
            // Clear existing items
            listviewDisplay.Items.Clear();

            // Get inventory items by category
            Dictionary<string, List<InventoryItem>> inventoryByCategory = GroceryStore.Instance.Inventory.GetInventoryByCategory();

            // Display inventory items in list view
            foreach (var category in inventoryByCategory)
            {
                foreach (InventoryItem item in category.Value)
                {
                    // Create a ListViewItem for each inventory item
                    ListViewItem listViewItem = new ListViewItem(item.Name);
                    // Add sub-items for each property
                    listViewItem.SubItems.Add(item.Price.ToString()); // Add price
                    listViewItem.SubItems.Add(item.Quantity.ToString()); // Add quantity
                    listViewItem.SubItems.Add(item.Category); // Add category
                                                              // Add the ListViewItem to the ListView
                    listviewDisplay.Items.Add(listViewItem);
                }
            }
        }

        private void btn_back3_Click(object sender, EventArgs e)
        {
            // Close the current form (Form4)
            this.Close();

            // Show the first form (Form1)
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
