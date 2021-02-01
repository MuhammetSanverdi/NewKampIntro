using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.Customer
{
    public class CustomerVerificationManager:ICustomerVerificationService
    {
        public CustomerVerificationManager()
        {
            Console.WriteLine("Bilgileriniz kontrol ediliyor...");
        }

        public bool UserIfRealPerson(Customers customer)
        {
            if (customer.BirthYear == 1997 && customer.FirstName == "Muhammet" && customer.LastName == "Şanverdi" && customer.IdentificationNumber == 2341343124)
            {
                return true;
            }
            else
            {
                return false;
            }
            


        }
    }
}
