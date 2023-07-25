using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        private DateTime CreatedDate { get; set; }
        private string CreatedBy {  get; set; }
        private DateTime ModifiedDate { get; set; }
        private string ModifiedBy { get; set; }

    }
}
