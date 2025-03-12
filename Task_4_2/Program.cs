namespace Task_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            double n = Convert.ToInt32(Console.ReadLine());
            double s = 1;

            for (double i = 2; i <= n; i++)
            {

                s =  s + 1.0 / i ; 

            }
            Console.WriteLine(s);
        }
    }
}
