using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6.Domain.Models
{
    public interface IDiscountCalculator
    {
        decimal GetDiscountedValue(decimal price);
    }

    public class DiscountCalculator : IDiscountCalculator
    {

        public decimal DiscountInPercentage { get; set; }

        public decimal GetDiscountedValue(decimal price)
        {
            return price * DiscountInPercentage/100;
        }
    }


   


}
