namespace eShop.Usecases.AdminPortal.OrderDetailScreen.Interfaces
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}