using eShop.CoreBusiness.Services.interfaces;
using eShop.Usecases.AdminPortal.OrderDetailScreen.Interfaces;
using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.AdminPortal.OrderDetailScreen
{
    public class ProcessOrderUseCase : IProcessOrderUseCase
    {
        private readonly IOrderRePonsitory orderRePonsitory;
        private readonly IOrderSevice orderSevice;
        public ProcessOrderUseCase(IOrderRePonsitory orderRePonsitory, IOrderSevice orderSevice)
        {
            this.orderRePonsitory = orderRePonsitory;
            this.orderSevice = orderSevice;
        }
        public bool Execute(int orderId, string adminUserName)
        {
            var order = orderRePonsitory.GetOrder(orderId);
            order.AdminUser = adminUserName;
            order.DateProcessed = DateTime.Now;
            if (orderSevice.ValidateProcessOrder(order))
            {
                orderRePonsitory.UpdateOrder(order);
                return true;
            }
            return false;
        }
    }
}
