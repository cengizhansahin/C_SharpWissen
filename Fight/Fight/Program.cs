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

            Console.WriteLine("Karakterler\n\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
            Console.WriteLine();
            Console.Write("Lütfen karakter seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            // Geçerli seçim yapana kadar while döngüsü. eğe burası aktif olursa switch case deki default kısmının bir önemi kalmıyor!
            while (secim < 0 | secim > 4)
            {
                Console.Clear();
                Console.WriteLine("Lütfen geçerli bir karakter giriniz!");
                Console.WriteLine();
                Console.WriteLine("Karakterler\n\n1) Savaşçı\n2) Sura\n3) Ninja\n4) Şaman");
                Console.WriteLine();
                Console.Write("Lütfen karakter seçiniz: ");
                secim = Convert.ToInt32(Console.ReadLine());
            }

            Random random = new Random();
            int pcIndex = random.Next(0, 4);

            // aynı karakteri seçemezsiniz uyarısı vermeden random olarak pc karakter değiştiren while döngüsü. eğer burası çalıştırılırsa aşağıdaki if bloğu iptal oluyor. çünkü kontrole gerek kalmıyor.
            while ((secim - 1) == pcIndex)
            {
                pcIndex = random.Next(0, 4);
            }


            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {karakterIsimleri[secim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {karakterIsimleri[pcIndex]}");
                    Saldir(ozellikler, secim, pcIndex);
                    break;
                default:
                    Console.WriteLine();
                    //Console.WriteLine("Lütfen geçerli bir karakter giriniz! Switch Case!");
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
                Console.WriteLine();
                Console.Write("Saldırmak için saldir yazınız: ");
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
                            Console.WriteLine();
                            Console.WriteLine($"Kullanıcı ıslakaldı :((");
                            Console.WriteLine("-----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kullanıcı saldırıyı gerçekleştirdi!");
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
                            Console.WriteLine();
                            Console.WriteLine($"Bilgisayar ıskaladı :))");
                            Console.WriteLine("-----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bilgisayar saldırıyı gerçekleştirdi!");
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
                Console.WriteLine();
                Console.WriteLine("Kaybettiniz! Gerçek savaşçılar kaybetsede pes etmez!!!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Tebrikler kazandınız! :)))");
            }
        }
    }
}
