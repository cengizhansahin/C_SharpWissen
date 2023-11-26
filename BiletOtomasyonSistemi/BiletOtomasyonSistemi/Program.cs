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





            List<Route> rotalar = new List<Route>();
            Route route1 = new Route("İstanbul-Trabzon", 900);
            rotalar.Add(route1);
            Route route2 = new Route("İstanbul-Ankara", 500);
            rotalar.Add(route2);
            Route route3 = new Route("Manisa-İstanbul", 700);
            rotalar.Add(route3);
            List<Ticket> tickets = new List<Ticket>();

            foreach (var item in rotalar)
            {
                Console.WriteLine(item.RouteName + item.BasePrice);
            }

            while (true)
            {
                Console.WriteLine("**********************\n1) Rota Ekleme\n2) Bilet Satış\n3) Bilet İptali\n4) Rapor Hazırlama");
                Console.WriteLine("**********************\nLütfen seçim yapınız: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Write("Lütfen eklemek istediğiniz rota miktarını giriniz: ");
                        int routeCount = int.Parse(Console.ReadLine());
                        for (int i = 0; i < routeCount; i++)
                        {
                            Console.Write("Lütfen rotanızı giriniz: ");
                            string routeName = Console.ReadLine();
                            Console.Write("Lütfen temel fiyatı giriniz: ");
                            double basePrice = double.Parse(Console.ReadLine());
                            Route route = new Route(routeName, basePrice);
                            rotalar.Add(route);
                        }
                        foreach (var item in rotalar)
                        {
                            Console.Clear();
                            Console.WriteLine(item.RouteName + item.BasePrice);
                        }
                        break;
                    case 2:
                        for (int i = 0; i < rotalar.Count; i++)
                        {
                            Console.WriteLine($"Rotalar\nRota {i + 1}: {rotalar[i].RouteName}, fiyat: {rotalar[i].BasePrice}");
                        }
                        Console.Write("Lütfen kaç adet bilet alacağınızı giriniz: ");
                        int ticketCount = int.Parse(Console.ReadLine());

                        for (int i = 0; i < ticketCount; i++)
                        {
                            Console.Write("Lütfen adınızı giriniz: ");
                            string userName = Console.ReadLine();
                            Console.Write("Lütfen yaşınızı giriniz: ");
                            int userAge = int.Parse(Console.ReadLine());
                            Ticket ticket = new Ticket(userName, userAge, rotalar[i]);
                            tickets.Add(ticket);
                        }
                        break;
                    case 3:
                        foreach (var item in tickets)
                        {
                            Console.WriteLine($"{item.UserName}\n");
                        }
                        Console.Write("Lütfen silinecek kullanıcı adını girin: ");
                        string silinecek = Console.ReadLine();
                        TicketSystem ticketSystem = new TicketSystem();
                        ticketSystem.RemoveTicket(silinecek.Trim().ToLower());
                        foreach (var item in tickets)
                        {
                            Console.WriteLine($"Yolcu adı: {item.UserName}, yolcu yaşı: {item.UserAge}, güzergah: {item.Route.RouteName}, fiyat: {item.Price}");
                        }
                        break;
                    case 4:
                        foreach (var item in tickets)
                        {
                            Console.WriteLine($"Yolcu adı: {item.UserName}, yolcu yaşı: {item.UserAge}, güzergah: {item.Route.RouteName}, fiyat: {item.Price}");
                        }
                        break;
                    default:
                        break;
                }
            }


            //foreach (var item in tickets)
            //{
            //    Console.WriteLine($"Bilet sahibi: {item.UserName}, yolcu yaşı: {item.UserAge}, ödenecek tutar: {item.Price}, güzergah: {item.Route.RouteName}");
            //}
        }
    }
    class Route
    {
        public string RouteName { get; set; }
        public double BasePrice { get; set; }

        //public int UserAge { get; set; }
        public Route(string routeName, double basePrice)
        {
            RouteName = routeName;
            BasePrice = basePrice;
        }
    }
    class Ticket
    {
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public double Price { get; set; }
        public Route Route { get; set; }

        public Ticket(string userName, int userAge, Route route)
        {
            UserName = userName;
            UserAge = userAge;
            Route = route;
            Price = PriceCalculate();
        }
        public double PriceCalculate()
        {
            if (UserAge < 18)
                return Route.BasePrice - Route.BasePrice * 0.5;
            else
                return Route.BasePrice;
        }
    }
    class TicketSystem
    {
        public List<Ticket> Tickets { get; set; }
        public void RemoveTicket(string userName)
        {
            if (Tickets.Any(t => t.UserName == userName))
            {
                Ticket silinecek = Tickets.FirstOrDefault(t => t.UserName == userName);
                if (silinecek != null)
                {
                    Tickets.Remove(silinecek);
                    Console.WriteLine($"{userName} adlı kullanıcı silindi.");
                }
            }
            else
            {
                Console.WriteLine($"{userName} adlı kullanıcı bulunamadı.");
            }
        }
        //else
        //{
        //    Console.WriteLine("Silinecek hesap bulunamadı!");
        //}
    }
}
