﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class InvoiceEntity : BaseEntity
    {
        public string Status { get; set; }
        public int Total { get; set; }
        public int SubTotal { get; set; }
        public int VatValue { get; set; }
        public int TotalQuantity { get; set; }
        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }
        public int PurchaseOrderId { get; set; }
        public PurchaseOrderEntity PurchaseOrder { get; set; }
        public List<InvoiceItemEntity>  InvoiceItems { get; set; }
    }
}
