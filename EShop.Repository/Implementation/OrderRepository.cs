using EShop.Domain.Domain;
using EShop.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository.Implementation
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders
                .Include(o => o.Owner)
                .Include(o => o.ProductInOrders)
                .ThenInclude(pio => pio.OrderedProduct).ThenInclude(op => op.Movie).ToList();
        }

        public Order Get(Guid? id)
        {
            return _context.Orders.Include(o => o.Owner).Include(o => o.ProductInOrders).First(s => s.Id == id);
        }
    }
}
