using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen
{
    public interface IViewProcessedOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}