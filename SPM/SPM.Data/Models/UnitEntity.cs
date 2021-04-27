using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class UnitEntity : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public List<ProductEntity> Products { get; set; }
    }
}
