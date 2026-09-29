using eShop.Usecases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.CoreBusiness.Model;

namespace eShop.Usecases.SearchProductScreen
{
    public class SearchProductUseCases : ISearchProductUseCases
    {
        private readonly IProductReponsitory productReponsitory;
        public SearchProductUseCases(IProductReponsitory productReponsitory)
        {
            this.productReponsitory = productReponsitory;
        }
        public IEnumerable<Product> Execute(string filter)
        {
            return productReponsitory.GetProducts(filter);
        }
    }
}
