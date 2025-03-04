namespace Task_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c && a > d) // если а больше всех чисел , то она наибольшее
            {
                Console.WriteLine($"Большее {a}");
            }
            else if (b > c && b > d)  // если b больше оставшихся  чисел , то она наибольшее
            {
                Console.WriteLine($"Большее {b}");
            }
            else if (c > d) // если c больше оставшихся  чисел , то она наибольшее
            {
                Console.WriteLine($"Большее {c}");
            }
            else // остаётся d
            {
                Console.WriteLine($"Большее {d}");
            }
            Console.ReadKey();
        }
    }
}
