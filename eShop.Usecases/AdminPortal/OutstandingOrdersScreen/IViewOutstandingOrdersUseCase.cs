using eShop.CoreBusiness.Model;

namespace eShop.Usecases.AdminPortal.OutstandingOrderScreen
{
    public interface IViewOutstandingOrdersUseCase
    {
        IEnumerable<Order> Execute();
    }
}