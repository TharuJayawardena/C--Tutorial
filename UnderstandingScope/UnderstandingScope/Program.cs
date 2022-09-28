using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string K = "";
        static void Main(string[] args)
        {
 
            string j = "";
            for(int i=0; i<10; i++)
            {
                j = i.ToString();
                K = i.ToString(); 
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();

                }
               // Console.WriteLine(l);
            }
            //Console.WriteLine(i);
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + K);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();



            Console.ReadLine();
        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + K);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod()
        {
            return "Hello world";
        }
    }
}
