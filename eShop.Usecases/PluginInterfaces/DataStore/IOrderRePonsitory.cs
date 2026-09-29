using eShop.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.PluginInterfaces.DataStore
{
    public interface IOrderRePonsitory
    {
        Order GetOrder(int id);
        Order GetOrderByUniqueId(string uniqueId);

        int CreateOrder(Order order);

        void UpdateOrder(Order order);

        IEnumerable<Order> GetOrders();

        IEnumerable<Order> GetOutstandingOrders();
        IEnumerable<Order> GetProcessdOrders();

        IEnumerable<Order> GetLineItemsByOrderId(int orderId);
    }
}
