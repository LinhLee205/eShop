using eShop.CoreBusiness.Model;

namespace eShop.CoreBusiness.Services.interfaces
{
    public interface IOrderSevice
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInfomation(string name, string address, string city, string province, string country);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}