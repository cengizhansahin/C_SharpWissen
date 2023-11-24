using System;

namespace Fight
{
    internal class Program
    {
        public class Character
        {
            public string isim { get; set; }
            public int saldiriGucu { get; set; }
            public int saglik { get; set; }
            public int iskalama { get; set; }
        }
        static void Main(string[] args)
        {
            List<Character> Karakterler = new List<Character>
            {
                new Character {isim="Savaşçı",saldiriGucu=20, saglik=100,iskalama=20},
                new Character {isim="Sura", saldiriGucu=18, saglik=110,iskalama=18},
                new Character {isim="Şaman", saldiriGucu=15, saglik=120,iskalama=15},
                new Character {isim="Ninja", saldiriGucu=30, saglik=80,iskalama=30},
            };

            Console.WriteLine("Karakterler: ");
            Console.WriteLine();
            foreach (var item in Karakterler)
            {
                Console.WriteLine($"{item.isim}: saldırı gücü: {item.saldiriGucu}, sağlık: {item.saglik}, iskalama: {item.iskalama}");
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("1) Savaşçı\n2) Sura\n3) Şaman\n4) Ninja");
            Console.WriteLine();
            Console.Write("Lütfen karakter seçiniz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            while (secim < 1 | secim > 4)
            {
                Console.Clear();
                Console.WriteLine("Karakterler: ");
                Console.WriteLine();
                foreach (var item in Karakterler)
                {
                    Console.WriteLine($"{item.isim}: saldırı gücü: {item.saldiriGucu}, sağlık: {item.saglik}, iskalama: {item.iskalama}");
                    Console.WriteLine("--------------------------------------------------------");

                }
                Console.WriteLine();
                Console.WriteLine("Lütfen geçerli bir karakter seçiniz!");
                Console.WriteLine();
                Console.WriteLine("1) Savaşçı\n2) Sura\n3) Şaman\n4) Ninja");
                Console.WriteLine();
                Console.Write("Lütfen karakter seçiniz: ");
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
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {Karakterler[secim - 1].isim}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {Karakterler[pcIndex].isim}");
                    Saldir(Karakterler, secim, pcIndex);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {Karakterler[secim - 1].isim}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {Karakterler[pcIndex].isim}");
                    Saldir(Karakterler, secim, pcIndex);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {Karakterler[secim - 1].isim}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {Karakterler[pcIndex].isim}");
                    Saldir(Karakterler, secim, pcIndex);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"Kullanıcı karakter: {Karakterler[secim - 1].isim}");
                    Console.WriteLine($"Bilgisayarın seçtiği karakter: {Karakterler[pcIndex].isim}");
                    Saldir(Karakterler, secim, pcIndex);
                    break;
                default:
                    break;
            }
        }
        public static void Saldir(List<Character> Karakterler, int secim, int pcIndex)
        {
            int kkSaldiri = Karakterler[secim - 1].saldiriGucu;
            int kkSaglik = Karakterler[secim - 1].saglik;

            int pcSaldiri = Karakterler[pcIndex].saldiriGucu;
            int pcSaglik = Karakterler[pcIndex].saglik;

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
                    int kullaniciIska = Karakterler[secim - 1].iskalama;
                    int pcIska = Karakterler[pcIndex].iskalama;
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
