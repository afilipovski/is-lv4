using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();
        Order GetDetailsForOrder(Guid? id);
        void CreateNewOrder(Order p);
        void UpdateExistingOrder(Order p);
        void DeleteOrder(Guid id);
    }
}
