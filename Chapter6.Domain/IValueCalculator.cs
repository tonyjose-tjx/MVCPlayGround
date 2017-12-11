using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6.Domain.Models
{
    public interface IValueCalculator
    {

        decimal GetTotalValueOfProducts(IEnumerable<Product> product);
    }
}
