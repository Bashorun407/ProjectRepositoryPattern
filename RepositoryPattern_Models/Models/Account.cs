using RepositoryPattern_Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RepositoryPattern_Models.Models
{
    public class Account
    {
        public AccountType AccountType { get; set; }
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
