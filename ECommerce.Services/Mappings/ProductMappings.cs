// الموقع: ECommerce.Services/Mappings/ProductMappings.cs
using AutoMapper;
using ECommerce.Core.Models.Entities;
using ECommerce.Core.ViewModels.Products;
using ECommerce.Core.ViewModels.Shared;

namespace ECommerce.Services.Mappings
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            // Mapping for Product to ProductVM
            CreateMap<Product, ProductVM>()
                .ForMember(dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
                .ForMember(dest => dest.Images,
                    opt => opt.MapFrom(src => src.Images))
                .ReverseMap();

            // Mapping for ProductImage to ImageVM
            CreateMap<ProductImage, ImageVM>()
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.IsMain, opt => opt.MapFrom(src => src.IsMainImage));
        }
    }
}