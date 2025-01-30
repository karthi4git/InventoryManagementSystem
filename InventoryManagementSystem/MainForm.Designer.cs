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
            InventoryDataGrid = new DataGridView();
            btnAddInventoryItem = new Button();
            btnUpdateInventoryItem = new Button();
            btnDeleteInventoryItem = new Button();
            btnRefreshInventoryItem = new Button();
            ((System.ComponentModel.ISupportInitialize)InventoryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // InventoryDataGrid
            // 
            InventoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryDataGrid.Location = new Point(0, 0);
            InventoryDataGrid.Name = "InventoryDataGrid";
            InventoryDataGrid.RowHeadersWidth = 62;
            InventoryDataGrid.Size = new Size(800, 356);
            InventoryDataGrid.TabIndex = 0;
            // 
            // btnAddInventoryItem
            // 
            btnAddInventoryItem.Location = new Point(40, 397);
            btnAddInventoryItem.Name = "btnAddInventoryItem";
            btnAddInventoryItem.Size = new Size(112, 34);
            btnAddInventoryItem.TabIndex = 1;
            btnAddInventoryItem.Text = "ADD";
            btnAddInventoryItem.UseVisualStyleBackColor = true;
            btnAddInventoryItem.Click += btnAddInventoryItem_ClickAsync;
            // 
            // btnUpdateInventoryItem
            // 
            btnUpdateInventoryItem.Location = new Point(206, 397);
            btnUpdateInventoryItem.Name = "btnUpdateInventoryItem";
            btnUpdateInventoryItem.Size = new Size(112, 34);
            btnUpdateInventoryItem.TabIndex = 2;
            btnUpdateInventoryItem.Text = "UPDATE";
            btnUpdateInventoryItem.UseVisualStyleBackColor = true;
            btnUpdateInventoryItem.Click += btnUpdateInventoryItem_Click;
            // 
            // btnDeleteInventoryItem
            // 
            btnDeleteInventoryItem.Location = new Point(390, 397);
            btnDeleteInventoryItem.Name = "btnDeleteInventoryItem";
            btnDeleteInventoryItem.Size = new Size(112, 34);
            btnDeleteInventoryItem.TabIndex = 3;
            btnDeleteInventoryItem.Text = "DELETE";
            btnDeleteInventoryItem.UseVisualStyleBackColor = true;
            btnDeleteInventoryItem.Click += btnDeleteInventoryItem_Click;
            // 
            // btnRefreshInventoryItem
            // 
            btnRefreshInventoryItem.Location = new Point(575, 397);
            btnRefreshInventoryItem.Name = "btnRefreshInventoryItem";
            btnRefreshInventoryItem.Size = new Size(112, 34);
            btnRefreshInventoryItem.TabIndex = 4;
            btnRefreshInventoryItem.Text = "REFRESH";
            btnRefreshInventoryItem.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 457);
            Controls.Add(btnRefreshInventoryItem);
            Controls.Add(btnDeleteInventoryItem);
            Controls.Add(btnUpdateInventoryItem);
            Controls.Add(btnAddInventoryItem);
            Controls.Add(InventoryDataGrid);
            Name = "MainForm";
            Text = "InventoryManagement";
            ((System.ComponentModel.ISupportInitialize)InventoryDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView InventoryDataGrid;
        private Button btnAddInventoryItem;
        private Button btnUpdateInventoryItem;
        private Button btnDeleteInventoryItem;
        private Button btnRefreshInventoryItem;
    }
}
