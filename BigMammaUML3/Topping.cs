using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Topping: MenuItem
    {
        public Topping(int number, string name, string description, double price, MenuType menuType, bool isVegan, bool isOrganic) : base(number, name, description, price, menuType, isVegan, isOrganic)
        {
        }
    }
}
