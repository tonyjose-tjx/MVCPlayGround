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
            if (price < 0)
            {
                throw new ArgumentException("price cannot be less than 0");
            }
            return price * DiscountInPercentage/100;
        }
    }


    public class FelxibleDiscounter : IDiscountCalculator
    {
        public decimal GetDiscountedValue(decimal price)
        {


            if (price < 0)
            {
                throw new ArgumentException("price cannot be less than 0");
            }
            else if (price > 100)
            {
                return (price * .75m);
            }
            else if (price > 60)
            {
                return (price * .90m);
            }
            else {
                return price;
            }
        }
    }


}
