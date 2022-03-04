using CoreBusiness;
using System;
using System.Collections.Generic;
using UseCases.Interfaces.Plugins;
using UseCases.Interfaces.UseCases;

namespace UseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public IEnumerable<Category> Execute()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
