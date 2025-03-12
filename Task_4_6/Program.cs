namespace Task_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 1)

            {
                n = n / 2; ;
            }

            if (n % 2 == 0) 
            {
                Console.WriteLine("Да");
            }

            else 
            {
                Console.WriteLine("Нет");
            }


        }
    }
}
