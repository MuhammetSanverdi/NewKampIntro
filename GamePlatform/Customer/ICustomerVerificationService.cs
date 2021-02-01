using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Customer
{
    public interface ICustomerVerificationService
     
    {
        bool UserIfRealPerson(Customers customer);
    }
}
