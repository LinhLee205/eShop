using eShop.CoreBusiness.Model;
using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.AdminPortal.OutstandingOrderScreen
{
    public class ViewOutstandingOrdersUseCase : IViewOutstandingOrdersUseCase
    {
        private readonly IOrderRePonsitory orderRePonsitory;
        public ViewOutstandingOrdersUseCase(IOrderRePonsitory orderRePonsitory)
        {
            this.orderRePonsitory = orderRePonsitory;
        }
        public IEnumerable<Order> Execute()
        {
            return orderRePonsitory.GetOutstandingOrders();
        }
    }
}
