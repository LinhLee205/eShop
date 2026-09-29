using eShop.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.SearchProductScreen
{
    public interface ISearchProductUseCases
    {
        //Product Execute(int id);
        IEnumerable<Product> Execute(string filter = null);
    }
}
