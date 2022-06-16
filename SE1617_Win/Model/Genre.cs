using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1617_Win.Model
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }

        public Genre(int genreID, string name)
        {
            GenreID = genreID;
            Name = name;
        }

        public Genre()
        {
        }
    }
}
