namespace Task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            int[] t = new int[n];
            Random r = new Random();
            int s = 0;


            for (int i = 0; i < n; i++)

            {
                t[i] = r.Next(-20,20);
                s += t[i];
                Console.WriteLine(t[i]);
            }
            Console.WriteLine();

            int minus = 0;
            int plus = 0;
            int nul = 0;


            for (int i = 0; i < n; i++)
            {
                if(t[i] > 0)
                {
                   plus++;
                }    
                else if(t[i] < 0)
                {  minus++; }
                else
                {
                    nul++;
                }

            }

            Console.WriteLine(($"Положительных: {plus}"));
            Console.WriteLine(($"Отрицательных: {minus}"));
            Console.WriteLine(($"Нулевых: {nul}"));
        }
    }
}
