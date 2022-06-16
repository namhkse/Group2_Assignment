using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace SE1617_Win.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", true, true).Build();
            username = config["User:Username"];
            password = config["User:Password"];

            if(txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("You are logged in as administrator!");
                Settings.Username = username;
            }
            else
            {
                MessageBox.Show("Don't have that user!");
            }
        }
    }
}
