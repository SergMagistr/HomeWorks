namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Пн");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вт");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ср");
                        break;
                    }
            }
            
        }
    }
}
