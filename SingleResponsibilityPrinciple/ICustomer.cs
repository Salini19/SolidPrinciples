using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal interface ICustomer
    {
        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer cust);

        void GetAll();

       void GetCustomerByID(int id);
    }
}
