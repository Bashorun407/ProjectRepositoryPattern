using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class Product : AuditableBaseEntity
    {
        public int CustomerId { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        public ProductCategories ProductCategory { get; set; }
        public string ProductCategoryDescription { set { ProductCategory.ToString(); } }
        public Status ProductStatus { get; set; }

    }
}
