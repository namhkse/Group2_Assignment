using System;
using System.Windows.Forms;
using SE1617_Win.DAL;
using SE1617_Win.Model;

namespace SE1617_Win.GUI
{
    public partial class ShowAddEditGUI : Form
    {
        Boolean isAdd = false;
        int showID = 0;
        public ShowAddEditGUI(Show show)
        {
            InitializeComponent();

            if (show.ShowID == 0)
            {
                isAdd = true;
            }
            else
            {
                isAdd = false;
                showID = show.ShowID;
            }

            if (isAdd == false)
            {
                dtpDate.Value = show.ShowDate;
                cboRoom.DataSource = RoomDAO.GetInstance().GetDataTable();
                cboRoom.DisplayMember = "Name";
                cboRoom.ValueMember = "RoomId";
                cboRoom.SelectedValue = show.RoomID;

                cboFilm.DataSource = FilmDAO.GetInstance().getListFilm(show);
                cboFilm.DisplayMember = "Title";
                cboFilm.ValueMember = "FilmID";
                cboFilm.SelectedValue = show.FilmID;

                cboSlot.DataSource = ShowDAO.GetInstance().getSlotAvaible(show);
                cboSlot.SelectedItem = show.Slot;

                txtPrice.Text = show.Price.ToString();

                cboRoom.Enabled = false;
                dtpDate.Enabled = false;
            }
            else
            {
                cboRoom.Enabled = true;
                dtpDate.Enabled = true;

                cboRoom.DataSource = RoomDAO.GetInstance().GetDataTable();
                cboRoom.DisplayMember = "Name";
                cboRoom.ValueMember = "RoomId";

                cboSlot.DataSource = ShowDAO.GetInstance().getAllSlot();

                cboFilm.DataSource = FilmDAO.GetInstance().GetDataTable();
                cboFilm.DisplayMember = "Title";
                cboFilm.ValueMember = "FilmID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd == false)
            {
                Decimal price;
                try
                {
                    price = Convert.ToDecimal(txtPrice.Text.ToString());
                    if (price < 0)
                    {
                        MessageBox.Show("Price must be greater or equals than 0");
                    }
                    else
                    {
                        Show showUpdate = new Show {
                            ShowID = showID,
                            RoomID = Convert.ToInt32(cboRoom.SelectedValue.ToString()),
                            ShowDate = Convert.ToDateTime(dtpDate.Value.ToString()),
                            FilmID = Convert.ToInt32(cboFilm.SelectedValue.ToString()),
                            Price = Convert.ToDecimal(txtPrice.Text.ToString()),
                            Slot = Convert.ToInt32(cboSlot.SelectedValue.ToString())

                        };
                        ShowDAO.GetInstance().Update(showUpdate);
                        MessageBox.Show("That show is edited!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Price");
                }

            }
            else
            {
                decimal price;
                try
                {
                    price = Convert.ToDecimal(txtPrice.Text.ToString());
                    if (price < 0)
                    {
                        MessageBox.Show("Price must be greater or equals than 0");
                    }
                    else
                    {
                        Show showNew = new Show {
                            RoomID = Convert.ToInt32(cboRoom.SelectedValue.ToString()),
                            ShowDate = Convert.ToDateTime(dtpDate.Value.ToString()),
                            FilmID = Convert.ToInt32(cboFilm.SelectedValue.ToString()),
                            Price = price,
                            Slot = Convert.ToInt32(cboSlot.SelectedValue.ToString())
                        };
                        Boolean isExistShow = ShowDAO.GetInstance().isExistShow(showNew);
                        if (isExistShow == true)
                        {
                            MessageBox.Show("The show is existed");
                        }

                        else
                        {
                            ShowDAO.GetInstance().Add(showNew);
                            MessageBox.Show("A new show is added!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Price");
                }

            }
        }
    }
}
