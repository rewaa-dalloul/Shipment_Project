using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class CountryEntity 
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public List<CityEntity> Cities { get; set; }
    }
}
