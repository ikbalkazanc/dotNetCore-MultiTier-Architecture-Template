using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Filter;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonsController(IPersonService PersonService, IMapper mapper)
        {
            _mapper = mapper;
            _personService = PersonService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Persons = await _personService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<Person>>(Persons));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<PersonDto>(await _personService.GetByIdAsync(id)));
        }
        
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] PersonDto personDto)
        {
            await _personService.AddAsync(_mapper.Map<Person>(personDto));
            return Created(String.Empty, personDto);
        }
        [HttpPut]
        public Task<IActionResult> Update([FromBody] PersonDto personDto)
        {
            _personService.Update(_mapper.Map<Person>(personDto));
            return Update(personDto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Remove(_personService.GetByIdAsync(id).Result);
            return NoContent();
        }
    }
}
