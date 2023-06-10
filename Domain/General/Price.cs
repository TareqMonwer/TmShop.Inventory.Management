using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmShop.Inventory.Management.Domain.General
{
    public class Price
    {
        public double ItemPrice { get; set; }
        public Currency Currency { get; set; }

        public override string ToString()
        {
            return $"{Currency}{ItemPrice}";
        }

        public Price()
        {
        }

        public Price(double price, Currency currency) {
            ItemPrice = price ;
            Currency = currency;
        }
    }
}
