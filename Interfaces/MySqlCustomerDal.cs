using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MySqlCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated");
        }
    }


}

