using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class Customer : AuditableBaseEntity
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}
