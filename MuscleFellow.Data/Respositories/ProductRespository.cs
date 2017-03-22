using Microsoft.EntityFrameworkCore;
using MuscleFellow.Data.Interfaces;
using MuscleFellow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscleFellow.Data.Respositories
{
    public class ProductRespository : IProductRepository
    {
        private MuscleFellowDbcontext _dbContext;
        public ProductRespository(MuscleFellowDbcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Guid> AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid productID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(Guid productID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetPopularProductsAsync(int count)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductAsync(string filter, int pageSize, int pageCount)
        {
            var results = await _dbContext.Products.Where(t => (string.IsNullOrEmpty(filter) 
                                                                || t.ProductName.Contains(filter)
                                                                || t.Description.Contains(filter)))
                                                                .Select(t => new { Product = t })
                                                                .Skip((pageSize - 1) * pageCount)
                                                                .Take(pageSize)
                                                                .ToListAsync();
            return results.Select(t => t.Product);
        }

        public Task<Guid> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
