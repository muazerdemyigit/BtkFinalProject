using BtkFinalProject.Services.CouponAPI.Models.Dto;

namespace BtkFinalProject.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
