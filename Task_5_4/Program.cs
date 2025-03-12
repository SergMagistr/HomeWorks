namespace Task_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;

            int[] t = new int[n];
            Random r = new Random();

            
            for (int i = 0; i < n; i++)
            {
                t[i] = r.Next(-50, 51); // Диапазон [-50, 50]
                Console.Write($" {t[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < n / 2 - 1; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                {
                    if (t[j] > t[j + 1]) 
                    {
                        
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                    }
                }
            }

            
            for (int i = n / 2; i < n - 1; i++)
            {
                for (int j = n / 2; j < n - 1 - (i - n / 2); j++)
                {
                    if (t[j] < t[j + 1]) 
                    {
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($" {t[i]}");
            }

        }
    }
}
