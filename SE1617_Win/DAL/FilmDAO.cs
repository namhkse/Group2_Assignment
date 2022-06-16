using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SE1617_Win.Model;

namespace SE1617_Win.DAL
{
    class FilmDAO:DAO
    {
        static FilmDAO Instance;
        FilmDAO()
        {
        }
        static FilmDAO() => Instance = new FilmDAO();

        public static FilmDAO GetInstance() => Instance;


        public DataTable GetDataTable() => GetDataTable("Select * from films");

        public DataTable getListFilm(Show show)
        {
            string sql = "SELECT DISTINCT f.* FROM Shows s JOIN Rooms r " +
                " ON r.RoomID = s.RoomID JOIN Films f" +
                " ON f.FilmID = s.FilmID " +
                " WHERE r.RoomID = " + show.RoomID + " AND s.ShowDate = '"+ show.ShowDate + "'" ;

            DataTable dt = GetDataTable(sql);

            return dt;
        }

    }
}
