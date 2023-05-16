using System;
using System.Collections.Generic;
using System.Text;

namespace PCPartsStore.Models
{
    public class User
    {
        public List<Order> Orders = new List<Order>(); 
        public string Username { get; set; }
        public UserCategory Category { get; set; }
        public string UserFilepath { get; set; } 
    }
}
