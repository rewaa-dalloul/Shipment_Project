﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class ProductSupplierEntity : BaseEntity
    {
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int SupplierId { get; set; }
        public SupplierEntity Supplier { get; set; }

    }
}
