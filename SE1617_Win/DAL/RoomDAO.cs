using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE1617_Win.Model;

namespace SE1617_Win.DAL
{
    public class RoomDAO : DAO
    {
        static RoomDAO Instance;
        RoomDAO() { 
        }
        static RoomDAO() => Instance = new RoomDAO();
        public static RoomDAO GetInstance() => Instance;

        public DataTable GetDataTable() => GetDataTable("select * from rooms");
    }
}
