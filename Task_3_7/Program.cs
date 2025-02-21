namespace Task_3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());


            if (a > -100 && a < 100)
            {
                Console.WriteLine($"Да , число {a} двухзначное ");

            }
            else if (!(a > -100 && a < 100))
            {
                Console.WriteLine($"Нет, число {a} не двузначное");
            }

            Console.ReadKey();
        }
    }
}
