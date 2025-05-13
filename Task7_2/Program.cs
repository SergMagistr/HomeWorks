namespace Task7_2
{
    class Program
    {
        // Метод для вычисления объема и площади поверхности куба
        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = Math.Pow(edgeLength, 3);             // V = a³
            surfaceArea = 6 * Math.Pow(edgeLength, 2);    // S = 6a²
        }

        static void Main()
        {
            Console.Write("Введите длину ребра куба: ");
            double a = double.Parse(Console.ReadLine());

            // Вызов метода с out-параметрами
            CalcCube(a, out double v, out double s);

            Console.WriteLine($"Объем куба: {v}");
            Console.WriteLine($"Площадь поверхности куба: {s}");
        }
    }
}
