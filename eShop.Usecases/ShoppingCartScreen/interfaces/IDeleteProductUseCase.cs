using eShop.CoreBusiness.Model;

namespace eShop.Usecases.ShoppingCartScreen.interfaces
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int productId);
    }
}