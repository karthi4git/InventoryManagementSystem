using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace InventoryManagementSystem
{
    public partial class AddInventoryItem : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiBaseUrl = "https://localhost:7286/api/Inventory";
        private MainForm _parentForm;
        public AddInventoryItem(MainForm mainForm)
        {
            InitializeComponent();
            _parentForm = mainForm;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid data for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
  
      
            var newitem = new InventoryItem
            {
                ItemId = Convert.ToInt16( txtItemId.Text),
                Name =txtName.Text,
                Quantity = Convert.ToInt16(txtQuantity.Text),
                Price = Convert.ToDecimal(txtPrice.Text),
            };
            var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, newitem);
            if (response.IsSuccessStatusCode)
                _parentForm.LoadData();

            // Close Form2 after saving
            this.Close();
        }
    }
    }

