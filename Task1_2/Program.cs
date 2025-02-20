namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degeres = 200; // задаём градусы 
            int minutes = 30;// задаём минуты  
            int seconds = 40;// задаём секунды  

            

            // переводим минуты в градусы
            double minutesInDegers = minutes / 60.0 ;
            // переводим секунды в градусы
            double secondsInDegers = seconds / 3600.0;
            //сумируем все градусы 
            double allDegeres = degeres + minutesInDegers + secondsInDegers;
            // переводим в радианы 
            //  радианы = Градусы * ( пи / 180 ) 
            double radians = allDegeres * (Math.PI / 180.0);

            Console.WriteLine(radians);


        }
    }
}
