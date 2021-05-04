﻿using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eShop.UseCases.PluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string filter = null);
        Product GetProduct(int id);
    }
}
