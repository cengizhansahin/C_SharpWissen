using System;

namespace Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ozellikler =
            {
                {20,100 },  // Şavaşçı güç ve savunma
                {18,110},   // Sura güç ve savunma
                {15,120},   // Şaman güç ve savunma
                {30,80,}    // Ninja güç ve savunma
            };

            string[] karakterIsimleri = { "Savaşçı", "Sura", "Şaman", "Ninja" };

            Console.WriteLine("Karakterler\n\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
            Console.WriteLine();
            Console.Write("Lütfen karakter seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());



            //while (secim < 0 | secim > 4)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Lütfen geçerli bir karakter giriniz! While!");
            //    Console.WriteLine();
            //    Console.WriteLine("Karakterler\n\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
            //    Console.WriteLine();
            //    Console.Write("Lütfen karakter seçiniz: ");
            //    secim = Convert.ToInt32(Console.ReadLine());
            //}

            Random random = new Random();
            int pcIndex = random.Next(0, 4);


            //while ((secim - 1) == pcIndex)
            //{
            //    pcIndex = random.Next(0, 4);
            //}

            if (pcIndex == (secim - 1))
            {
                Console.Clear();
                Console.WriteLine("Aynı karakteri seçemezsiniz!");
                Console.WriteLine();
                while (pcIndex == (secim - 1))
                {
                    pcIndex = random.Next(0, 4);

                    Console.WriteLine("Karakterler\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
                    Console.WriteLine();
                    Console.Write("Lütfen yeni karakter seçiniz: ");
                    secim = Convert.ToInt32(Console.ReadLine());
                }
            }

            //int kkSaldiri = ozellikler[secim - 1, 0];
            //int kkSaglik = ozellikler[secim - 1, 1];

            //int pcSaldiri = ozellikler[pcIndex, 0];
            //int pcSaglik = ozellikler[pcIndex, 1];

            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"Seçtiğiniz karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Seçtiğiniz karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Seçtiğiniz karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Seçtiğiniz karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir karakter giriniz! Switch Case!");
                    break;
            }
        }
        public static void Saldir(int[,] ozellikler, int secim, int pcIndex)
        {
            int kkSaldiri = ozellikler[secim - 1, 0];
            int kkSaglik = ozellikler[secim - 1, 1];

            int pcSaldiri = ozellikler[pcIndex, 0];
            int pcSaglik = ozellikler[pcIndex, 1];

            bool kullaniciSirasi = true;

            Console.WriteLine();
            Console.WriteLine($"Kullanıcı sağlığı: {kkSaglik}, saldırı gücü: {kkSaldiri}");
            Console.WriteLine($"Bilgisayarın seçtiği karakter sağlığı: {pcSaglik}, saldırı gücü: {pcSaldiri}");

            while (pcSaglik > 0 | kkSaglik > 0)
            {
                if (kullaniciSirasi)
                {
                    Console.WriteLine();
                    Console.WriteLine("Kullanıcı saldırıyı gerçekleştiriyor...");
                    pcSaglik -= kkSaldiri;
                    if (pcSaglik <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Bilgisayar saldırıyı gerçekleştiriyor...");
                    kkSaglik -= pcSaldiri;
                    if (kkSaglik <= 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Kalan kullanıcı sağlığı: {kkSaglik}");
                Console.WriteLine($"Kalan bilgisayar sağlığı: {pcSaglik}");

                kullaniciSirasi = !kullaniciSirasi;
            }
            if (kkSaglik <= 0)
            {
                if (pcSaglik < 5)
                {
                    Console.WriteLine("Çok az kalmıştı ama kaybettin! :(((");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kaybettiniz! Gerçek savaşçılar kaybetsede pes etmez!!!");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Tebrikler kazandınız! :)))");
            }
        }
    }
}
