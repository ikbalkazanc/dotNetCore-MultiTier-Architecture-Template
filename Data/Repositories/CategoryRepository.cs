using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Category> GetWithProductsByIdAsync(int CategoryId)
        {
            return await appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == CategoryId);
        }
    }
}
