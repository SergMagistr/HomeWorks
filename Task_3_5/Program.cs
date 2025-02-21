namespace Task_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

           int  b = a % 10; 

            if (b == 0) 
            {
                Console.WriteLine($"Да, число {a} оканчивается на 0");

            }
            else 
            {
                Console.WriteLine($"Нет, число {a} не оканчивается на 0");
            }

            Console.ReadKey();

            //profit

        }
    }
}
