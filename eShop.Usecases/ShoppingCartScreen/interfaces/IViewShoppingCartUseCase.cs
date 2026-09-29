using eShop.CoreBusiness.Model;

namespace eShop.Usecases.ShoppingCartScreen.interfaces
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Execute();
    }
}