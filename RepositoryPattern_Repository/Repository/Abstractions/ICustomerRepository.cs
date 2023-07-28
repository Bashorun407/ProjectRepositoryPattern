using RepositoryPattern_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetCustomer(int id);
//        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerAsync(int id);
    }
}
