using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class Customer: ICustomer
    {
        public int Id { get; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address;}
            set { _address = value; }
        }
        public string PhoneNo { get; set; }

        public Customer(string name, string address, int id, string phoneNo)
        {
            _name = name;
            _address = address;
            Id = id;
            PhoneNo = phoneNo;
        }

        public override string ToString()
        {
            return $"ID {Id} || Name {_name} || Address {_address} || PhoneNo. {PhoneNo}";
        }
    }
}
