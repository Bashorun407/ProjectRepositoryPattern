using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Models.Models;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Customer> _customer;

        public CustomerRepository(AppDbContext context, DbSet<Customer> customer) : base(context)
        {
            _context = context;
            _customer = _context.Set<Customer>();
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = _customer.Find(id);
            return customer;
        }

        public async Task<Customer> GetCustomerAsync(int id)
        {
            Customer customer = await _customer.FindAsync(id);
            return customer;
        }

        public async Task<IQueryable<Customer>> GetAllCustomers()
        {
            IQueryable<Customer> customers = _customer.Include(x => x.Products);
            return customers;
        }


    }
}
