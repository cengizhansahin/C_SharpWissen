using System.Net.WebSockets;

namespace Encasulation
{
    class MyClass
    {
        int yas = 20;
        string soyad;
        //Kısa propert örneği --> prop yazıp iki kere tab tuşuna tıklanır
        //public int yas { get; set; }
        public int Yas
        {
            get
            {
                //yas field'imiz artık property ile erişilebilir hale geldi. doğrudan yaş field'ine erişim vermiyoruz. istediğimiz kontrolü sağlayarak yas fieldini dışarıya salıyoruz.
                return yas / 2;
            }
            set
            {
                //Burada da değer ataması yapıyoruz. yani biz prop'u okumak istediğimizde get bloğu devreye girer, değer ataması yapmak istediğimizde set bloğu devreye girer ve istenilen şekilde manipüle edilebilir.
                yas = value * 2;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass m1 = new MyClass();
            //Console.WriteLine(m1.Yas);
            //m1.Yas = 100;
            //Console.WriteLine(m1.Yas);

            //Bakiye b1 = new Bakiye();
            //Console.WriteLine(b1.BakiyeHesapla);
            //b1.BakiyeHesapla = 800;
            //Console.WriteLine(b1.BakiyeHesapla);

            List<Kitap> KitapListesi = new List<Kitap>();

            Console.Write("\nLütfen Kaç Adet Kitap Ekleyeceğinizi Giriniz: ");
            int kitapSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kitapSayisi; i++)
            {
                //Kitap kitap = new Kitap();
                //Console.WriteLine($"Lütfen {i + 1}. kitabın adını giriniz");
                //kitap.KitapAdi = Console.ReadLine();
                //Console.WriteLine($"Lütfen {i + 1}. kitabın yazarını giriniz");
                //kitap.KitapYazari = Console.ReadLine();
                //Console.WriteLine($"Lütfen {i + 1}. kitabın sayfa sayısını giriniz");
                //kitap.KitapSayfaSayisi = int.Parse(Console.ReadLine());
                //KitapListesi.Add(kitap);

                Console.Write($"Lütfen {i + 1}. kitabın adını giriniz");
                string kitapAdi = Console.ReadLine();
                Console.Write($"Lütfen {i + 1}. kitabın yazarını giriniz");
                string kitapYazari = Console.ReadLine();
                Console.Write($"Lütfen {i + 1}. kitabın sayfa sayısını giriniz");
                int kitapSayfaSayisi = int.Parse(Console.ReadLine());

                Kitap kitap = new Kitap
                {
                    KitapAdi = kitapAdi,
                    KitapYazari = kitapYazari,
                    KitapSayfaSayisi = kitapSayfaSayisi
                };
                KitapListesi.Add(kitap);
            }

            Console.WriteLine("\nGirilen kitap detayları:");

            foreach (var item in KitapListesi)
            {
                Console.WriteLine($"\nKitap adı: {item.KitapAdi}, kitap sayfa sayısı: {item.KitapSayfaSayisi}, kitap yazarı: {item.KitapYazari}");
            }
        }
    }
    //kullanıcının bakiyesi 200 tlden büyük olduğunda bakiyenin 20 katını göstren, 200 tl nn altında olduğunda 1000 tl olarak gösteren atama yapıldığında gelen değer 100 tl den küçükse bakyeyle eşitleyen büyükse gelen değerin %5 ine eşitleyen bir class oluşturalım.
    class Bakiye
    {
        int bakiye = 200;
        public int BakiyeHesapla
        {
            get
            {
                if (bakiye > 200)
                {
                    return bakiye * 20;
                }
                else
                {
                    return bakiye = 1000;
                }
            }
            set
            {
                if (value < 1000)
                {
                    bakiye = value;
                }
                else
                {
                    bakiye = value * 5 / 100;
                }
            }
        }
    }
    //Bir kitap sınıfı oluşturacaksınız, proplar olarak kitap adı, kitap yazarı ve kitap sayfa sayısı girilecek. ardından kullanıcıya kaç adet kitap girişi yapmak istiyorsunuz diye sorulacak ve bu sayı üzerinden kullanıcıya kitabın adı, kitabın yazarı ve sayfa sayısı sorulacak. kulanıcı bunları girdikten sonra, bu kitabı bir kitap listesine ekleyeceksiniz. finalde de görüntüleme yapacaksınız.
    class Kitap
    {
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public int KitapSayfaSayisi { get; set; }
    }
}
