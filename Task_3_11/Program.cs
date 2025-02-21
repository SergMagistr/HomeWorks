namespace Task_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Размеры участка");
            Console.WriteLine("Длина:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ширина:");
            int b = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine("Введите Размеры 1го дома");
            int h1 = Convert.ToInt32(Console.ReadLine()); //  
            int d1 = Convert.ToInt32(Console.ReadLine()); //  

            Console.WriteLine("Введите Размеры 2го дома");
            int h2 = Convert.ToInt32(Console.ReadLine()); //  
            int d2 = Convert.ToInt32(Console.ReadLine());

            // проверим два условия : могут ли дома стоять рядом вдоль ширины участка либо вдоль длины участка. 
            // если что-то одно выполниться - то дома можно расположить 

            if ((h1 + h2 <= a) && Math.Max(d1, d2) <= b) // Дом 1 и Дом 2 ставим параллельно по длине участка
            {

                if ((d1 + d2 <= b) && Math.Max(h1, h2) <= b) // Дом 1 и Дом 2 ставим параллельно по ширине участка
                {
                    Console.WriteLine("Ура, дома влезают");

                }
                Console.WriteLine("Дома не влезают");
            }
            Console.WriteLine("Дома не влезают");



        }
    }
}
