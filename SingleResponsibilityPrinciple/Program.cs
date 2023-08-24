// See https://aka.ms/new-console-template for more information
using SingleResponsibility;

Console.WriteLine("Hello, World!");

Customer c= new Customer(); 
Customer customer = new Customer();
customer.CustId = 1; customer.CustName = "Salini"; customer.Email = "salini@gmail.com";
Customer customer2 = new Customer();
customer2.CustId = 2; customer2.CustName = "Sameer"; customer2.Email = "sameer@gmail.com";
c.AddCustomer(customer);
c.AddCustomer(customer2);


//Console.WriteLine("Enter Id");
//var Cid = Convert.ToInt32(Console.ReadLine());
//c.GetCustomerByID(Cid);

Console.WriteLine();

c.GetAll();