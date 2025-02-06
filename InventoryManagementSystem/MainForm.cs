using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiBaseUrl = "https://localhost:7286/api/Inventory";
        public List<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        public async void LoadData()
        {
            InventoryItems = await _httpClient.GetFromJsonAsync<List<InventoryItem>>(ApiBaseUrl);
            InventoryDataGrid.DataSource = InventoryItems;
            InventoryDataGrid.Columns[0].ReadOnly = true;
        }

        private async void btnAddInventoryItem_ClickAsync(object sender, EventArgs e)
        {
            AddInventoryItem addForm = new AddInventoryItem(this);

            addForm.ShowDialog();
        }

        private async void btnUpdateInventoryItem_Click(object sender, EventArgs e)
        {
            if (InventoryDataGrid.CurrentRow == null) return;

            var selectedItem = (InventoryItem)InventoryDataGrid.CurrentRow.DataBoundItem;
            var response = await _httpClient.PutAsJsonAsync($"{ApiBaseUrl}/{selectedItem.ItemId}", selectedItem);
            if (response.IsSuccessStatusCode)
                LoadData();

        }

        private async void btnDeleteInventoryItem_Click(object sender, EventArgs e)
        {
            if (InventoryDataGrid.CurrentRow == null) return;

            var selectedItem = (InventoryItem)InventoryDataGrid.CurrentRow.DataBoundItem;
            var response = await _httpClient.DeleteAsync($"{ApiBaseUrl}/{selectedItem.ItemId}");
            if (response.IsSuccessStatusCode)
                LoadData();

        }

        private void btnRefreshInventoryItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
