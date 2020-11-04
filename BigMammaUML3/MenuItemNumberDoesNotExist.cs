using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class MenuItemNumberDoesNotExist: Exception
    {
        public MenuItemNumberDoesNotExist(string message):base(message)
        {
        }
    }
}
