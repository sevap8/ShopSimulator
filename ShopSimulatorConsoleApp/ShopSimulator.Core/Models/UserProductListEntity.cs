using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSimulator.Core.Models
{
    public class UserProductListEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string QuantityOfGoods { get; set; }
        public string Owner { get; set; }
    }
}
