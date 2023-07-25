using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class Order : AuditableBaseEntity
    {
        public Status OrderStatus { get; set; }
        public ICollection<OrderItem> OrderItems { get; set;}
        public int CustomerId { get; set; }

    }
}
