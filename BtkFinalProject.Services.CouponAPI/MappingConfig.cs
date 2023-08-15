using AutoMapper;
using BtkFinalProject.Services.CouponAPI.Models;
using BtkFinalProject.Services.CouponAPI.Models.Dto;

namespace BtkFinalProject.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
