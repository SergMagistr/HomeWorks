namespace Task_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
           double b = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b > 0)

            {
                double s = 1;
                for (int i = 0; i < b; i++)
                {
                    s = s * a;
                }
                Console.WriteLine($"{a} в степени {b}= {s} ");
            }

            else if (a > 0 && b < 0)

            {
                double s = 1;
                b = -1 * b;
                for (double i = 0; i < b; i++)
                {
                    s =s * a;
                }
                Console.WriteLine($"{a} в степени {b}= {1.0 / s}");
            }

            else
            {
                Console.WriteLine("Ввведите положительные значения");
            }

        }
    }
}
