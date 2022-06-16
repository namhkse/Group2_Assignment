using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1617_Win.Model
{
    public class Film
    {
        public int FilmID { get; set; }
        public int GenreID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string CountryCode { get; set; }

        public Film(int filmID, int genreID, string title, int year, string countryCode)
        {
            FilmID = filmID;
            GenreID = genreID;
            Title = title;
            Year = year;
            CountryCode = countryCode;
        }

        public Film()
        {
        }
    }
}
