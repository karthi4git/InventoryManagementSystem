using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiBaseUrl = "https://localhost:7286/api/Inventory";

        private ShipmentInventory inventory = new ShipmentInventory();

        public MainForm()
        {
            InitializeComponent();         
        }
   
        private void RefreshGrid()
        {
            dgvShipments.DataSource = inventory.GetShipments();
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtpShipmentDate.Value = DateTime.Now;
        }

        private async void btnAddInventoryItem_ClickAsync(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var shipment = new Shipment
            {
                ProductName = txtProductName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                ShipmentDate = dtpShipmentDate.Value
            };

            if (string.IsNullOrEmpty(txtId.Text))
            {
                inventory.AddShipment(shipment);
            }
            else
            {
                shipment.Id = int.Parse(txtId.Text);
                inventory.UpdateShipment(shipment);
            }

            RefreshGrid();

        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity");
                return false;
            }

            return true;
        }
        private async void btnUpdateInventoryItem_Click(object sender, EventArgs e)
        {
            //shipment.Id = int.Parse(txtId.Text);
            //inventory.UpdateShipment(shipment);
            //if (InventoryDataGrid.CurrentRow == null) return;

            //var selectedItem = (InventoryItem)InventoryDataGrid.CurrentRow.DataBoundItem;
            //var response = await _httpClient.PutAsJsonAsync($"{ApiBaseUrl}/{selectedItem.ItemId}", selectedItem);
            //if (response.IsSuccessStatusCode)
            //    LoadData();

        }

        private async void btnDeleteInventoryItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;

            var result = MessageBox.Show("Are you sure you want to delete this shipment?",
                "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                inventory.DeleteShipment(int.Parse(txtId.Text));
                RefreshGrid();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void dgvShipments_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvShipments.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvShipments.SelectedRows[0];
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                dtpShipmentDate.Value = (DateTime)row.Cells["ShipmentDate"].Value;
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            RefreshGrid();
            dgvShipments.AutoGenerateColumns = false;
        }
    }
}
