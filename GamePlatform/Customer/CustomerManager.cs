using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Customer
{
    public class CustomerManager:ICustomerService
    {
        CustomerVerificationManager _customerVerificationManager;
        public CustomerManager(CustomerVerificationManager customerVerificationManager)
        {
            _customerVerificationManager = customerVerificationManager;
        }
        public void Add(Customers customer )
        {
            if (_customerVerificationManager.UserIfRealPerson(customer)==true)
            {
                Console.WriteLine("Kullanıcı eklendi");
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri yanlış");
            }
        }

        public void Update(Customers customer)
        {
            Console.WriteLine("Kullanıcı güncellendi");
        }

        public void Delete(Customers customer)
        {
            Console.WriteLine("Kullanıcı silindi");
        }
    }
}
