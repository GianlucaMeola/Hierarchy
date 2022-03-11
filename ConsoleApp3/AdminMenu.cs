using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AdminMenu : Menu
    {
        public string AuthCode { get; set; }
        public UserAdmin UsersMenu { get; set; }
        public ProductAdmin ProductsMenu { get; set; }
        public OrderAdmin OrdersMenu { get; set; }
    }
}
