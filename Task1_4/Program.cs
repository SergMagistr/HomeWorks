using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            // читаем ввдеенное число 
            int first = number / 1000; // первая цифра 
            int second = (number / 100) % 10; // вторая цифра 

            int third = (number / 10) % 10; // третья цифра  
            int fourth = number % 10; // четрвертая цифра 

            Console.WriteLine($"Замена: {first}{fourth}{third}{second}" );
        }
    }
}
