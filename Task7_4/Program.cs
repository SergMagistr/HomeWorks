namespace Task7_4
{
    class Program
    {
        static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Не передано ни одного числа");
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static void Main()
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}"); // Вывод: Max number: 30

            //  массив
            int[] nums = { 1, 8, 3, 6 };
            Console.WriteLine($"Max number: {FindMax(nums)}"); // Вывод: Max number: 8
        }
    }
}
