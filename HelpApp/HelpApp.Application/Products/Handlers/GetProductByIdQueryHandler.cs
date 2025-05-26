using HelpApp.Application.Products.Queries;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
{
    #region Atributos

    private readonly IProductRepository _productRepository;

    #endregion

    #region Construtor

    public GetProductByIdQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    #endregion

    public async Task<Product> Handle(GetProductByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _productRepository.GetById(request.Id);
    }
}
