using eShop.CoreBusiness.Model;

namespace eShop.Usecases.ShoppingCartScreen.interfaces
{
    public interface IUpdateQuantityUseCase
    {
        Task<Order> Execute(int productId, int quantity);
    }
}