using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo();


            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
            
                new SQLServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SQLServerCustomerDal());
        }
    }
}
