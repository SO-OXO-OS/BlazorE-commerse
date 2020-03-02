using AutoMapper.Configuration;
using BlazorBoilerplate.Server.Middleware.Wrappers;
using BlazorBoilerplate.Server.Models;
using BlazorBoilerplate.Shared.Dto;

namespace BlazorBoilerplate.Server.Data.Mapping
{
    public class MappingProfile : MapperConfigurationExpression
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();           
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();
            CreateMap<ApiLogItem, ApiLogItemDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();

            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Payment,PaymentDto>().ReverseMap();
            CreateMap<State,StateDto>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>();

            CreateMap<OrderDto, Order>();
            CreateMap<CreateOrderDto, Order>();

            CreateMap<OrderProductDto, OrderProduct>();
            CreateMap<CreateOrderProductDto, OrderProduct>();

            CreateMap<ProductDto, Product>();
            CreateMap<CreateProductDto, Product>();

            CreateMap<UserAddressDto, UserAddress>();
            CreateMap<CreateUserAddressDto, UserAddress>();


        }
    }
}
