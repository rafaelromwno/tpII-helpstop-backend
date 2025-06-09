using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Products.Commands;

namespace HelpApp.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}