using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmShop.Inventory.Management.Domain.ProductManagement
{
    public partial class Product
    {
        public static int StockTreshold = 5;

        public static void ChangeStockTreshold(int newStockTreshold)
        {
            if (newStockTreshold > 0)
            {
                StockTreshold = newStockTreshold;
            }
        }

        private void DecreaseStock(int items, string reason)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;
            }
            else
            {
                AmountInStock = 0;
            }

            UpdateLowStock();

            Log(reason);
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name})";
        }

        private void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void UpdateLowStock()
        {
            if (AmountInStock < StockTreshold)
            {
                IsBelowStockTreshold = true;
            }
        }
    }
}
