namespace SinifCalisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ts = new TicketSystem();
            while (true)
            {
                Console.WriteLine("\nTren Bileti Otomasyonu Modeli");
                Console.WriteLine("1-Güzergah Ekle");
                Console.WriteLine("2-Bilet Sat");
                Console.WriteLine("3-Bilet İptal Et");
                Console.WriteLine("4-Raporları Görübtüle");
                Console.WriteLine("5-Çıkış");
                Console.Write("Lütfen seçimizini yapınız: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddRoute(ts);
                        break;
                    case "2":
                        biletSatis(ts); break;
                    case "3":
                        biletIptal(ts); break;
                    case "4":
                        ts.PrintTicket(); break;
                    case "5":
                        return;
                    default:
                        break;
                }
            }
        }
        public static void AddRoute(TicketSystem ticketSystem)
        {
            Console.Write("Güzergah adı: ");
            string routeName = Console.ReadLine();
            Console.Write("Güzergah fiyatı: ");
            double basePrice = double.Parse(Console.ReadLine());
            ticketSystem.AddRoute(routeName, basePrice);
        }
        public static void biletSatis(TicketSystem ticketSystem)
        {
            Console.Write("Yolcu adı: ");
            string passName = Console.ReadLine();
            Console.Write("Güzergah adı: ");
            string routeName = Console.ReadLine();
            Console.Write("Yolcu yaşı: ");
            int passAge = int.Parse(Console.ReadLine());

            ticketSystem.SellTicket(passName, routeName, passAge);
        }
        public static void biletIptal(TicketSystem ticketSystem)
        {
            Console.Write("Yolcu adı: ");
            string passName = Console.ReadLine();
            ticketSystem.CancelTicket(passName);

        }
    }
    public class Route
    {
        public string RouteName { get; set; }
        public double BasePrice { get; set; }
        public Route(string name, double basePrice)
        {
            RouteName = name;
            BasePrice = basePrice;
        }
    }
    public class Ticket
    {
        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public double TicketPrice { get; set; }

        //Buna ileride navigasyon property diyeceğiz.
        public Route Route { get; set; }

        //Asıl biletin fiyatını hesaplayan fonksiyonumuz.
        public double CalculatePrice(int age, double basePrice)
        {
            if (age < 18)
            {
                return basePrice * 0.5;
            }
            else
            {
                return basePrice;
            }
        }
        //ticket'a bir constructor ekledik. Önce Ticket'ın kendi propertylerini doldurmamız gerekiyor. Bunun için yeni bir ticket nesnesi oluştuğu anda parametre olarak yolcu adı girilecek, route girilecek ve yaş girilecek. Fakat bir de sadece son hali olan Ticketîn price'ı olmak zorunda. Bu price da CalclatePrice metodundan gelecek. CalculatePrice metodu da bizden bir basePrice beklemekte. Bu basePrice rotanın başlangıç fiyatı dolayısıyla bizim Route tipindeki route parametresinden gelen basePrice'a ihtiyacımız var. constructor'ı bu ölçeğe göre tasarlıyoruz.
        public Ticket(string passengerName, int passengerAge, Route route)
        {
            PassengerName = passengerName;
            PassengerAge = passengerAge;
            Route = route;
            TicketPrice = CalculatePrice(passengerAge, route.BasePrice);
        }
    }
    public class TicketSystem
    {
        public List<Ticket> tickets = new List<Ticket>();
        public List<Route> routes = new List<Route>();


        public void AddRoute(string routeName, double basePrice)
        {
            //Route x = new Route(routeName, basePrice);
            //routes.Add(x);
            routes.Add(new Route(routeName, basePrice));
        }
        public void SellTicket(string passengerName, string routeName, int passengerAge)
        {
            //FirstOrDefault metodumuz hazır bir Linq sorgusudur(ileride geceleğiz) Bu sorgu aradığınız kriterin sağladığı ilk elemanı size getiren bir sorgudur. Yani bize aslında bir Object(nesne) dönecektir. Ama aradığımız kriter yoksa da Null dönecektir. İçerisinde Lambda expressinon kullanacaktır. 
            //Aşağıda tanımlamış olduğum route değişkeni, parametre olarak yollamış olduğum routeName (kullanıcının gireceği güzergah adı) eğer routes listesindeki herhangi bir objenin içerisindeki Name'ler ile eşleşiyorsa o objenin tamamını dönecektir. Eğer eşleşmiyorsa Null dönecektir.
            var route = routes.FirstOrDefault(x => x.RouteName == routeName);
            if (route != null)
            {
                tickets.Add(new Ticket(passengerName, passengerAge, route));
            }
        }
        public void CancelTicket(string passengerName)
        {
            tickets.RemoveAll(x => x.PassengerName == passengerName);
        }
        public void PrintTicket()
        {
            Console.WriteLine("Satılan biletler: ");
            foreach (var item in tickets)
            {
                Console.WriteLine($"\nYolcu adı: {item.PassengerName}, yolcu yaşı: {item.PassengerAge}, güzergah: {item.Route.RouteName}, fiyat: {item.TicketPrice}");
            }
            Console.WriteLine("Güzergah bazlı");
            foreach (var item in routes)
            {
                var satilanBiletler = tickets.Count(x => x.Route.RouteName == item.RouteName);
                var toplamKazanc = tickets.Where(x => x.Route.RouteName == item.RouteName).Sum(x => x.TicketPrice);
                Console.WriteLine($"Route: {item.RouteName}, Ticket sold: {satilanBiletler}, Toplam kazanç: {toplamKazanc}");
            }
        }
    }
}
