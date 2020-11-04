using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaUML3
{
    public class CustomerCatalog: ICustomerCatalog
    {
        private List<ICustomer> customers;

        public CustomerCatalog()
        {
            customers = new List<ICustomer>();
        }

        public int Count
        {
            get { return customers.Count; }
        }
        public void AddCustomer(ICustomer aCustomer)
        {
            customers.Add(aCustomer);
        }

        public ICustomer LookupCustomerName(string name)
        {
            throw new NotImplementedException();
        }

        public ICustomer LookupCustomerID(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string phoneNo, ICustomer theCustomer)
        {
            throw new NotImplementedException();
        }

        public void PrintCustomerList()
        {
            foreach (ICustomer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}
