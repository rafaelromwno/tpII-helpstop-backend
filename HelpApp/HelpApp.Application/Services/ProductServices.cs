using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Infra.Data.Repositories;

namespace HelpApp.Application.Services
{
    public class ProductServices : IProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly IMapper _mapper;

        public async Task Add(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);

            await _productRepository.Create(productEntity);
        }
        public async Task<ProductDTO> GetById(int? id)
        {
            var productEntity = _productRepository.GetById(id);

            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProducts();

            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = await _productRepository.GetById(id);

            await _productRepository.Remove(productEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);

            await _productRepository.Update(productEntity);
        }
    }
}
