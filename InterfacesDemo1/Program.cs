using System;

namespace InterfacesDemo1
{
    class Program
    {
        //İnterface new'lenemez.
        static void Main(string[] args)
        {
            IPersonalManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonalManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    //class PersonalManager
    //{
    //    //implamented operator
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}
    interface IPersonalManager
    {
        //unimplamented operator
        void Add();
        void Update();
    }
    //inherits - class ----- implaments - interface
    class CustomerManager:IPersonalManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager:IPersonalManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager:IPersonalManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonalManager personalManager)
        {
            personalManager.Add();
        }
    }
}
