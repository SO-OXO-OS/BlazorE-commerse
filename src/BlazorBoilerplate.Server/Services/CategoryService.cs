using AutoMapper;
using BlazorBoilerplate.Server.Data;
using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Services
{
    public interface ICategoryService
    {
        Task<ApiResponse> GetCategories();
    }
    public class CategoryService : ICategoryService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;
        public CategoryService(ApplicationDbContext db, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _db = db;
        }
        public async Task<ApiResponse> GetCategories()
        {
            try
            {
                //Todo Shadow Property doesn't allow filter of IsDeleted here?
                return new ApiResponse(200, "Retrieved Todos", await _autoMapper.ProjectTo<CategoryDto>(_db.Categories).ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiResponse(400, ex.Message);
            }
        }
    }
}
