using Microsoft.EntityFrameworkCore;
using RepositoryPattern_Models.Models;
using RepositoryPattern_Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Repository.Repository.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProgress<Product>
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Product> _dbSet;

        public ProductRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _dbSet = _context.Set<Product>();
        }

        public Product GetProduct(int id)
        {
            Product product = _dbSet.Find(id);
            return product;
        }
       
        public async Task<Product> GetProductAsync(int id)
        {
            Product product = await _dbSet.FindAsync(id);
            return product;
        }

        public async  Task<IEnumerable<Product>> GetAllProductByCustomerId(int id) 
        {
            IEnumerable<Product> products =  await _dbSet.Where(x=> x.CustomerId == id).ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            Product product = await _dbSet.FindAsync(id);
            return product;
        }

        public void Report(Product value)
        {
            throw new NotImplementedException();
        }
    }
}
