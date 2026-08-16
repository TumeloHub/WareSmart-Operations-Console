using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareSmart_Operations_Console
{
    public class Warehouseorder
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }

        public Warehouseorder(
            int orderID,
            string customerName,
            List<Product> products)
        {
            OrderID = orderID;
            CustomerName = customerName;
            Products = products;
        }
    }
}
