﻿using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components
{
    public class CategoryMenu: ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public ViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy
        }
    }
}
