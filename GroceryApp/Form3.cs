using System;
using System.Windows.Forms;

namespace GroceryApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            PopulateItemDropDown();
        }

        private void PopulateItemDropDown()
        {
            // Populate dropdown with inventory items
            foreach (InventoryItem item in GroceryStore.Instance.Inventory.GetAllItems())
            {
                comboBoxRemoveItems.Items.Add(item.Name);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            try
            {
                // Validate input
                string selectedItemName = comboBoxRemoveItems.SelectedItem.ToString();

                // Find item in inventory
                InventoryItem selectedItem = GroceryStore.Instance.Inventory.GetItemByName(selectedItemName);

                // Remove item from inventory
                if (selectedItem != null)
                {
                    GroceryStore.Instance.Inventory.RemoveItem(selectedItem);

                    // Show success message
                    MessageBox.Show("Item removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear dropdown selection
                    comboBoxRemoveItems.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                ErrorHandler.HandleError(ex);
            }
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            // Close the current form (Form3)
            this.Close();

            // Show the first form (Form1)
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
