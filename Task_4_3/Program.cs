namespace Task_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 0 || b > 0)

            {
                int s = 1;
                for (int i = 0; i < b; i++)
                {
                    s = s * a;
                }
                Console.WriteLine($"{a} в степени {b}= {s} ") ; 
            }

            else 
            {
                Console.WriteLine("Ввведите положительные значения");
            }

        }
    }
}
