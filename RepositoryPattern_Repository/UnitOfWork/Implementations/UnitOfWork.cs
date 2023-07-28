using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Models.Models;
using RepositoryPattern_Repository.Data;
using RepositoryPattern_Repository.Repository.Abstractions;
using RepositoryPattern_Repository.Repository.Implementations;
using RepositoryPattern_Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICustomerRepository _customerRepository;
        private IProductRepository _productRepository;
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICustomerRepository Customers => _customerRepository ??= new CustomerRepository(_context);
        public IProductRepository Products => _productRepository ??= new ProductRepository(_context);

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
