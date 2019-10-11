using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSimulator.Core.Models
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Money { get; set; }
    }
}
