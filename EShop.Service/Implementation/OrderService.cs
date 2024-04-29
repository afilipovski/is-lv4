using EShop.Domain.Domain;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateNewOrder(Order p)
        {
            _orderRepository.Insert(p);
        }

        public void DeleteOrder(Guid id)
        {
            Order order = _orderRepository.Get(id);
            _orderRepository.Delete(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll().ToList();
        }

        public Order GetDetailsForOrder(Guid? id)
        {
            Order order = _orderRepository.Get(id);
            return order;
        }

        public void UpdateExistingOrder(Order p)
        {
            _orderRepository.Update(p);
        }
    }
}
