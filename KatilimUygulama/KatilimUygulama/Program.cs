using System.Security.Cryptography.X509Certificates;

namespace KatilimUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SporAraba sporAraba = new SporAraba
            //{
            //    Marka = "Ferrari",
            //    Model = "Enzo"
            //};
            //sporAraba.Calistir();
            //sporAraba.TurboAc();
            //Kamyon kamyon = new Kamyon
            //{
            //    Marka = "Scania",
            //    Model = "G400"
            //};
            //kamyon.Calistir();
            //kamyon.YukTasi();
            Kamyon kamyon = new Kamyon("Scania", "2020");
            kamyon.Calistir();
            kamyon.YukTasi();
        }
    }
    class Araba //base class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public Araba(string marka, string model)
        {
            Marka = marka;
            Model = model;
            Console.WriteLine($"{Marka}-{Model}");
        }

        public void Calistir()
        {
            Console.WriteLine($"{Marka}-{Model} araba çalıştırıldı!");
        }
    }
    class SporAraba : Araba //derived class
    {
        public string Turbo { get; set; }
        public SporAraba(string marka, string model) : base(marka, model)
        {
        }
        public void TurboAc()
        {
            Console.WriteLine($"Turbo açıldı.");
        }
    }
    class Kamyon : Araba
    {
        public Kamyon(string marka, string model) : base(marka, model)
        {

        }
        public void YukTasi()
        {
            Console.WriteLine("Yük taşınıyor...");
        }
    }
}
