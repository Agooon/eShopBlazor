using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen.Interfaces
{
    public interface ISearchProductUseCase
    {
        public IEnumerable<Product> Execute(string filter);
        public IEnumerable<Product> Execute();
    }
}
