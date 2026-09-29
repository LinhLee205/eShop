using eShop.CoreBusiness.Model;

namespace eShop.Usecases.AdminPortal.OrderDetailScreen.Interfaces
{
    public interface IViewOrderDetailUseCase
    {
        Order Execute(int orderId);
    }
}