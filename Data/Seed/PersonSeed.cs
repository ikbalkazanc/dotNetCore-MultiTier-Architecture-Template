using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Seed
{
    public class PersonSeed : IEntityTypeConfiguration<Person>
    {
        private int[] _ids;
        public PersonSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person { Id = _ids[0],Name="Ahmet",Surname="Deliyürek"},
                new Person { Id = _ids[1], Name = "Handan", Surname = "Dert" }
                );
        }
    }
}
