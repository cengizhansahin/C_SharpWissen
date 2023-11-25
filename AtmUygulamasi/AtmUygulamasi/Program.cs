using System.Globalization;

namespace AtmUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int bakiye = random.Next(1000, 100000);
            Console.WriteLine("*******************");
            Console.WriteLine("Mevcut bakiyeniz: " + bakiye);
            bool devamEt = true;
            while (devamEt)
            {
                Console.WriteLine("*******************");
                Console.WriteLine($"1) Para Çekme\n2) Para Yatırma\n3) Bakiye Görüntüle\n4) Çıkış");
                Console.WriteLine("*******************");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        bakiye = ParaCekme(bakiye);
                        break;
                    case 2:
                        bakiye = ParaYatır(bakiye);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*******************");
                        Console.WriteLine($"bakiyeniz: {bakiye}");
                        Console.WriteLine("*******************");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nİyi günler dileriz.");
                        devamEt = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("*******************");
                        Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        break;
                }
            }
        }
        public static int ParaCekme(int bakiye)
        {
            Console.Clear();
            Console.Write("Lütfen çekmek istediğiniz miktarı girin: ");
            int c_para = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (c_para > bakiye)
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Bakiyeniz yetersiz!");
                Console.WriteLine("*******************");
            }
            else
            {
                bakiye -= c_para;
                Console.WriteLine($"Çekilen para tutarı: {c_para}, yeni bakiye: {bakiye}");
            }
            return bakiye;
        }
        public static int ParaYatır(int bakiye)
        {
            Console.Clear();
            Console.Write("Lütfen yatırmak istediğiniz miktarı girin: ");
            int y_para = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            bakiye += y_para;
            Console.WriteLine($"Yatırılan para tutarı: {y_para}, yeni bakiye: {bakiye}");
            return bakiye;
        }
    }
}
//if (secim == 1)
//{
//    bakiye = ParaCekme(bakiye);
//}
//else if (secim == 2)
//{
//    bakiye = ParaYatır(bakiye);
//}
//else if (secim == 3)
//{
//    Console.Clear();
//    Console.WriteLine("*******************");
//    Console.WriteLine($"Bakiyeniz: {bakiye}");
//    Console.WriteLine("*******************");
//}
//else if (secim == 4)
//{
//    Console.Clear();
//    Console.WriteLine("İyi günler dileriz.");
//    break;
//}
//else
//{
//    Console.Clear();
//    Console.WriteLine("*******************");
//    Console.WriteLine("Lütfen geçerli bir değer giriniz!");
//}