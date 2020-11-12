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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitofwork, IRepository<Product> repository) : base(unitofwork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int ProductId)
        {
            return await _unitOfWork.Products.GetWithCategoryByIdAsync(ProductId);
        }
    }
}
