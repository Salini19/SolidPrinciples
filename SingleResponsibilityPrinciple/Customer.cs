using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    internal class Customer : ICustomer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Email  { get; set; }

        List<Customer> list = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            try
            {
                
                list.Add(customer);
               
                Console.WriteLine("Customer Added");
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message });
            }
          
        }

        public void GetAll()
        {
            try
            {
               
                Console.WriteLine("Customer List");
                foreach(Customer cust in list)
                {

                    Console.WriteLine("Customer details");
                    Console.WriteLine("Customer Id : ", cust.CustId);
                    Console.WriteLine("Customer Name : ", cust.CustName);
                    Console.WriteLine("Customer Email : ", cust.Email);
                    Console.WriteLine();
                }
                
            }
            catch (Exception ex)
            {

                ErrorLog.WriteLog(new string[] { ex.Message });
            }
            
        }
        

        public void GetCustomerByID(int id)
        {
            try
            {
               
               var cust= list.Find(x => x.CustId == id);

                Console.WriteLine("Customer details");
                Console.WriteLine("Customer Id : ",cust.CustId);
                Console.WriteLine("Customer Name : ", cust.CustName);
                Console.WriteLine("Customer Email : ", cust.Email);
                Console.WriteLine();
                
            }
            catch (Exception ex)
            {
                ErrorLog.WriteLog(new string[] { ex.Message });
            }
         
        }

        public void UpdateCustomer(Customer cust)
        {
            try
            {
                Console.WriteLine("Customer details updated");
            }
            catch (Exception ex)
            {
                ErrorLog.WriteLog(new string[] { ex.Message });
            }
      
        }
    }
}
