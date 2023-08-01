using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
