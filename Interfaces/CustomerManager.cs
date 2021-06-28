namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) {

            customerDal.Add();
        
        
        }
    }
}
