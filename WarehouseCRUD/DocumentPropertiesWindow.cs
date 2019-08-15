using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseCRUD.Objects;

namespace WarehouseCRUD
{
    public partial class DocumentPropertiesWindow : Form
    {
        private readonly WareHouseDocument _wareHouseDocument;
        private readonly DBService _dBService = new DBService();
        public DocumentPropertiesWindow(WareHouseDocument wareHouseDocument)
        {
            InitializeComponent();
            this._wareHouseDocument = wareHouseDocument;
            CreateButton.Enabled = false;
        }

        public DocumentPropertiesWindow()
        {
            InitializeComponent();
            this._wareHouseDocument = new WareHouseDocument();
            this._wareHouseDocument.Items = new List<Item>();
            UpdateButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void PropertiesWindow_Load(object sender, EventArgs e)
        {
            ItemsListBox.DoubleClick += ItemsListBox_DoubleClick;
            SetValues();
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                var selectedItem = ItemsListBox.SelectedItem as Item;
                _wareHouseDocument.Items.Remove(selectedItem);
                SetValues();
            }
        }

        private void SetValues()
        {
            CreatedDataLabel.Text = _wareHouseDocument?.Created.ToString();
            ClientNumberTextBox.Text = _wareHouseDocument?.ClientNumber.ToString();
            DocumenNameTextBox.Text = _wareHouseDocument?.DocumentName;
            SumNettoDataLabel.Text = _wareHouseDocument?.Items?.Sum(x => x.NettoPrice * x.Amount).ToString();
            SumBruttoDataLabel.Text = _wareHouseDocument?.Items?.Sum(x => x.BruttoPrice * x.Amount).ToString();
            ItemsListBox.DisplayMember = "PublicName";
            ItemsListBox.DataSource = _wareHouseDocument?.Items?.ToList();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            WareHouseDocument NewWareHouseDocument = new WareHouseDocument()
            {
                WareHouseDocumentId = Guid.NewGuid(),
                ClientNumber = Int32.TryParse(ClientNumberTextBox.Text, out int result) ? result : 0,
                Created = DateTime.UtcNow,
                DocumentName = DocumenNameTextBox?.Text,
                Items = _wareHouseDocument?.Items,
                SumBrutto = _wareHouseDocument?.Items.Sum(x => x.BruttoPrice * x.Amount),
                SumNetto = _wareHouseDocument?.Items.Sum(x => x.NettoPrice * x.Amount),
            };
            _dBService.CreateNewDocument(NewWareHouseDocument);
            this.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            WareHouseDocument NewWareHouseDocument = new WareHouseDocument()
            {
                ClientNumber = Int32.TryParse(ClientNumberTextBox.Text, out int result) ? result : 0,
                Created = DateTime.UtcNow,
                DocumentName = DocumenNameTextBox.Text,
                Items = _wareHouseDocument.Items,
                SumBrutto = _wareHouseDocument?.Items.Sum(x => x.BruttoPrice * x.Amount),
                SumNetto = _wareHouseDocument?.Items.Sum(x => x.NettoPrice * x.Amount),
                WareHouseDocumentId = _wareHouseDocument.WareHouseDocumentId
            };
            _dBService.UpdateDocumentById(NewWareHouseDocument);
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _dBService.DeleteDocument(_wareHouseDocument.WareHouseDocumentId);
            this.Close();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ItemProperties itemProperties = new ItemProperties(_wareHouseDocument.Items);
            itemProperties.Show();
            itemProperties.FormClosed += ItemProperties_FormClosed;
        }

        private void ItemProperties_FormClosed(object sender, FormClosedEventArgs e)
        {
            SumNettoDataLabel.Text = _wareHouseDocument?.Items?.Sum(x => x.NettoPrice * x.Amount).ToString();
            SumBruttoDataLabel.Text = _wareHouseDocument?.Items?.Sum(x => x.BruttoPrice * x.Amount).ToString();
            ItemsListBox.DataSource = _wareHouseDocument?.Items?.ToList();
        }
    }
}
