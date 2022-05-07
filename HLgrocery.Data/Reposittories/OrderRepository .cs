using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLgrocery.Data.Infrastructure;
using HLgrocery.Model.Models;

namespace HLgrocery.Data.Reposittories
{
    namespace TeduShop.Data.Repositories
    {
        public interface IOrderRepository : IRepository<Order>
        {
        }

        public class OrderRepository : RepositoryBase<Order>, IOrderRepository
        {
            public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
            {
            }
        }
    }
}