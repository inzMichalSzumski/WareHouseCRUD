using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseCRUD
{
    public partial class LoginWindow : Form
    {
        public string login;
        public string password;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            login = LoginTextBox.Text;
            password = PasswordTextBox.Text;
            this.Close();
        }
    }
}
