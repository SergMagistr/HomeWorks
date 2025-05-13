namespace Task7_3
{
   class Program
{
    static void PrintNumbers(int[] numbers, bool reverse = false)
    {
        if (reverse)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine(); // Переход на новую строку после вывода
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        PrintNumbers(numbers);      // Вывод: 1 2 3 4 5
        PrintNumbers(numbers, true); // Вывод: 5 4 3 2 1
    }
}
}
