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
    public interface IPaymentService
    {
        Task<ApiResponse> GetPayments();
    }
    public class PaymentService : IPaymentService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;
        public PaymentService(ApplicationDbContext db, IMapper autoMapper)
        {
            _autoMapper = autoMapper;
            _db = db;
        }
        public async Task<ApiResponse> GetPayments()
        {
            try
            {
                //Todo Shadow Property doesn't allow filter of IsDeleted here?
                return new ApiResponse(200, "Retrieved Payments", await _autoMapper.ProjectTo<PaymentDto>(_db.Payments).ToListAsync());
            }
            catch (Exception ex)
            {
                return new ApiResponse(400, ex.Message);
            }
        }
    }
}
