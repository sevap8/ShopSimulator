using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSimulator.Core.Models
{
    public class TradingHistoryEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ShopName { get; set; }
        public string ProductName { get; set; }
        public DateTime Time { get; set; }
        public decimal Cost { get; set; }
    }
}
