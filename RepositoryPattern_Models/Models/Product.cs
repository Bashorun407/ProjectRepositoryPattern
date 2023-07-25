using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class Product : AuditableBaseEntity
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public ProductCategories ProductCategory { get; set; }
        public string ProductCategoryDescription { set { ProductCategory.ToString(); } }
    }
}
