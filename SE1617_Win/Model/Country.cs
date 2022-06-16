using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1617_Win.Model
{
    public class Country
    {
        public string CountryID { get; set; }
        public string CountryName { get; set; }

        public Country(string countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public Country()
        {
        }
    }
}
