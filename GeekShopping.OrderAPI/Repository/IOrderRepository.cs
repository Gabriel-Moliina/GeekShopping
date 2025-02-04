using GeekShopping.OrderAPI.Model;

namespace GeekShopping.CartAPI.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader header);
        Task UpdateOrderPaymentStaus(long orderHeaderId, bool paid);
    }
}
