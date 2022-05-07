using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HLgrocery.Data.Infrastructure;
using HLgrocery.Model.Models;


namespace HLgrocery.Data.Reposittories
{
    public interface IFooterRepository :IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
