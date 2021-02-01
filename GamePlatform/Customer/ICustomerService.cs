using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Customer
{
    public interface ICustomerService
    {
        void Add(Customers customer);
        void Update(Customers customer);
        void Delete(Customers customer);
    }
}
