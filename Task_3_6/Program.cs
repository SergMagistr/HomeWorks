namespace Task_3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a % 2;

            if (b == 0)
            {
                Console.WriteLine($"Да, число {a} чётное");

            }
            else
            {
                Console.WriteLine($"Нет, число {a} не четкое");
            }

            Console.ReadKey();

        }
    }
}
