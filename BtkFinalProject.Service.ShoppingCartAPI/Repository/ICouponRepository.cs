using BtkFinalProject.Service.ShoppingCartAPI.Models.Dto;

namespace BtkFinalProject.Service.ShoppingCartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCoupon(string couponName);
    }
}
