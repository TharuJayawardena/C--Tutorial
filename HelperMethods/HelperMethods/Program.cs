using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();
            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = " ";

            foreach(char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach(char item in lastNameArray)
            {
                result += item;
            }
            Console.WriteLine("Results: " + result);*/


            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.WriteLine();

            DisplayResult(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
           
             char[] messageArray = message.ToCharArray();
             Array.Reverse(messageArray);
             return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName,string reveresedLastName, string reveresedCity)
        {
            Console.Write("Results: ");

            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reveresedLastName, reveresedCity));
        }
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");

            Console.Write(message);



        }
    }
}
