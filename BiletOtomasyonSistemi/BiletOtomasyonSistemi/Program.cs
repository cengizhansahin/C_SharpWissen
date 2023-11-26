namespace BiletOtomasyonSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir tren bileti otomasyonu yapılacak. Program çalıştığında kullanıcıdan güzergah seçimi, yolcu bilgileri ve bilet işlemleri için girdiler alınacak.  Kullanıcı güzergah ekleme, bilet satışı, bilet iptali ve raporlama seklinde seçeneklerden birini seçerek işlemi gerçekleştirecek. Rota ekleme işleminde kullanıcıdan rota adı istenecek ve temel fiyat girilecek. Bilet satış işleminde kullanıcı adı alınacak rota adı yazılacak yolcunun yaşı alınacak. Ve bu bilgilerle bilet satışı gerçekleşecek. Bilet iptali için iptal edilecek yolcunun adı girilecek.
            //Her biletin detayını tutan bir Ticket class'ı olacak.  bu class'ta aynı zamanda bir fiyt hesaplayan metot olacak. Bu metot yaş ve temel fiyatı baz(parametre) alarak hesap yapacak. Eğer ki 18 yaşından küçük ise yüzde elli indirim olacak.
            //Güzergah detaylarını tutan bir Route class'ımız olacak. Burada güzergah adı ve basePrice temel fiyatı tutulacak.
            //Üçüncü class son class olarak da bilet işlemlerini yönetecek olan TicketSystem Classınız olacak Bu classta biletler ve güzergahlar tutulacak. Rota ekleme Bilet satışı bilet iptali ve rapor hazırlama bu classta metotlar halinde tutulacak.
        }
    }
    class Route
    {
        public string RouteName { get; set; }
        public double BasePrice { get; set; }
    }
    class Ticket
    {
        public string KullaniciName { get; set; }
        public int MyProperty { get; set; }
    }
}
