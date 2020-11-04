using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class MenuItemNumberExist: Exception
    {
        public MenuItemNumberExist(string message): base(message)
        {
        }
    }
}
