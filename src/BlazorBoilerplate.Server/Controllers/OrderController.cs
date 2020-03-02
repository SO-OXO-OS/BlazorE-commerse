using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBoilerplate.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderProductService _orderProductService;
        public OrderController(IOrderProductService orderProductService)
        {
            _orderProductService = orderProductService;
        }
        [HttpGet("order")]
        public ApiResponse OrderAsync()
        {
            return  _orderProductService.OrderAsync();
        }
    }
}
