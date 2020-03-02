using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Server.Services;
using BlazorBoilerplate.Shared.AuthorizationDefinitions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiLogController : ControllerBase
    {
        private readonly IApiLogService _apiLogService;

        public ApiLogController(IApiLogService apiLogService)
        {
            _apiLogService = apiLogService;
        }

        // GET: api/ApiLog
        [HttpGet]
        [AllowAnonymous]
        public ApiResponse Get()
        {
            return  _apiLogService.Get();
        }

        // GET: api/ApiLog/ApplicationUserId
        [HttpGet("[action]")]
        [Authorize(Policy = Policies.IsAdmin)]
        public ApiResponse GetByApplicationUserId(string userId)
        {
            return  _apiLogService.GetByApplictionUserId(new Guid(userId));
        }
    }
}
