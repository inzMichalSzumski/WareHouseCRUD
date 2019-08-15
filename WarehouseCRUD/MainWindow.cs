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
        private readonly GitHubService gitHubService;

        public MainWindow()
        {
            
            dBService = new DBService();
            gitHubService = new GitHubService();
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PopulateDocumentsList();
            DocumentsList.DoubleClick += new EventHandler(DocumentsList_MouseDoubleClick);
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.FormClosed += LoginWindow_FormClosed;
            loginWindow.Show();
        }

        private async void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var dataFromWindow = (LoginWindow)sender;
                var login = dataFromWindow.login;
                var password = dataFromWindow.password;
                var repositoryData = await gitHubService.getRepositoryData(login, password);
                RepositoryNameLabel.Text = repositoryData.Name;
                RepositoryCreatedLabel.Text = repositoryData.CreatedAt.ToString();
                RepositoryCloneUrlLabel.Text = repositoryData.CloneUrl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void PopulateDocumentsList()
        {
            DocumentsList.DisplayMember = "DocumentName";
            var MyList = dBService.GetAllDocuments();
            DocumentsList.DataSource = MyList;
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
