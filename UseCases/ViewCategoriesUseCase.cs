using CoreBusiness;
using System;
using System.Collections.Generic;
using UseCases.DataStore.PluginInterfaces;

namespace UseCases
{
    public class ViewCategoriesUseCase
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
