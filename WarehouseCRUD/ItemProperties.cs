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
    public partial class ItemProperties : Form
    {
        private ICollection<Item> _items;
        public ItemProperties(ICollection<Item> items)
        {
            InitializeComponent();
            _items = items;
        }

        private void ItemProperties_Load(object sender, EventArgs e)
        {

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item
            {
                ItemId = Guid.NewGuid(),
                Amount = Int32.Parse(AmountTextBox.Text),
                NettoPrice = Int32.Parse(NettoPriceTextBox.Text),
                BruttoPrice = Int32.Parse(BruttoPriceTextBox.Text),
                Name = NameTextBox.Text,
            });
            this.Close();
        }
    }
}
