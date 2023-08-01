using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class Transaction
    {
        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
        public double TransactionAmount { get; set; }
        public string AccountNumber { get; set; }
        public string DestinationAccount { get; set; }
        public string TransactionDescription { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
