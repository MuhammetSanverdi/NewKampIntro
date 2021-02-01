using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db:"+ customer.FirstName);
        }
    }
}
