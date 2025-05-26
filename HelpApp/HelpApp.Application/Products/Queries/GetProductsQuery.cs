using HelpApp.Domain.Entities;
using MediatR;

namespace HelpApp.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
