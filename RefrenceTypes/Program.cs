using System;

namespace RefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean -->Value Types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1: " + sayi1);
            //arrays,class,interface -->Refrance Types
            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 55;
            //Console.WriteLine(sayilar1[0]);

            string ifade1 = "1";
            string ifade2 = "20";
            ifade1 = ifade2;
            ifade2 = "100";
            Console.WriteLine(ifade1);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);
            



            Customer customer = new Customer();
            customer.CreditCardNumber = "34232342345234";
            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            
            Employee employee = new Employee();


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {

        }
    }
}
