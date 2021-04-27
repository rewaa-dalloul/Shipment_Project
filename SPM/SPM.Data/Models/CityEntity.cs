using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class CityEntity : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int CountyId { get; set; }
        public CountryEntity County { get; set; }
        public List<ClientEntity> Clients { get; set; }
        public List<SupplierEntity> Suppliers { get; set; }
    }
}
