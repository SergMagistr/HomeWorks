namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // s = 1*2*3*4*5*6

            int n = Convert.ToInt32(Console.ReadLine());
            int s = 1;

            for (int i = 1; i <= n; i++)
            {
             s = s * i;
            }
                Console.WriteLine(s);
        }
    }
}
