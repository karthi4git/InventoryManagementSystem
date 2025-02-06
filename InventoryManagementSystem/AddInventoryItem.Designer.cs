namespace InventoryManagementSystem
{
    partial class AddInventoryItem
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
            panel1 = new Panel();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblName = new Label();
            lblItemId = new Label();
            txtItemId = new TextBox();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblItemId);
            panel1.Controls.Add(txtItemId);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtPrice);
            panel1.Location = new Point(53, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 268);
            panel1.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(104, 209);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(104, 156);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(104, 98);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new Point(104, 43);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(64, 25);
            lblItemId.TabIndex = 5;
            lblItemId.Text = "ItemId";
            lblItemId.Visible = false;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(248, 40);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(150, 31);
            txtItemId.TabIndex = 4;
            txtItemId.Visible = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(248, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(248, 206);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(248, 153);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(329, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(156, 360);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddInventoryItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Name = "AddInventoryItem";
            Text = "AddInventoryItem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblName;
        private Label lblItemId;
        private TextBox txtItemId;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnCancel;
        private Button btnSubmit;
    }
}