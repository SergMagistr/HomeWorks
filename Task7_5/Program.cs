namespace Task7_5
{
    class Program
    {
        // Метод для умножения целых чисел
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Метод для умножения дробных чисел
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main()
        {
            Console.WriteLine(Multiply(2, 3));        
            Console.WriteLine(Multiply(2.5, 3.5));    

           
        }
    }
}
