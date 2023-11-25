using System.Globalization;

namespace DateTimeFunk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            //Console.WriteLine(currentTime);
            //CultureInfo trCulture = new CultureInfo("tr-TR");
            //string formatlanmisZaman = currentTime.ToString("dd-MM-yyyy");
            //string formatlanmisZaman = currentTime.ToString("dd MMMM yyyy dddd");


            //int yil = currentTime.Year;
            //Console.WriteLine(yil);
            //string yil2 = yil.ToString();
            //Console.WriteLine(yil2);

            //while (true)
            //{
            //    Thread.Sleep(1000);
            //    Console.Clear();
            //    Console.WriteLine(currentTime);
            //}

            //int ay = currentTime.Month;
            //Console.WriteLine(ay);
            //int gun = currentTime.Day;
            //Console.WriteLine(gun);
            //int saat = currentTime.Hour;
            //Console.WriteLine(saat);
            //int dakika = currentTime.Minute;
            //Console.WriteLine(dakika);
            //int saniye = currentTime.Second;
            //Console.WriteLine(saniye);

            //Günün başlangıcını verir
            //Console.WriteLine(currentTime.Date);

            //Günün sonunu veren denklem
            //Console.WriteLine(currentTime.Date.AddHours(24).AddSeconds(-1));
            //Console.WriteLine(currentTime.Date.AddDays(1).AddTicks(-1));

            //Console.WriteLine(currentTime.DayOfWeek);
            //Console.WriteLine(currentTime.TimeOfDay);

            //yasş hesaplama
            DateTime bday = new DateTime(1992, 4, 8);
            int yas = DateTime.Today.Year - bday.Year;
            Console.WriteLine(yas);
        }
    }
}
