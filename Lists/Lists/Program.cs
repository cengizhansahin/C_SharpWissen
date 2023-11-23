namespace Lists
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Listler collectionlar olarak adlandırılan yapının bir elemanıdır.
            List<int> sayilar = new List<int>();

            // Bu diziye nasıl eleman ekleriz.
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            int[] x = { 4, 4554, 75, 7 };
            sayilar.AddRange(x);
            //sayilar.AddRange(new int[] {5,9,12});

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            // Listenin uzunluğu için count metodu kullanılır.
            //Console.WriteLine(sayilar.Count);

            // Listenin içerisinde bir elemanın olup olmadığını kontrol eden metod
            //bool isExist = sayilar.Contains(1);
            //Console.WriteLine(isExist);

            //sayilar.Clear();
            //Console.WriteLine(sayilar.Count);

            //bool isExist = sayilar.Exists(x => x > 10);
            //Console.WriteLine(isExist);

            // Koşulu sağlayan ilk elemanı döner, eğer koşul sağlanmazsa koşul sıfır döner.
            //int falanFilan = sayilar.Find(x => x > 2);
            //Console.WriteLine(falanFilan);

            //Eğer ki hepsini getirmesini istiyorsak dönen verinin liste tipinde döneceğini bilmemiz gerekir. Bu durum için kullanacağımız metod finall metodudur.
            //List<int> bulunanlar = sayilar.FindAll(x => x > 50);
            //foreach (var item in bulunanlar)
            //{
            //    Console.WriteLine(item);
            //}

            // aradığımız elemanın indexini bulmak için
            //int index = sayilar.IndexOf(1);
            //Console.WriteLine(index);

            //sayilar.Insert(3, 999);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //belirli bir elamanı silmek için
            //sayilar.Remove(999);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //belirli bir indeksteki elemanı silmek için
            //sayilar.RemoveAt(2);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //sayilar.ForEach(x=>Console.WriteLine(x));

            //sayilar.Sort();
            //sayilar.Reverse();
            //sayilar.ForEach(x=>Console.WriteLine(x));

            //int[] zibam = sayilar.ToArray();

            Console.WriteLine("***********************");
            Console.WriteLine("1) Para Çekme\n2) Bakiye Göster\n3) Para Yatırma\n4) Çıkış");
            Console.WriteLine("Lütfen yapmak istediğiniz işlem numarasını giriniz: ");
            int toplamBakiye = 5000;
            int islemNumarasi = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (islemNumarasi==1)
                {
                    toplamBakiye -= ParaCekme();
                    Console.WriteLine($"Çekilen para mitarı: {ParaCekme()}, kalan tutar: {toplamBakiye}");

                }
                else if (islemNumarasi==2)
                {
                    Console.WriteLine($"Bakiyeniz: {toplamBakiye}");
                }
                else if (islemNumarasi == 3)
                {
                    toplamBakiye += ParaYukle();
                    Console.WriteLine($"Yüklenen para mitarı: {ParaYukle()}, yeni tutar: {toplamBakiye}");
                }else if (islemNumarasi == 4)
                {
                    return;
                }
            }

        }
        public static int ParaCekme()
        {
            Console.WriteLine("Çekmek istediğiniz miktarı giriniz: ");
            int miktar = Convert.ToInt32(Console.ReadLine());
            return miktar;

        }
        public static int ParaYukle()
        {
            Console.WriteLine("Eklemek istediğiniz miktarı giriniz: ");
            int miktar = Convert.ToInt32(Console.ReadLine());
            return miktar;
        }
    }
}
