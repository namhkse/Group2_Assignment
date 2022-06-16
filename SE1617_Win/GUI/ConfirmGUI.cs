using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE1617_Win.DAL;
using SE1617_Win.Model;

namespace SE1617_Win.GUI
{
    public partial class ConfirmGUI : Form
    {
        Show showDelete;
        public ConfirmGUI(Show show)
        {
            InitializeComponent();
            showDelete = show;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            ShowDAO.GetInstance().Delete(showDelete);
            ShowGUI show = new ShowGUI();
            
        }
    }
}
