using AutoMapper;
using BlazorBoilerplate.Server.Data;
using BlazorBoilerplate.Server.Middleware.Wrappers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Services
{
    public interface IOrderProductService
    {
        ApiResponse OrderAsync();
    }
    public class OrderProductService: IOrderProductService
    {
        ApplicationDbContext _db;
        private readonly IMapper _autoMapper;

        public OrderProductService(ApplicationDbContext db, IMapper autoMapper)
        {            
            _autoMapper = autoMapper;
            _db = db;            
        }
        public  ApiResponse OrderAsync()
        {
            return new ApiResponse(200, "Başarılı");
        }

    }
}
