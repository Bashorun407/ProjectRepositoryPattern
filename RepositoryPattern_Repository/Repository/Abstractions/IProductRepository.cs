using RepositoryPattern_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.Repository.Abstractions
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Customer GetCustomer(int id);
        Task<Customer> GetCustomerAsync(int id);
        Task<IQueryable<Customer>> GetAllCustomers();
    }
}
