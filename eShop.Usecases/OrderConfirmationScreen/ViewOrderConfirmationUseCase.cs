using eShop.CoreBusiness.Model;
using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        private readonly IOrderRePonsitory orderRePonsitory;
        public ViewOrderConfirmationUseCase(IOrderRePonsitory orderRePonsitory)
        {
            this.orderRePonsitory = orderRePonsitory;
        }
        public Order Execute(string uniqueId)
        {
            return orderRePonsitory.GetOrderByUniqueId(uniqueId);
        }
    }
}
