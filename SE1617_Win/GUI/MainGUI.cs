using System;
using System.Windows.Forms;
using SE1617_Win.GUI;

namespace SE1617_Win
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text.Equals("Login"))
            {
                LoginGUI loginGui = new LoginGUI();
                DialogResult dialog = loginGui.ShowDialog();
            }
            else
            {
                Settings.Username = "";
                MessageBox.Show("You are logged out");
            }

        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            if (Settings.Username == "")
            {
                loginToolStripMenuItem.Text = "Login";
            }
            else
            {
                loginToolStripMenuItem.Text = $"Logout ({Settings.Username})";
            }

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Username == "")
            {
                MessageBox.Show("You need to login");
            }
            else
            {
                ShowGUI show = new ShowGUI();
                show.TopLevel = false;
                show.FormBorderStyle = FormBorderStyle.None;
                show.Show();

            }
        }
    }
}
