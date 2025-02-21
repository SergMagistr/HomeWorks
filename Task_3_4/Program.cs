namespace Task_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = 0; int min = 0; int med =0;

            // Находим максимальное число
            if (a > b && a > c)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }


            // Находим минимальное число
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }

            // Медианой будет оставшееся число
            if (a != max && a != min)
            {
                med = a;
            }
            else if (b != max && b != min)
            {
                med = b;
            }
            else
            {
                med = c;
            }

            Console.WriteLine($"Среднее {med}");
            Console.ReadKey();


        }
    }
}
