using System;

namespace DatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirtDate = new DateTime(1999, 09, 23);
            //Console.WriteLine(myBirtDate.ToLongDateString());

            DateTime myBirthDay = DateTime.Parse("09/23/1999");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthDay);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
