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
    public interface ICargosService
    {
        Task<ApiResponse> GetCargos();
    }
    public class CargosService : ICargosService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;
        public CargosService(ApplicationDbContext db, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _db = db;
        }
        public async Task<ApiResponse> GetCargos()
        {
            try
            {
                //Todo Shadow Property doesn't allow filter of IsDeleted here?
                return new ApiResponse(200, "Retrieved Cargos", await _autoMapper.ProjectTo<CargoDto>(_db.Cargos).ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiResponse(400, ex.Message);
            }
        }
    }
}
