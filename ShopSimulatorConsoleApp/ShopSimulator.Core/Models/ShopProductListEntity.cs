using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSimulator.Core.Models
{
    public class ShopProductListEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Money { get; set; }
        public int QuantityOfGoods { get; set; }
        public string Owner { get; set; }
    }
}
