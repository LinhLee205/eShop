using eShop.CoreBusiness.Model;

namespace eShop.Usecases.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        Order Execute(string uniqueId);
    }
}