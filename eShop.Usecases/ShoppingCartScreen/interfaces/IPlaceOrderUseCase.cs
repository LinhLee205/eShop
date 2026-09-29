using eShop.CoreBusiness.Model;

namespace eShop.Usecases.ShoppingCartScreen.interfaces
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Excute(Order order);
    }
}