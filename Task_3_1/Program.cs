namespace Task_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = Convert.ToInt32 ( Console.ReadLine() );
           int b = Convert.ToInt32 ( Console.ReadLine() );

            if (a > b)
            {
                Console.WriteLine($"{a} > {b} ");

            }
            if (a < b)
            {
                Console.WriteLine($"{a} < {b} ");
            }
            if (a == b)
            {
                Console.WriteLine($"{a} = {b} ");
            }

        }
    }
}
