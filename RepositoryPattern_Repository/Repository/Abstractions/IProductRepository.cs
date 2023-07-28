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
        Task<Product> GetProductAsync(int id);
        Task<IEnumerable<Product>> GetAllProductByCustomerId(int id);
    }
}
