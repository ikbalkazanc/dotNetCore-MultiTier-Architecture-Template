using API.DTOs;
using AutoMapper;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Person, PersonDto>();
            CreateMap<PersonDto, Person>();
            CreateMap<CategoryWithProductDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<Product,ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();
            CreateMap<IEnumerable<Product>, IEnumerable<ProductDto>>();
        }
    }
}
