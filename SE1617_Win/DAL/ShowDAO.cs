using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using SE1617_Win.Model;

namespace SE1617_Win.DAL
{
    class ShowDAO : DAO
    {
        static ShowDAO Instance;
        ShowDAO() { }
        static ShowDAO() => Instance = new ShowDAO();
        public static ShowDAO GetInstance() => Instance;

        public DataTable GetDataTable() => GetDataTable("select * from shows");

        public Show GetById(int id)
        {
            DataTable dt = GetDataTable("select * from shows where showId = " + id);
            if (dt.Rows.Count == 0) return null;
            DataRow row = dt.Rows[0];
            Show show = new Show {
                ShowID = (int)row["showId"],
                RoomID = (int)row["roomId"],
                FilmID = (int)row["filmId"],
                ShowDate = (DateTime)row["ShowDate"],
                Status = (bool)row["status"],
                Slot = (int)row["slot"],
                Price = (decimal)row["price"]
            };
            return show;
        }

        public void Delete(Show showDelete)
        {
            SqlCommand sql = new SqlCommand("Delete from Shows where showid = " + showDelete.ShowID);
            Update(sql);

        }

        public List<int> getSlotAvaible(Show show)
        {
            List<int> listSlot = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                listSlot.Add(i);
            }

            List<int> listSlotBooking = new List<int>();

            string sql = "SELECT Slot FROM Shows WHERE RoomID = " + show.RoomID + " AND ShowDate = '" + show.ShowDate + "' order by slot ";
            DataTable dt = GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                int slot = Convert.ToInt32(dr["Slot"]);
                listSlotBooking.Add(slot);
            }



            for (int i = 0; i < listSlot.Count; i++)
            {
                for (int j = 0; j < listSlotBooking.Count; j++)
                {
                    if (listSlot[i] == listSlotBooking[j] && listSlot[i] != show.Slot)
                    {
                        listSlot.Remove(listSlot[i]);
                    }
                }
            }

            return listSlot;
        }

        public void Update(Show show)
        {
            SqlCommand cmd = new SqlCommand("Update shows set filmId = @filmId, slot = @slot, price = @price " +
                "where showId = @showId");
            cmd.Parameters.AddWithValue("@filmId", show.FilmID);
            cmd.Parameters.AddWithValue("@slot", show.Slot);
            cmd.Parameters.AddWithValue("@price", show.Price);
            cmd.Parameters.AddWithValue("@showId", show.ShowID);

            Update(cmd);

        }

        public void Add(Show show)
        {
            string sql = "INSERT INTO [Shows]([RoomID]," +
                "[FilmID],[ShowDate],[Price],[Status]," +
                "[Slot])VALUES(@roomID, @filmID,@showDate,@price,@status,@slot)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@roomID", show.RoomID);
            cmd.Parameters.AddWithValue("@filmID", show.FilmID);
            cmd.Parameters.AddWithValue("@showDate", show.ShowDate);
            cmd.Parameters.AddWithValue("@price", show.Price);
            cmd.Parameters.AddWithValue("@status", show.Status);
            cmd.Parameters.AddWithValue("@slot", show.Slot);

            Update(cmd);
        }

        public List<int> getAllSlot()
        {
            List<int> listSlot = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                listSlot.Add(i);
            }
            return listSlot;
        }

        public bool isExistShow(Show showNew)
        {
            string sql = $"SELECT * FROM [Shows] where [RoomID] = {showNew.RoomID} AND [ShowDate] = '{showNew.ShowDate}' AND [Slot] = {showNew.Slot}";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
