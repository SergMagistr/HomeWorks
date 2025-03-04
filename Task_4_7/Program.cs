namespace Task_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            do
            {
                count++;
                n /= 10; 
            } while (n > 0); 

            Console.WriteLine($"Количество цифр: {count}");
        }
    }
}
