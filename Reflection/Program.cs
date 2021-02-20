using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dortİslem dortİslem = new Dortİslem(2, 4);
            //Console.WriteLine(dortİslem.Carp2());
            //Console.WriteLine(dortİslem.Carp(3,4));

            var tip = typeof(Dortİslem);
            //Dortİslem dortislem = (Dortİslem)Activator.CreateInstance(tip,6,7);
            //dortislem.Topla(4, 5);
            //Console.WriteLine(dortislem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance,null));

            var methodlar = tip.GetMethods();
            foreach (var info in methodlar)
            {
                Console.WriteLine("Method ismi: " + info.Name);
                foreach (var  parameterInfo in info.GetParameters())
                {
                    Console.WriteLine( parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            }
        }
    }

    public class Dortİslem
    {
        private int _sayi1;
        private int _sayi2;

        public Dortİslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MethodNameAttribute:Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
