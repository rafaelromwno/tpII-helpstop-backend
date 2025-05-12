using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Interfaces;
using HelpApp.Domain.Interfaces;

namespace HelpApp.Application.Services
{
    public class CategoryServices : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryServices(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public Task Add(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CategoryDTO categoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int? id)
        {
            throw new NotImplementedException();
        }

    }
}
