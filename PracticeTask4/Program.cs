namespace PracticeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5000 метров - это {MetersToKilometres(5000)} километров");
            Console.WriteLine($"2 километра - {KilometersToCentimeters(2)} сантиметров");
            Console.WriteLine($"36 км\\ч  - это {KmphToMps(36)} м\\с");
            Console.WriteLine($"10 градусов по цельсию - это {CelsiumToFarenheit(10)} градусов в Фаренгейтах");

            double MetersToKilometres(double meter)
            {
                double kilometers = meter / 1000;
                return kilometers;
            }

            double KilometersToCentimeters(double kilometer)
            {
                double centimeters = kilometer / 100000;
                return centimeters;
            }

            double KmphToMps(double kmph)
            {
                double mps = kmph / 3.6;
                return mps;
            }

            double CelsiumToFarenheit(double celsium)
            {
                double farenheit = ((celsium * 9) / 5) + 32;
                return farenheit;
            }
        }
    }
}