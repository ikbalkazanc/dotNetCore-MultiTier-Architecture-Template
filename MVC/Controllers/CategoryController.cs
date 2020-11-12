using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.DTOs;
using AutoMapper;
using Core.Repositories;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Core.Models;
using MVC.ApiService;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper, CategoryApiService categoryApiService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _categoryApiService = categoryApiService;
        }
        public IActionResult Index()
        {    
            return View();
        }
        public async Task<IActionResult> List()
        {
            /*
            var categories = await _categoryService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<CategoryDto>>(categories));
            */
            var categories = await _categoryApiService.GetAllAsync();
            return View(categories);
        }
        public IActionResult AddPage()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            /*
            await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));
            return RedirectToAction("List");
            */
            await _categoryApiService.AddAsync(categoryDto);
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Update(int id)
        {
            /*
            var category = _categoryService.GetByIdAsync(id).Result;
            return View(_mapper.Map<CategoryDto>(category));
            */
            var category = await _categoryApiService.GetById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(CategoryDto categoryDto)
        {
            
            _categoryService.Update(_mapper.Map<Category>(categoryDto));
            return RedirectToAction("List");
            
        }
        public async Task<IActionResult> Delete(int id)
        {
            /*
            _categoryService.Remove(_categoryService.GetByIdAsync(id).Result);
            return RedirectToAction("List");
            */
            await _categoryApiService.Remove(id);
            return RedirectToAction("List");
        }

    }
}