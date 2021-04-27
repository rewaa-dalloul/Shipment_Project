using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPM.Models
{
    public class PurchaseOrderItemEntity : BaseEntity
    {
        public int OrderedQuantity { get; set; }
        public int  ApprovedQuantity { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public int PurchaseOrderId { get; set; }
        public PurchaseOrderEntity PurchaseOrder { get; set; }

    }
}
