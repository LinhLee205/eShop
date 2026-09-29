using eShop.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Usecases.ViewProductScreen
{
    public interface IViewProductUseCases
    {
        Product Execute(int id);
    }
}
