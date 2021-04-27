﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class RFQEntity : BaseEntity
    {
        public string Status { get; set; }
        public int SupplierId { get; set; }
        public SupplierEntity Supplier { get; set; }
        public int PurchaseOrderId { get; set; }
        public PurchaseOrderEntity PurchaseOrder { get; set; }
        public List<RFQItemEntity> RFQItems { get; set; }
    }
}
