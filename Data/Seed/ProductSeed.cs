using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Monitör", Price = 2000.50m, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Fare", Price = 50, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Sandalye", Price = 1000.10m, CategoryId = _ids[1] },
                new Product { Id = 4, Name = "Fayans", Price = 150.20m, CategoryId = _ids[2] }
                );

        }
    }
}
