namespace Task_5_3
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
                t[i] = r.Next(0, 50);

                Console.WriteLine(t[i]);
            }
            Console.WriteLine();

            int max = t[0];
            int indexMax = 0;
            int min = t[0];
            int indexMin = 0;


            for (int i = 0; i < n; i++)

            {

                if (t[i] > max)
                {
                    max = t[i];
                    indexMax = i;
                }
                else if (t[i] < min)
                {
                    min = t[i];
                    indexMin = i;
                }
            }

            Console.WriteLine($"Максимальное {max} c индексом {indexMax}");
            Console.WriteLine($"Минимальное {min} c индексом {indexMin}");

        }
    }
}
