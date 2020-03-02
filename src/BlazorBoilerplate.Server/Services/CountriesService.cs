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
    public interface ICountriesService
    {
        Task<ApiResponse> GetCountries();
    }
    public class CountriesService : ICountriesService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;
        public CountriesService(ApplicationDbContext db, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _db = db;
        }
        public async Task<ApiResponse> GetCountries()
        {
            try
            {
                //Todo Shadow Property doesn't allow filter of IsDeleted here?
                return new ApiResponse(200, "Retrieved Countries", await _autoMapper.ProjectTo<CountryDto>(_db.Countries).ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiResponse(400, ex.Message);
            }
        }
    }
}
