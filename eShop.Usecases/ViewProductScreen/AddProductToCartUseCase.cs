using eShop.Usecases.PluginInterfaces.DataStore;
using eShop.Usecases.PluginInterfaces.StateStore;
using eShop.Usecases.PluginInterfaces.UI;
using eShop.Usecases.ViewProductScreen.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.ViewProductScreen
{
    public class AddProductToCartUseCase : IAddProductToCartUseCase
    {
        private readonly IProductReponsitory productReponsitory;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public AddProductToCartUseCase(
            IProductReponsitory productReponsitory, 
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
      
        {
            this.productReponsitory = productReponsitory;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async void Execute(int productId)
        {
            var product = productReponsitory.GetProduct(productId);
            await shoppingCart.AddProductAsync(product);

            shoppingCartStateStore.UpdateLineItemsCount();
        }
    }
}
