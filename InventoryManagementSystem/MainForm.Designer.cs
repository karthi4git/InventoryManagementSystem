namespace InventoryManagementSystem
{
    partial class MainForm
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
            dgvShipments = new DataGridView();
            btnAddInventoryItem = new Button();
            btnUpdateInventoryItem = new Button();
            btnDeleteInventoryItem = new Button();
            btnClear = new Button();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblName = new Label();
            lblItemId = new Label();
            txtId = new TextBox();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            dtpShipmentDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
            SuspendLayout();
            // 
            // dgvShipments
            // 
            dgvShipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipments.Location = new Point(22, 242);
            dgvShipments.Name = "dgvShipments";
            dgvShipments.RowHeadersWidth = 62;
            dgvShipments.Size = new Size(945, 326);
            dgvShipments.TabIndex = 0;
            dgvShipments.SelectionChanged += dgvShipments_SelectionChanged_1;
            // 
            // btnAddInventoryItem
            // 
            btnAddInventoryItem.Location = new Point(127, 589);
            btnAddInventoryItem.Name = "btnAddInventoryItem";
            btnAddInventoryItem.Size = new Size(112, 34);
            btnAddInventoryItem.TabIndex = 1;
            btnAddInventoryItem.Text = "Add";
            btnAddInventoryItem.UseVisualStyleBackColor = true;
            btnAddInventoryItem.Click += btnAddInventoryItem_ClickAsync;
            // 
            // btnUpdateInventoryItem
            // 
            btnUpdateInventoryItem.Location = new Point(293, 589);
            btnUpdateInventoryItem.Name = "btnUpdateInventoryItem";
            btnUpdateInventoryItem.Size = new Size(112, 34);
            btnUpdateInventoryItem.TabIndex = 2;
            btnUpdateInventoryItem.Text = "Update";
            btnUpdateInventoryItem.UseVisualStyleBackColor = true;
            btnUpdateInventoryItem.Click += btnUpdateInventoryItem_Click;
            // 
            // btnDeleteInventoryItem
            // 
            btnDeleteInventoryItem.Location = new Point(477, 589);
            btnDeleteInventoryItem.Name = "btnDeleteInventoryItem";
            btnDeleteInventoryItem.Size = new Size(112, 34);
            btnDeleteInventoryItem.TabIndex = 3;
            btnDeleteInventoryItem.Text = "Delete";
            btnDeleteInventoryItem.UseVisualStyleBackColor = true;
            btnDeleteInventoryItem.Click += btnDeleteInventoryItem_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(662, 589);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(295, 198);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(295, 145);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(125, 25);
            lblPrice.TabIndex = 15;
            lblPrice.Text = "ShipmentDate";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(295, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 25);
            lblName.TabIndex = 14;
            lblName.Text = "ProductName";
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Location = new Point(295, 32);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(64, 25);
            lblItemId.TabIndex = 13;
            lblItemId.Text = "ItemId";
            // 
            // txtId
            // 
            txtId.Location = new Point(439, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 12;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(439, 84);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(439, 195);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 9;
            // 
            // dtpShipmentDate
            // 
            dtpShipmentDate.ImeMode = ImeMode.Off;
            dtpShipmentDate.Location = new Point(439, 145);
            dtpShipmentDate.Name = "dtpShipmentDate";
            dtpShipmentDate.Size = new Size(293, 31);
            dtpShipmentDate.TabIndex = 17;
            dtpShipmentDate.Value = new DateTime(2025, 3, 5, 22, 27, 1, 0);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 630);
            Controls.Add(dtpShipmentDate);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblItemId);
            Controls.Add(txtId);
            Controls.Add(txtProductName);
            Controls.Add(txtQuantity);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteInventoryItem);
            Controls.Add(btnUpdateInventoryItem);
            Controls.Add(btnAddInventoryItem);
            Controls.Add(dgvShipments);
            Name = "MainForm";
            Text = "InventoryManagement";
            Load += MainForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShipments;
        private Button btnAddInventoryItem;
        private Button btnUpdateInventoryItem;
        private Button btnDeleteInventoryItem;
        private Button btnClear;
        private Label lblQuantity;
        private Label lblPrice;
        private Label lblName;
        private Label lblItemId;
        private TextBox txtId;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private DateTimePicker dtpShipmentDate;
    }
}
