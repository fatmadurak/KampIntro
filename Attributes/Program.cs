using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,LastName="Durak",Age=25};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }


    [ToTable("Customers")]
    [ToTable("tblCustomers")]
    class Customer
    {

        public int Id { get; set; }

        [RequiredProperty]
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }


    }

    class CustomerDal
    {
        [Obsolete("Dont use add,instead use addNew method")]
        public void Add(Customer customer) 
        {

            Console.WriteLine("{0},{1},{2},{3}  added.",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        
        }


        public void AddNew(Customer customer) 
        {

            Console.WriteLine("{0},{1},{2},{3}  added.", customer.Id, customer.FirstName, customer.LastName, customer.Age);

        }


    }

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    class RequiredPropertyAttribute:Attribute
    {

    }



    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute :Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
