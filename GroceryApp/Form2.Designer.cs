namespace GroceryApp
{
    partial class Form2
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
            lblName = new Label();
            lblPrice = new Label();
            txtBoxName = new TextBox();
            textBoxPrice = new TextBox();
            lblQuantity = new Label();
            lblCategories = new Label();
            numericUpDownQuantity = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            lblAddTitle = new Label();
            btnAdd = new Button();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(273, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(69, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Item Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(273, 205);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(441, 138);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(121, 23);
            txtBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(441, 197);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(121, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(273, 265);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(276, 342);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(66, 15);
            lblCategories.TabIndex = 5;
            lblCategories.Text = "Categories:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(442, 257);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 23);
            numericUpDownQuantity.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { " fruits", "vegetables", "dairy", "meat", "bakery" });
            comboBoxCategory.Location = new Point(442, 334);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 7;
            // 
            // lblAddTitle
            // 
            lblAddTitle.AutoSize = true;
            lblAddTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAddTitle.Location = new Point(326, 39);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(175, 37);
            lblAddTitle.TabIndex = 8;
            lblAddTitle.Text = "Add an Item";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(341, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(482, 397);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(88, 23);
            btn_back.TabIndex = 10;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Controls.Add(btnAdd);
            Controls.Add(lblAddTitle);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(lblCategories);
            Controls.Add(lblQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(txtBoxName);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private TextBox txtBoxName;
        private TextBox textBoxPrice;
        private Label lblQuantity;
        private Label lblCategories;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox comboBoxCategory;
        private Label lblAddTitle;
        private Button btnAdd;
        private Button btn_back;
    }
}