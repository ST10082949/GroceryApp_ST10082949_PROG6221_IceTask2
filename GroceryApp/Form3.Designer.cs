
namespace GroceryApp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBoxRemoveItems = new ComboBox();
            lblRemove = new Label();
            btn_back2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Remove Item";
            // 
            // comboBoxRemoveItems
            // 
            comboBoxRemoveItems.FormattingEnabled = true;
            comboBoxRemoveItems.Location = new Point(407, 117);
            comboBoxRemoveItems.Name = "comboBoxRemoveItems";
            comboBoxRemoveItems.Size = new Size(121, 23);
            comboBoxRemoveItems.TabIndex = 1;
            comboBoxRemoveItems.SelectedIndexChanged += comboBoxRemoveItems_SelectedIndexChanged;
            // 
            // lblRemove
            // 
            lblRemove.AutoSize = true;
            lblRemove.Location = new Point(257, 120);
            lblRemove.Name = "lblRemove";
            lblRemove.Size = new Size(101, 15);
            lblRemove.TabIndex = 2;
            lblRemove.Text = "Select to Remove:";
            // 
            // btn_back2
            // 
            btn_back2.Location = new Point(324, 197);
            btn_back2.Name = "btn_back2";
            btn_back2.Size = new Size(145, 52);
            btn_back2.TabIndex = 4;
            btn_back2.Text = "Back";
            btn_back2.UseVisualStyleBackColor = true;
            btn_back2.Click += btn_back2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back2);
            Controls.Add(lblRemove);
            Controls.Add(comboBoxRemoveItems);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        private void comboBoxRemoveItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (comboBoxRemoveItems.SelectedIndex != -1)
            {
                try
                {
                    // Get the selected item
                    string selectedItemName = comboBoxRemoveItems.SelectedItem.ToString();

                    // Find item in inventory
                    InventoryItem selectedItem = GroceryStore.Instance.Inventory.GetItemByName(selectedItemName);

                    // Remove item from inventory
                    GroceryStore.Instance.Inventory.RemoveItem(selectedItem);

                    // Show success message
                    MessageBox.Show("Item removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear dropdown selection
                    comboBoxRemoveItems.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    // Handle errors
                    ErrorHandler.HandleError(ex);
                }
            }
        }


        #endregion

        private Label label1;
        private ComboBox comboBoxRemoveItems;
        private Label lblRemove;
        private Button button1;
        private Button btn_back2;
    }
}