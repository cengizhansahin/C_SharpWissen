namespace KitapListeleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n1. Kitap Ekle\n2. Kitap Sil\n3. Kitapları Listele\n4. Çıkış ");
                string choice = Console.ReadLine();
                KitapIslemi x;
                switch (choice)
                {
                    case "1":
                        x = new KitapEkle();
                        x.Islemyap();
                        break;
                    case "2":
                        x = new KitapSil();
                        x.Islemyap();
                        break;
                    case "3":
                        x = new KitaplariListele();
                        x.Islemyap();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("\nProgramdan çıkıldı.");
                        return;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız!");
                        break;
                }

            }
        }
    }
    public static class KitapVeriTabani
    {
        public static List<string> kitaplar = new List<string>();
    }
    //public class KitapVeriTabani
    //{
    //    public List<string> Kitaplar = new List<string>();
    //}
    public abstract class KitapIslemi
    {
        public abstract void Islemyap();
    }
    public class KitapEkle : KitapIslemi
    {
        public override void Islemyap()
        {
            Console.Write("Eklemek istediğiniz kitap adını yazınız: ");
            string name = Console.ReadLine();
            KitapVeriTabani.kitaplar.Add(name);
            Console.WriteLine($"{name} kitabı başarılı bir şekilde eklendi.");
        }
    }
    public class KitapSil : KitapIslemi
    {
        public override void Islemyap()
        {
            Console.Write("Silmek istediğiniz kitap adını yazınız: ");
            string name = Console.ReadLine();
            if (KitapVeriTabani.kitaplar.Count > 0)
            {
                if (KitapVeriTabani.kitaplar.Contains(name))
                {
                    KitapVeriTabani.kitaplar.Remove(name);
                    Console.WriteLine($"{name} kitabı başarılyla silindi.");
                }
                else
                {
                    Console.WriteLine($"{name} isminde bir kitap bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Henüz kitap eklenmemiş.");
            }
        }
    }
    public class KitaplariListele : KitapIslemi
    {
        public override void Islemyap()
        {
            if (KitapVeriTabani.kitaplar.Count > 0)
            {
                Console.WriteLine("Kitap Listesi");
                foreach (var item in KitapVeriTabani.kitaplar)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("Kütüphanede kitap yok.");
            }
        }
    }
}
//Bir kitap veri tabanı classı oluşturacaksınız bu classın özelliği içinde tring tipinde kitaplar adında bir prop tutaması olacak.
// sonra bir KitapIslemi adını veriğimizz abstract classımız olacak ve içinde abstract bir metot olan IslemYap imzası saklanacak.

//Sonra tek amacı KitapEkleme olan bir class daha oluşturacaksınız ve kitapişlemi classından implementasyon yapacaksınız. Buada kullanıcı etkileşimli olacak şekilde eklemek istediğimiz kitabın adını alacağız ve bunu kitapveritabanı içindeki propumuza ekleyceğiz. sonrada consolda kitap adı yazcak ve başarıyla eklendi yazacak.
//Sonra KitapSil classımız olacak bu da yine kitapişlemi classından implementasyon yapacak. ve bu arkadaşta yine aynı listeden kitap silecek aynı şekilde mesajlar verecek. ve kitap adı üzerinden silme gerçekleştirilecek.
//Bir sınıf da kitapllisteleme sınıfı olacak yine işlemyap metodunu ezecek eğer ki kitap sayısı sıfır değilse yani sıfırdan büyükse kütüphanede bulunan kitaplar; diyerek alt alta kitap isimlerini yazdıracak. 
//Main metodunda bir işem seçerek bu yukarıdaki işlevleri kullanacaksınız.
