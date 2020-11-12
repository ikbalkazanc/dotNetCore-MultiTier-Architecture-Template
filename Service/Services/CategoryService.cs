using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitofwork, IRepository<Category> repository) : base(unitofwork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await _unitOfWork.Categories.GetWithProductsByIdAsync(CategoryId);
        }
    }
}
