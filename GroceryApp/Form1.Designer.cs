namespace GroceryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Mongolian Baiti", 27.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Desktop;
            lblTitle.Location = new Point(211, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(387, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Grocery Inventory App";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.InactiveCaption;
            btnAdd.Location = new Point(319, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // bntRemove
            // 
            btnRemove.BackColor = SystemColors.InactiveCaption;
            btnRemove.Location = new Point(321, 204);
            btnRemove.Name = "bntRemove";
            btnRemove.Size = new Size(159, 43);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = SystemColors.InactiveCaption;
            btnDisplay.Location = new Point(321, 290);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(159, 43);
            btnDisplay.TabIndex = 3;
            btnDisplay.Text = "Display Items";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisplay);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnDisplay;
    }
}
