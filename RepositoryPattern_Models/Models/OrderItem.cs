using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class OrderItem : AuditableBaseEntity
    {
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public Order order {get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }
    }
}
