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
    public partial class ShowGUI : Form
    {
        public ShowGUI()
        {
            InitializeComponent();
            bindGrid();
        }

        public void bindGrid()
        {
            dataGridView1.DataSource = ShowDAO.GetInstance().GetDataTable();

            int count = dataGridView1.Columns.Count;
            
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnBooking = new DataGridViewButtonColumn {
                Name = "Booking",
                Text = "Bookings",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnBooking);
            dataGridView1.Columns.Insert(count + 1, btnEdit);
            dataGridView1.Columns.Insert(count + 2, btnDelete);
            dataGridView1.Columns["ShowID"].Visible = false;
            dataGridView1.Columns["Status"].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int showID = (int)dataGridView1.Rows[e.RowIndex].Cells["ShowID"].Value;

                Show show = ShowDAO.GetInstance().GetById(showID);

                ShowAddEditGUI showAddEdit = new ShowAddEditGUI(show);
                
                DialogResult dr = showAddEdit.ShowDialog();
                dataGridView1.Columns.Clear();
                bindGrid();
            } else if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                int showID = (int)dataGridView1.Rows[e.RowIndex].Cells["ShowID"].Value;
                Show show = ShowDAO.GetInstance().GetById(showID);
                ConfirmGUI confirm = new ConfirmGUI(show);
                DialogResult dr = confirm.ShowDialog();
                dataGridView1.Columns.Clear();
                bindGrid();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Show show = new Show {
                ShowID = 0
            };
            ShowAddEditGUI showAddEdit = new ShowAddEditGUI(show);
            DialogResult dr = showAddEdit.ShowDialog();
            dataGridView1.Columns.Clear();
            bindGrid();
        }
    }
}
