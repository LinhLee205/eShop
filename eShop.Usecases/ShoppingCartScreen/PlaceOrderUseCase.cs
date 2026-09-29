using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.CoreBusiness.Model;
using eShop.CoreBusiness.Services;
using eShop.CoreBusiness.Services.interfaces;
using eShop.Usecases.PluginInterfaces.DataStore;
using eShop.Usecases.PluginInterfaces.StateStore;
using eShop.Usecases.PluginInterfaces.UI;
using eShop.Usecases.ShoppingCartScreen.interfaces;

namespace eShop.Usecases.ShoppingCartScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderSevice orderService;
        private readonly IOrderRePonsitory orderRePonsitory;
        private readonly IShoppingCartStateStore shoppingCartStateStore;
        private readonly IShoppingCart shoppingCart;
        public PlaceOrderUseCase(IOrderSevice orderService,
            IOrderRePonsitory orderRePonsitory,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
        {
            this.orderService = orderService;
            this.orderRePonsitory = orderRePonsitory;
            this.shoppingCartStateStore = shoppingCartStateStore;
            this.shoppingCart = shoppingCart;
        }
        public async Task<string> Excute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                orderRePonsitory.CreateOrder(order);
                await shoppingCart.EmptyAsync();
                shoppingCartStateStore.UpdateLineItemsCount();
                return order.UniqueId;
            }
            return null;

        }
    }
}
