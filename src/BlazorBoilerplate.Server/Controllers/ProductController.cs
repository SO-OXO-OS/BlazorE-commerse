using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public ProductController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("getallcategory")]
        public async Task<ApiResponse> GetAllCategory()
        {
            return await _categoryService.GetCategories();
        }

    }
}
