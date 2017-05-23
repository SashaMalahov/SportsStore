using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class ProductRepository: IProductRepository
    {
        private DBContext _context = new DBContext();

        public IQueryable<Product> Products => _context.Products;
    }
}
