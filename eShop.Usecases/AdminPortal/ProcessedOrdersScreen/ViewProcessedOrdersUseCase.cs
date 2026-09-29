using eShop.CoreBusiness.Model;
using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.AdminPortal.ProcessedOrdersScreen
{
    public class ViewProcessedOrdersUseCase : IViewProcessedOrdersUseCase
    {
        private readonly IOrderRePonsitory orderRePonsitory;
        public ViewProcessedOrdersUseCase(IOrderRePonsitory orderRePonsitory)
        {
            this.orderRePonsitory = orderRePonsitory;
        }
        public IEnumerable<Order> Execute()
        {
            return orderRePonsitory.GetProcessdOrders();
        }
    }
}
