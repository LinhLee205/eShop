using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.CoreBusiness.Model;

namespace eShop.Usecases.ViewProductScreen
{
    public class ViewProductUseCases : IViewProductUseCases
    {
        private readonly IProductReponsitory productReponsitory;
        public ViewProductUseCases(IProductReponsitory productReponsitory)
        {
            this.productReponsitory = productReponsitory;
        }
        public Product Execute(int id)
        { return productReponsitory.GetProduct(id); }
    }
}
