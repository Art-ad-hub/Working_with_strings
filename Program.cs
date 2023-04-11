using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            string userZodiac;
            string userWork;
            string userAgeRead;
            
            Console.Write("Введите свое имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            userAgeRead = Console.ReadLine();
            userAge = Convert.ToInt32(userAgeRead);
            Console.Write("Введите свой знак зодиака: ");
            userZodiac = Console.ReadLine();
            Console.Write("Введите ваше место работы: ");
            userWork = Console.ReadLine();

            Console.WriteLine($"Ваше имя {userName}, Вам {userAge} лет и по знаку задиака вы {userZodiac},а место вашей работы {userWork}.");
            Console.ReadKey();
        }
    }
}