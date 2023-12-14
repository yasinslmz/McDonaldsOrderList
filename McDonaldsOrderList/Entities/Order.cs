using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonaldsOrderList.Entities
{
    //[Serializable]
    public class Order
    {
        public int Id { get; set; }

        public string OrderStatus { get; set; }

        public List<Product> Products { get; set; }

    }
}
