using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public interface ICustomer
    {
            int Id { get; }
            string Name { get; set; }
            string Address { get; set; }
            string PhoneNo { get; set; }
    }

}
