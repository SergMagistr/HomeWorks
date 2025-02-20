namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            // цикл 1 = 321
            int t = c;
            c = a;
            a = t;

            // цикл 2 = 312
            int p = b;
            b = c;
            c = p;

            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
