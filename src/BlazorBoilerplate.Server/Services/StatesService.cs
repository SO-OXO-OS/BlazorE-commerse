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
    public interface IStatesService
    {
        Task<ApiResponse> GetStates();
    }
    public class StatesService : IStatesService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;
        public StatesService(ApplicationDbContext db, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _db = db;
        }
        public async Task<ApiResponse> GetStates()
        {
            try
            {
                //Todo Shadow Property doesn't allow filter of IsDeleted here?
                return new ApiResponse(200, "Retrieved States", await _autoMapper.ProjectTo<StateDto>(_db.States).ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiResponse(400, ex.Message);
            }
        }
    }
}
