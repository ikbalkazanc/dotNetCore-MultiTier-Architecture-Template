using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class PersonRepository : Repository<Person> , IPersonRepository
    {
        private AppDbContext appDbContext { get => _context as AppDbContext; }
        public PersonRepository(AppDbContext context) : base(context)
        {
        }
    }
}
