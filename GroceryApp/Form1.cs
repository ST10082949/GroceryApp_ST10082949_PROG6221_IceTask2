using System;
using System.Windows.Forms;
using GroceryApp;


namespace GroceryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 addItemForm = new Form2();
            addItemForm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form3 removeItemForm = new Form3();
            removeItemForm.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Form4 displayInventoryForm = new Form4();
            displayInventoryForm.ShowDialog();
        }
    }
}
