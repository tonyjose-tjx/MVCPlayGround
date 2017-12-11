using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCSportsStorePractice.Domain.Entities;

namespace MVCSportsStorePractice.Domain.Abstract
{
    public interface IProductRespository
    {

        IQueryable<Product> GetAllProducts();

    }
}
