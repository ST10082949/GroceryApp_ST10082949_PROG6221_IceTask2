using System;
using System.Windows.Forms;
using GroceryApp;


namespace GroceryApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                string name = txtBoxName.Text;
                double price = Convert.ToDouble(textBoxPrice.Text); // Convert text to double
                int quantity = (int)numericUpDownQuantity.Value;
                string category = comboBoxCategory.SelectedItem.ToString();

                // Create new InventoryItem
                InventoryItem newItem = new InventoryItem(name, price, quantity, category);

                // Add item to inventory
                GroceryApp.GroceryStore.Instance.Inventory.AddItem(newItem);

                // Show success message
                MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear input fields
                txtBoxName.Clear();
                textBoxPrice.Clear();
                numericUpDownQuantity.Value = 0;
                comboBoxCategory.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                // Handle errors
                ErrorHandler.HandleError(ex);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Close the current form (Form2)
            this.Close();

            // Show the first form (Form1)
            Form1 form1 = new Form1();
            form1.Show();
        }

    }
}
