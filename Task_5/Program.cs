namespace Task_5
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
                t[i] = r.Next(0, 100);
                s += t[i];
                Console.WriteLine(t[i]);
            }
            Console.WriteLine();

            int even = 0;
            int notEven = 0;


            for (int i = 0; i < n; i++)
            {
                if (t[i] % 2 == 0)
                { even++; }
                else { notEven++; }

            }

            Console.WriteLine(($"Чётных: {even}"));
            Console.WriteLine(($"НеЧётных: {notEven}"));

        }
    }
}
