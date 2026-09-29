using eShop.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.PluginInterfaces.DataStore
{
    public interface IProductReponsitory
    {
       
        IEnumerable<Product> GetProducts(string filter);
        Product GetProduct(int id);

    }
}

