namespace Abstract_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KrediKarti krediKarti = new KrediKarti();
            krediKarti.OdemeYap(45);
            Console.WriteLine();
            BankaHavalesi bankaHavalesi = new BankaHavalesi();
            bankaHavalesi.OdemeYap(450);
            Console.WriteLine();
            SanalKart sanalKart = new SanalKart();
            sanalKart.OdemeYap(1500.85);
        }
    }
    public abstract class OdemeYontemi
    {
        public void Log(string mesaj)
        {
            Console.WriteLine($"Log: {mesaj}");
        }
        public abstract void OdemeYap(double miktar);
    }
    public class KrediKarti : OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"{miktar} TL ödendi."); ;
            Log("Kredi kartı işlemi başarılı");
        }
    }
    public class BankaHavalesi : OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"{miktar} TL havale yapıldı."); ;
            Log("Havale işlemi başarılı.");
        }
    }
    public class SanalKart : OdemeYontemi
    {
        public override void OdemeYap(double miktar)
        {
            Console.WriteLine($"Sanal kart ile {miktar} TL ödendi");
            Log("Sanal kart ödeme işlemi başarılı.");
        }
    }
}

