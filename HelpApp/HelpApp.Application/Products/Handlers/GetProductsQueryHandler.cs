using HelpApp.Application.Products.Queries;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    #region Atributos

    private readonly IProductRepository _productRepository;

    #endregion

    #region Construtor

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    #endregion

    public async Task<IEnumerable<Product>> Handle(GetProductsQuery resquest,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetProducts();
    }
}

