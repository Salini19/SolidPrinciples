using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class CustomerMethods : ICustomer
    {
        List<Customer> list = new List<Customer>();
        public void AddCustomer(Customer cust)
        {
            try
            {
                list.Add(cust);
                Console.WriteLine("Customer Added");
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message });
            }
          
        }

        public List<Customer> GetAll()
        {
            try
            {
                return list;
                Console.WriteLine("Customer Added");
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message });
            }
        }

        public Customer GetCustomerByID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer cust)
        {
            throw new NotImplementedException();
        }
    }
}
