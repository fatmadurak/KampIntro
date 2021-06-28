using System;

namespace Interfaces
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");        }
    }

}
