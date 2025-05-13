namespace Task7_1
{
    class Program
    {
        // Метод для вычисления площади треугольника по формуле Герона
        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2; // Полупериметр
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Формула Герона
            return area;
        }

        static void Main()
        {
            Console.WriteLine("Введите стороны первого треугольника (a, b, c):");
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника (a, b, c):");
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double c2 = double.Parse(Console.ReadLine());

            // Вычисляем площади
            double area1 = Square(a1, b1, c1);
            double area2 = Square(a2, b2, c2);

            // Сравниваем площади
            if (area1 > area2)
            {
                Console.WriteLine($"Площадь первого треугольника ({area1}) больше, чем второго ({area2}).");
            }
            else if (area1 < area2)
            {
                Console.WriteLine($"Площадь второго треугольника ({area2}) больше, чем первого ({area1}).");
            }
            else
            {
                Console.WriteLine($"Площади треугольников равны ({area1}).");
            }
        }
    }
}
