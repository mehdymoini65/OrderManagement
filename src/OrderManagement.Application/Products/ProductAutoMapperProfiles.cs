using AutoMapper;
using OrderManagement.Products.Dtos;
using OrderManagement.Products.Entities;



public class ProductAutoMapperProfiles : Profile
{
    public ProductAutoMapperProfiles()
    {
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductListItemDto>();
        CreateMap<CreateAndUpdateProductDto, Product>();
    }
}