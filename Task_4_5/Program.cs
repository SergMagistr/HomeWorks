namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число от 20 до 60");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n < 20 || n > 60) 
            {
                Console.WriteLine("Неверное число, повторите ввод ");
                 n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введено правильное число ");
           
        }
    }
}
