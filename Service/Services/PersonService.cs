using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class PersonService : Service<Person>,IPersonService
    {
        public PersonService(IUnitOfWork unitofwork, IRepository<Person> repository) : base(unitofwork, repository)
        {
        }
    }
}
