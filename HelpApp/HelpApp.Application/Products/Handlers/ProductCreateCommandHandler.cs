using HelpApp.Application.Products.Commands;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;

public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product>
{
    #region Atributos

    private readonly IProductRepository _productRepository;

    #endregion

    #region Construtor

    public ProductCreateCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    #endregion

    public async Task<Product> Handle(ProductCreateCommand request,
        CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Description, request.Price,
            request.Stock, request.Image);

        if (product == null)
        {
            throw new ApplicationException($"Error creating entity.");
        }

        product.CategoryId = request.CategoryId;

        return await _productRepository.Create(product);
    }
}