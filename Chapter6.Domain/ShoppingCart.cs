using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6.Domain.Models
{
    class ShoppingCart
    {

        private LinqValueCalculator _calc;
        public ShoppingCart(IValueCalculator calc)
        {

        }

        public decimal GetTotalValueOfProducts(IEnumerable<Product> products)
        {
            return _calc.GetTotalValueOfProducts(products);
        }

    }
}
