namespace Class_Props_Devam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Calisan> calisanlar = new List<Calisan>();

            Console.Write("\nLütfen Kaç adet personel eklemek istediğini yazınız: ");
            int calisanSayisi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < calisanSayisi; i++)
            {
                //Calisan calisan = new Calisan();

                Console.Write($"Lütfen {i + 1}. çalışanın adını giriniz: ");
                string CalisanAdi = Console.ReadLine();
                Console.Write($"Lütfen {i + 1}. çalışanın departmanını giriniz: ");
                string CalisanDepartmani = Console.ReadLine();
                Console.Write($"Lütfen {i + 1}. çalışanın maaşını giriniz: ");
                double CalisanMaas = double.Parse(Console.ReadLine());
                //calisanlar.Add(calisan);
                Calisan calisan = new Calisan
                {
                    CalisanAdi = CalisanAdi,
                    CalisanDepartmani = CalisanDepartmani,
                    CalisanMaas = CalisanMaas
                };
                calisanlar.Add(calisan);
            }

            Console.WriteLine("****************************\nÇalışan Bilgileri:");

            foreach (var item in calisanlar)
            {

                Console.WriteLine($"Çalışan adı: {item.CalisanAdi}, Çalışan departman: {item.CalisanDepartmani}");
            }
            double ortMaas = Calisan.ortHesapla(calisanlar);
            Console.WriteLine($"****************************\nToplam maaş ortalaması: {ortMaas}");
        }

        //yeni bir işçi sınıfı oluşturulacak. Adı, departmanı ve maaşı tutulacak. aynı zamanda maaş ortalamasını hesaplayan bir metod yazılacak. bu metod tüm çalışanların maaşlarının toplamının ortalamasını dönecek. sonra da şirkete personel ekleme uygulaması başlaycak yine kaç adet personel eklemek isterseniz şeklinde sorulacak ve ekleme yapılacak. finalde de hem tüm çalışanlar e bilgileri gösterilecek hemde ort maaş yazdıracak.
    }
    class Calisan
    {
        public string CalisanAdi { get; set; }
        public string CalisanDepartmani { get; set; }
        public double CalisanMaas { get; set; }
        public static double ortHesapla(List<Calisan> calisanlar)
        {
            if (calisanlar.Count == 0)
            {
                return 0;
            }
            return calisanlar.Average(x => x.CalisanMaas);
        }
    }


}
