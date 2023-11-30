using System.Reflection;

namespace PolimerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AracKiralamaServisi aks = new AracKiralamaServisi();
            //Console.WriteLine("Lütfen araç modelini giriniz: ");
            //string model = Console.ReadLine();
            //Console.WriteLine("Lütfen kiralama bedelini giriniz: ");
            //double kiralamaBedeli = double.Parse(Console.ReadLine());
            aks.aracEkle(new Otomobil("Toyota", 600));
            aks.aracEkle(new Kamyon("Scania", 1500));
            aks.kiralamaBilgileriniGoster();

            Otomobil oto = new Otomobil("BMW", 100);
            Console.WriteLine(oto.KiraHesapla(5));
            Kamyon k = new Kamyon("Scania", 1500);
            Console.WriteLine(k.KiraHesapla(5));
        }
    }
    public class Arac
    {
        public string Model { get; set; }
        public string AracTipi { get; set; }

        public double KiralamaBedeli { get; set; }
        public Arac(string model, double kiralamaBedeli, string aracTipi)
        {
            Model = model;
            KiralamaBedeli = kiralamaBedeli;
            AracTipi = aracTipi;
        }
        public virtual double KiraHesapla(int gun)
        {
            return gun * KiralamaBedeli;
        }
    }
    public class Otomobil : Arac
    {
        public Otomobil(string model, double kiralamaBedeli) : base(model, kiralamaBedeli, "Otomobil")
        {
        }
        public override double KiraHesapla(int gun)
        {
            return base.KiraHesapla(gun);
        }
    }
    public class Kamyon : Arac
    {
        public Kamyon(string model, double kiralamaBedeli) : base(model, kiralamaBedeli, "Kamyon")
        {
        }
        public override double KiraHesapla(int gun)
        {
            return base.KiraHesapla(gun) + gun * 200;
            //return gun * (KiralamaBedeli + 200);
        }

    }
    public class AracKiralamaServisi
    {
        public List<Arac> araclar = new List<Arac>();
        public void aracEkle(Arac yeniArac)
        {
            araclar.Add(yeniArac);
        }
        public void kiralamaBilgileriniGoster()
        {
            foreach (var item in araclar)
            {
                Console.WriteLine($"{item.Model} - Günlük ücreti: {item.KiraHesapla(1)}");
            }
        }
    }
}