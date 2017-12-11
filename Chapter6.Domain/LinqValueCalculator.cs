using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Chapter6.Domain.Models;

namespace Chapter6.Domain.Models
{
    public class LinqValueCalculator :IValueCalculator
    {

        IDiscountCalculator _disc;

        public LinqValueCalculator(IDiscountCalculator disc)
        {
            _disc = disc;
        }

        public decimal GetTotalValueOfProducts(IEnumerable<Product> products)
        {
          decimal price =  products.Select(o => o.Price).DefaultIfEmpty(0).Sum(o => o);
          return  price = _disc.GetDiscountedValue(price);
        }
    }
}
