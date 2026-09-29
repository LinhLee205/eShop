using eShop.CoreBusiness.Model;
using eShop.Usecases.AdminPortal.OrderDetailScreen.Interfaces;
using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.AdminPortal.OrderDetailScreen
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        public readonly IOrderRePonsitory orderRePonsitory;
        public ViewOrderDetailUseCase(IOrderRePonsitory orderRePonsitory)
        {
            this.orderRePonsitory = orderRePonsitory;
        }
        public Order Execute(int orderId)
        {
            return orderRePonsitory.GetOrder(orderId);
        }
    }
}
