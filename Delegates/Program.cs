using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("sdfs");
            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(3, 8);
            Console.WriteLine(sonuc);

        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert2(string message)
        {
            Console.WriteLine("Be careful!");
        }
    }

    public class Matematik
    {
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
