using AutoMapper;
using BtkFinalProject.Services.ProductAPI.Models;
using BtkFinalProject.Services.ProductAPI.Models.Dto;

namespace BtkFinalProject.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
