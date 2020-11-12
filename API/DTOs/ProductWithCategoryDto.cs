using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto category { get; set; }
    }
}
