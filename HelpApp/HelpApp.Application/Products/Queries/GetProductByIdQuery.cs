using HelpApp.Domain.Entities;
using MediatR;

namespace HelpApp.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        #region Atributos

        public int Id { get; set; }

        #endregion

        #region Construtor

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        #endregion
    }
}
