namespace YemekSiparisSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restoran restoran = new Restoran();
            while (true)
            {
                Console.Write("\nYemek Sipariş Uygulaması\n*******************\n1-Menü Ekle\n2-Menüleri Göster\n3-Menü Sil\n4-Sipariş Al\n5-Siparişleri Görüntüle\n6-Sipariş Sil\n7-Çıkış\n*******************\nLütfen yapmak istediğiniz işlemi seçiniz: ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        menuEkle(restoran);
                        break;
                    case "2":
                        Console.Clear();
                        restoran.MenuyuGoster();
                        break;
                    case "3":
                        menuSil(restoran);
                        break;
                    case "4":
                        siparisAl(restoran);
                        break;
                    case "5":
                        Console.Clear();
                        restoran.SiparisleriGoster();
                        break;
                    case "6":
                        siparisSil(restoran);
                        break;
                    case "7":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Lütfen geçerli bir giriş yapınız!!");
                        break;
                }
            }
        }
        public static void menuEkle(Restoran restoran)
        {
            Console.Clear();
            Console.Write("Lütfen Ana Yemek Adını Giriniz: ");
            string anaYemekAdi = Console.ReadLine();
            Console.Write("Lütfen Ana Yemek Fiyatını Yazını: ");
            double anaYemekFiyati = double.Parse(Console.ReadLine());
            AnaYemek a = new AnaYemek(anaYemekAdi, anaYemekFiyati);

            Console.Write("Lütfen Tatlı Adını Giriniz: ");
            string tatliAdi = Console.ReadLine();
            Console.Write("Lütfen Tatlı Fiyatını Yazını: ");
            double tatliFiyati = double.Parse(Console.ReadLine());
            Tatli t = new Tatli(tatliAdi, tatliFiyati);

            Console.Write("Lütfen İçecek Adını Giriniz: ");
            string icecekAdi = Console.ReadLine();
            Console.Write("Lütfen İçecek Fiyatını Yazını: ");
            double icecekFiyati = double.Parse(Console.ReadLine());
            Icecek i = new Icecek(icecekAdi, icecekFiyati);

            restoran.MenuEkle(a, t, i);
            Console.Clear();
        }
        public static void menuSil(Restoran restoran)
        {
            if (restoran.menuler.Count > 0)
            {
                Console.Clear();
                restoran.MenuyuGoster();
                Console.Write("Lütfen silmek istediğiniz menü numarasını giriniz: ");
                int silmeNumarasi = int.Parse(Console.ReadLine());
                restoran.MenuSil(restoran.menuler[silmeNumarasi - 1]);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Menü eklenmediği için silemezsiniz!");
            }
        }
        public static void siparisAl(Restoran restoran)
        {
            Console.Clear();
            restoran.MenuyuGoster();

            if (restoran.menuler.Count > 0)
            {
                Console.Write("Lütfen sipariş vermek istediğiniz menü numarasını giriniz: ");
                int siparisNo = int.Parse(Console.ReadLine());
                if (siparisNo - 1 <= restoran.menuler.Count && siparisNo - 1 >= 0)
                {
                    restoran.SiparisAl(restoran.menuler[siparisNo - 1]);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sipariş vermek istediğiniz menü bulunamadı.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Eklenen menü olmadığı için sipariş veremezsiniz");
            }
        }
        public static void siparisSil(Restoran restoran)
        {
            if (restoran.siparisler.Count > 0)
            {
                Console.Clear();
                restoran.SiparisleriGoster();
                Console.Write("Lütfen silmek istediğiniz sipariş numarasını giriniz: ");
                int silmeNumarasi = int.Parse(Console.ReadLine());
                restoran.SiparisSil(restoran.siparisler[silmeNumarasi - 1]);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Sipariş verilmediği için silemezsiniz!");
            }
        }
    }
    public class Yemek
    {
        public string YemekAdi { get; set; }
        public double YemekFiyati { get; set; }
        public Yemek(string adi, double fiyati)
        {
            YemekAdi = adi;
            YemekFiyati = fiyati;
        }

        public virtual string YemekBilgisiYazdir()
        {
            return "Herhangi bir yemek bilgisi yok!";
        }
    }
    public class AnaYemek : Yemek
    {
        public AnaYemek(string anaYemekAdi, double anayemekFiyati) : base(anaYemekAdi, anayemekFiyati)
        {

        }

        public override string YemekBilgisiYazdir()
        {
            return $"Ana yemek adı: {YemekAdi}, fiyatı: {YemekFiyati}  TL";
        }
    }
    public class Tatli : Yemek
    {
        public Tatli(string tatliAdi, double fiyati) : base(tatliAdi, fiyati)
        {

        }

        public override string YemekBilgisiYazdir()
        {
            return $"Tatlı adı: {YemekAdi}, fiyatı: {YemekFiyati} TL";
        }
    }
    public class Icecek : Yemek
    {
        public Icecek(string icecekAdi, double fiyati) : base(icecekAdi, fiyati)
        {

        }
        public override string YemekBilgisiYazdir()
        {
            return $"İçecek adı: {YemekAdi}, fiyatı: {YemekFiyati} TL";
        }
    }
    public class Menu
    {
        public AnaYemek AnaYemek { get; set; }
        public Tatli Tatli { get; set; }
        public Icecek Icecek { get; set; }
        public Menu(AnaYemek anaYemek, Tatli tatli, Icecek icecek)
        {
            AnaYemek = anaYemek;
            Tatli = tatli;
            Icecek = icecek;
        }
        public double ToplamFiyatHesapla()
        {
            return AnaYemek.YemekFiyati + Tatli.YemekFiyati + Icecek.YemekFiyati;
        }
    }
    public class Siparis
    {
        public Menu Menu { get; set; }
        public Siparis(Menu menu)
        {
            Menu = menu;
        }
    }
    public class Restoran
    {
        public List<Menu> menuler = new List<Menu>();
        public List<Siparis> siparisler = new List<Siparis>();

        public void MenuEkle(AnaYemek anaYemek, Tatli tatli, Icecek icecek)
        {
            Menu menu = new Menu(anaYemek, tatli, icecek);
            menuler.Add(menu);
        }
        public void MenuyuGoster()
        {
            if (menuler.Count > 0)
            {
                for (int i = 0; i < menuler.Count; i++)
                {
                    Menu menu = menuler[i];
                    Console.WriteLine($"\nMenuler\n**********\n{i + 1}. Menü\n{menu.AnaYemek.YemekBilgisiYazdir()}\n{menu.Tatli.YemekBilgisiYazdir()}\n{menu.Icecek.YemekBilgisiYazdir()}\nToplam fiyat: {menu.ToplamFiyatHesapla()} TL\n**********");
                }
            }
            else
            {
                Console.WriteLine("Henüz eklenen menü bulunmamaktadır.");
            }
        }
        public void MenuSil(Menu menu)
        {
            menuler.Remove(menu);
        }
        public void SiparisAl(Menu menu)
        {
            siparisler.Add(new Siparis(menu));
        }

        public void SiparisleriGoster()
        {
            if (siparisler.Count > 0)
            {
                for (int i = 0; i < siparisler.Count; i++)
                {
                    Menu siparis = siparisler[i].Menu;
                    Console.WriteLine($"\nSiparişler\n**********\n{i + 1}. Menü\n {siparis.AnaYemek.YemekBilgisiYazdir()}\n{siparis.Tatli.YemekBilgisiYazdir()}\n{siparis.Icecek.YemekBilgisiYazdir()}\nToplam fiyat: {siparis.ToplamFiyatHesapla()} TL\n**********");
                }
            }
            else
            {
                Console.WriteLine("Henüz sipariş verilmemiş!");
            }
        }
        public void SiparisSil(Siparis siparis)
        {
            siparisler.Remove(siparis);
        }
    }
}
