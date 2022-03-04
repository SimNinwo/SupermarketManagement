using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.Interfaces.UseCases
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}
