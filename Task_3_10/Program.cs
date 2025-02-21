namespace Task_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //  построил столько домов

            if (n == 0) 
            
            {
                Console.WriteLine($"ПИК построил {n} домов :(");
            }

            else if (n >1 && n <5 )

            {
                Console.WriteLine($"ПИК построил {n} дома :(");
            }

            else if (n > 4 )

            {
                Console.WriteLine($"ПИК построил {n} домов :)!!! ");
            }
            Console.ReadKey();

        }
    }
}
