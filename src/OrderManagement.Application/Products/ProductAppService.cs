using System;
using OrderManagement.Products.Dtos;
using OrderManagement.Products.Entities;
using OrderManagement.Products.Repositories;
using Volo.Abp.Application.Services;


namespace OrderManagement.Products;

public class ProductAppService : CrudAppService<Product, ProductDto, ProductListItemDto, Guid, ProductPagedAndSortedResultRequestDto, CreateAndUpdateProductDto, CreateAndUpdateProductDto>, IProductAppService
{
    private readonly IProductRepository _productRepository;
    public ProductAppService(IProductRepository productRepository) : base(productRepository)
    {
        _productRepository = productRepository;
    }
}
