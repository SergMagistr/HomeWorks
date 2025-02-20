namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задаём дюймы 
            double dm = Convert.ToInt32 (Console.ReadLine());

            // 1. переводим в сантиметры 
            double sm = dm * 2.54;
            // 2. переводим в метры 
            double metr = sm / 100;
            // 3. переводим в милиметры 
            double mm = metr * 1000.0;

            Console.WriteLine ("{0} дюймов это: {1} сантиметра  , {2} метра , {3} милимметров ", dm, sm , metr, mm);

        }
    }
}
