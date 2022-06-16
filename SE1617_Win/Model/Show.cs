using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1617_Win.Model
{
    public class Show
    {
        public int ShowID { get; set; }
        public int RoomID { get; set; }
        public int FilmID { get; set; }
        public DateTime ShowDate { get; set; }
        public decimal Price { get; set; }
        public Boolean Status { get; set; }
        public int Slot { get; set; }

        
    }
}
