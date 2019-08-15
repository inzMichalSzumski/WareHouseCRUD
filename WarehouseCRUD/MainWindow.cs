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
    public partial class MainWindow : Form
    {
        private readonly DBService dBService;
        public MainWindow()
        {
            InitializeComponent();
            dBService = new DBService();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PopulateDocumentsList();
            DocumentsList.DoubleClick += new EventHandler(DocumentsList_MouseDoubleClick);
        }

        private void DBInitializer(List<WareHouseDocument> dataFeed)
        {
            using (var db = new WareHouseContext())
            {
                db.WareHouseDocuments.AddRange(dataFeed);
                db.SaveChanges();

                var down = from whdset in db.WareHouseDocuments
                           select whdset;

                var data = down.ToList();
                
            }
        }

        public List<WareHouseDocument> PopulateDocumentsList()
        {
            DocumentsList.DisplayMember = "DocumentName";
            List<WareHouseDocument> MyList = new List<WareHouseDocument>();
            MyList = dBService.GetAllDocuments();
            DocumentsList.DataSource = MyList;

            

            return MyList;

            //MyList.Add(new WareHouseDocument
            //{
            //    DocumentName = "doc1",
            //    ClientNumber = 123,
            //    Created = new DateTime(2019, 08, 01),
            //    WareHouseDocumentId = Guid.NewGuid(),
            //    Items = new List<Item>
            //    {
            //        new Item
            //        {
            //            Amount = 3,
            //            BruttoPrice = 5.50M,
            //            Name = "mlotek",
            //            ItemId = Guid.NewGuid()
            //        },

            //        new Item
            //        {
            //            Amount = 5,
            //            BruttoPrice = 3.90M,
            //            Name = "gwozdz",
            //            ItemId = Guid.NewGuid()
            //        }
            //    }
            //});
            //MyList.Add(new WareHouseDocument
            //{
            //    DocumentName = "doc2",
            //    ClientNumber = 456,
            //    Created = new DateTime(2019, 08, 05),
            //    WareHouseDocumentId = Guid.NewGuid(),
            //    Items = new List<Item>
            //    {
            //        new Item
            //        {
            //            Amount = 1,
            //            BruttoPrice = 5.50M,
            //            Name = "mlotek",
            //            ItemId = Guid.NewGuid()
            //        },

            //        new Item
            //        {
            //            Amount = 10,
            //            BruttoPrice = 3.90M,
            //            Name = "gwozdz",
            //            ItemId = Guid.NewGuid()
            //        }
            //    }

            //});


        }

        private void DocumentsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DocumentsList_MouseDoubleClick(object sender, EventArgs e)
        {
            if (DocumentsList.SelectedItem != null)
            {
                var selectedItem = DocumentsList.SelectedItem as WareHouseDocument;
                DocumentPropertiesWindow propertiesWindow = new DocumentPropertiesWindow(selectedItem);
                propertiesWindow.Show();
                propertiesWindow.FormClosed += PropertiesWindow_FormClosed;
            }
        }

        private void AddNewDocument_Click(object sender, EventArgs e)
        {
            DocumentPropertiesWindow propertiesWindow = new DocumentPropertiesWindow();
            propertiesWindow.Show();
            propertiesWindow.FormClosed += PropertiesWindow_FormClosed; ;
        }

        private void PropertiesWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateDocumentsList();
        }
    }
}
