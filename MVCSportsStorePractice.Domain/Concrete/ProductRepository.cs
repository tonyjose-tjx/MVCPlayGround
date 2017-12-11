using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCSportsStorePractice.Domain.Abstract;
using MVCSportsStorePractice.Domain.Entities;

namespace MVCSportsStorePractice.Domain.Concrete
{
    public class ProductRepository : IProductRespository
    {

        private EFDbContext _efDbSet;


        public ProductRepository()
        {
            _efDbSet = new EFDbContext();
        }

        public IQueryable<Product> GetAllProducts()
        {
            return _efDbSet.Products;
        }
    }
}
