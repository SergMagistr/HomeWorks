namespace Task_3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int a = Convert.ToInt32(Console.ReadLine());


                if (a < -10 && a > 10)
                {
                    Console.WriteLine($"Да , число {a} попадает куда нужно ");

                }
                else if (!(a < -10 && a > 10))
                {
                    Console.WriteLine($"Нет, число {a} не верное");
                }

                Console.ReadKey();

            }
        }
    }
}
