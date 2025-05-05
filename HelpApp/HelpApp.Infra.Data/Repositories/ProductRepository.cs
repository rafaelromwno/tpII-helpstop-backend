using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using HelpApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _productContext;
        public ProductRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }

        public Task<Product> Create(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public Task<Product> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetByIdAsync(int? id)
        {
            return await _productContext.Products.Include(c => c.Category)
               .SingleOrDefaultAsync(p => p.Id == id);
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        public Task<Product> Remove(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> RemoveAsync(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();
            return product;
        }

        public Task<Product> Update(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();
            return product;
        }
    }
}
