using System;

namespace Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ozellikler =
            {
                {20,100,25},  // Şavaşçı güç, savunma ve ıskalama
                {18,110,23},   // Sura güç, savunma ve ıskalama
                {15,120,20},   // Şaman güç, savunma ve ıskalama
                {30,80,35}    // Ninja güç, savunma ve ıskalama
            };

            string[] karakterIsimleri = { "Savaşçı", "Sura", "Şaman", "Ninja" };

            Console.WriteLine("Karakterler\n\n1) Savaşçı\n2) Sura\n3) Şaman\n4) Ninja");
            Console.Write("\nLütfen karakter seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            while (secim < 0 | secim > 4)
            {
                Console.Clear();
                Console.WriteLine("Lütfen geçerli bir karakter giriniz!");
                Console.WriteLine("\nKarakterler\n\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
                Console.Write("\nLütfen karakter seçiniz: ");
                secim = Convert.ToInt32(Console.ReadLine());
            }

            Random random = new Random();
            int pcIndex = random.Next(0, 4);

            while ((secim - 1) == pcIndex)
            {
                pcIndex = random.Next(0, 4);
            }
            switch (secim)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.Clear();
                    Saldir(karakterIsimleri, ozellikler, secim, pcIndex);
                    break;
            }
        }
        public static void Saldir(string[] karakterIsimleri, int[,] ozellikler, int secim, int pcIndex)
        {
            int kkSaldiri = ozellikler[secim - 1, 0];
            int kkSaglik = ozellikler[secim - 1, 1];

            int pcSaldiri = ozellikler[pcIndex, 0];
            int pcSaglik = ozellikler[pcIndex, 1];

            bool kullaniciSirasi = true;

            Console.WriteLine($"\nKullanıcı karakter: {karakterIsimleri[secim - 1]}, Sağlık: {kkSaglik}, Saldırı gücü: {kkSaldiri}");
            Console.WriteLine($"\nBilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}, Sağlık: {pcSaglik}, Saldırı gücü: {pcSaldiri}");

            while (pcSaglik > 0 | kkSaglik > 0)
            {
                Console.Write("\nSaldırmak için saldir yazınız: ");
                string saldir = Console.ReadLine();
                Console.Clear();

                if (saldir.ToLower().Trim() == "saldir")
                {
                    int kullaniciIska = ozellikler[secim - 1, 2];
                    int pcIska = ozellikler[pcIndex, 2];
                    Random random = new Random();
                    int randomKullanici = random.Next(0, 101);
                    Random random2 = new Random();
                    int randomPc = random2.Next(0, 101);

                    if (kullaniciSirasi)
                    {
                        if (kullaniciIska > randomKullanici)
                        {
                            Console.WriteLine($"\nKullanıcı ıslakaldı :((");
                            Console.WriteLine("-----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("\nKullanıcı saldırıyı gerçekleştirdi!");
                            Console.WriteLine("-----------------------------------");
                            pcSaglik -= kkSaldiri;
                            if (pcSaglik <= 0)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (pcIska > randomPc)
                        {
                            Console.WriteLine($"\nBilgisayar ıskaladı :))");
                            Console.WriteLine("-----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("\nBilgisayar saldırıyı gerçekleştirdi!");
                            Console.WriteLine("-----------------------------------");
                            kkSaglik -= pcSaldiri;
                            if (kkSaglik <= 0)
                            {
                                break;
                            }
                        }
                    }

                    kullaniciSirasi = !kullaniciSirasi;
                    Console.WriteLine($"Kalan kullanıcı sağlığı: {kkSaglik}");
                    Console.WriteLine($"Kalan bilgisayar sağlığı: {pcSaglik}");
                }
                else
                {
                    Console.WriteLine("Hatalı giriş!");
                }
            }

            if (kkSaglik <= 0)
            {
                Console.WriteLine("\nKaybettiniz! Gerçek savaşçılar kaybetsede pes etmez!!!");
            }
            else
            {
                Console.WriteLine("\nTebrikler kazandınız! :)))");
            }
        }
    }
}
