namespace Task_3_2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"Большее {a}");
            }
            else if (b >= c)
            {
                Console.WriteLine($"Большее {b}");
            }
            else
            {
                Console.WriteLine($"Большее {c}");
            }
            Console.ReadKey();


        }
    }
}
