
namespace GroceryApp
{
    partial class Form4
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
            lblDisplayTitle = new Label();
            listviewDisplay = new ListView();
            btn_back3 = new Button();
            SuspendLayout();
            // 
            // lblDisplayTitle
            // 
            lblDisplayTitle.AutoSize = true;
            lblDisplayTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblDisplayTitle.Location = new Point(320, 34);
            lblDisplayTitle.Name = "lblDisplayTitle";
            lblDisplayTitle.Size = new Size(144, 32);
            lblDisplayTitle.TabIndex = 0;
            lblDisplayTitle.Text = "Display List";
            // 
            // listviewDisplay
            // 
            listviewDisplay.Location = new Point(202, 81);
            listviewDisplay.Name = "listviewDisplay";
            listviewDisplay.Size = new Size(414, 204);
            listviewDisplay.TabIndex = 1;
            listviewDisplay.UseCompatibleStateImageBehavior = false;
            listviewDisplay.SelectedIndexChanged += listviewDisplay_SelectedIndexChanged;
            // 
            // btn_back3
            // 
            btn_back3.Location = new Point(371, 313);
            btn_back3.Name = "btn_back3";
            btn_back3.Size = new Size(75, 23);
            btn_back3.TabIndex = 2;
            btn_back3.Text = "Back";
            btn_back3.UseVisualStyleBackColor = true;
            btn_back3.Click += btn_back3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(829, 436);
            Controls.Add(btn_back3);
            Controls.Add(listviewDisplay);
            Controls.Add(lblDisplayTitle);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        private void listviewDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected
            if (listviewDisplay.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listviewDisplay.SelectedItems[0];

                // Access item details from ListViewItem
                string name = selectedItem.Text; // First column
                string price = selectedItem.SubItems[1].Text; // Second column
                string quantity = selectedItem.SubItems[2].Text; // Third column
                string category = selectedItem.SubItems[3].Text; // Fourth column

                // Display item details or perform any other action
                MessageBox.Show($"Name: {name}\nPrice: {price}\nQuantity: {quantity}\nCategory: {category}", "Selected Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        private Label lblDisplayTitle;
        private ListView listviewDisplay; // This line declares the ListView control
        private Button btn_back3;
    }
}
