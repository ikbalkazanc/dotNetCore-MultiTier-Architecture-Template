using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private int[] _ids;
        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category {Id = _ids[0],Name="Elektronik" },
                new Category { Id = _ids[1], Name = "Ev" },
                new Category { Id = _ids[2], Name = "İnşaat" }
                );
        }
    }
}
