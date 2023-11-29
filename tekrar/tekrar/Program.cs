namespace tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketSystem ticketSystem = new TicketSystem();
            while (true)
            {
                Console.WriteLine("\nTren Bileti Otomasyonu Modeli:\n***********************************");
                Console.WriteLine("1-Güzergah Ekle");
                Console.WriteLine("2-Bilet Sat");
                Console.WriteLine("3-Bilet İptal Et");
                Console.WriteLine("4-Raporları Görüntüle");
                Console.WriteLine("5-Çıkış\n***********************************");
                Console.Write("Lütfen seçimizini yapınız: ");
                int myChoice = int.Parse(Console.ReadLine());
                switch (myChoice)
                {
                    case 1:
                        Console.Clear();
                        addRoute(ticketSystem); break;
                    case 2:
                        Console.Clear();

                        sellTicket(ticketSystem); break;
                    case 3:
                        Console.Clear();

                        biletIptal(ticketSystem); break;
                    case 4:
                        Console.Clear();

                        ticketSystem.showTickets(); break;
                    case 5:
                        return;
                    default:
                        Console.Clear();

                        Console.WriteLine("\nLütfen geçerli bir seçim yapınız!");
                        break;
                }
            }
        }
        public static void addRoute(TicketSystem ticketSystem)
        {
            Console.WriteLine("Rota Ekleme:\n***********************************");
            Console.Write("Güzergah adını giriniz: ");
            string routeName = Console.ReadLine();
            Console.Write("Güzergah fiyatı: ");
            double basePrice = double.Parse(Console.ReadLine());
            ticketSystem.routes.Add(new Route(routeName, basePrice));
            Console.Clear();
        }
        public static void sellTicket(TicketSystem ticketSystem)
        {
            //List<Route> routes = ticketSystem.routes;
            Console.WriteLine("Bilet satın alma:\n***********************************");
            foreach (var item in ticketSystem.routes)
            {
                Console.WriteLine($"Güzergah: {item.RouteName}, fiyat: {item.BasePrice}");
            }
            Console.Write("***********************************\nLütfen yolcu adını giriniz: ");
            string passengerName = Console.ReadLine();
            Console.Write("Lütfen yolcu yaşını giriniz: ");
            int passengerAge = int.Parse(Console.ReadLine());
            Console.Write("Lütfen rota ismini giriniz: ");
            string routeName = Console.ReadLine();
            ticketSystem.sellTicket(passengerName, passengerAge, routeName);
        }
        public static void biletIptal(TicketSystem ticketSystem)
        {
            foreach (var item in ticketSystem.tickets)
            {
                Console.WriteLine($"\nYolcu adı: {item.PassengerName}, yolcu yaşı: {item.PassengerAge}, güzergah: {item.Route.RouteName}, fiyat: {item.TicketPrice}");
            }
            //for (int i = 0; i < ticketSystem.tickets.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1} - Yolcu adı: {ticketSystem.tickets[i].PassengerName}, yolcu yaşı: {ticketSystem.tickets[i].PassengerAge}, güzergah: {ticketSystem.tickets[i].Route.RouteName}");
            //}
            Console.Write("Lütfen silmek istediğiniz yolcu adını giriniz: ");
            string passengerName = Console.ReadLine();
            ticketSystem.cancelTicket(passengerName);
        }
    }
    public class Route
    {
        public string RouteName { get; set; }
        public double BasePrice { get; set; }
        public Route(string routeName, double basePrice)
        {
            RouteName = routeName;
            BasePrice = basePrice;
        }
    }
    public class Ticket
    {
        public string PassengerName { get; set; }
        public int PassengerAge { get; set; }
        public double TicketPrice { get; set; }
        public Route Route { get; set; }
        //public string RouteName { get; set; }
        public Ticket(string passengerName, int passengerAge, Route route)
        {
            PassengerName = passengerName;
            PassengerAge = passengerAge;
            Route = route;
            //RouteName = route.RouteName;
            TicketPrice = CalculatePrice(passengerAge, route);
        }
        public double CalculatePrice(int passengerAge, Route route)
        {
            if (passengerAge < 18)
            {
                return route.BasePrice * 0.5;
            }
            else
            {
                return route.BasePrice;
            }
        }
    }
    public class TicketSystem
    {
        public List<Ticket> tickets = new List<Ticket>();
        public List<Route> routes = new List<Route>
        {
            new Route ("İstanbul-Ankara",500),
            new Route ("Adana-İzmir",700),
            new Route ("Trabzon-Ankara",400)
        };
        public void addRoute(string routeName, double basePrice)
        {
            routes.Add(new Route(routeName, basePrice));
        }
        public void sellTicket(string passengerName, int passengerAge, string routeName)
        {
            Route route = routes.FirstOrDefault(x => x.RouteName.Trim().ToLower() == routeName.Trim().ToLower());
            if (route != null)
            {
                tickets.Add(new Ticket(passengerName, passengerAge, route));
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Böyle bir rota bulunmamaktadır!");
            }
        }
        public void cancelTicket(string passengerName)
        {

            //Ticket t = tickets[choice];
            //tickets.Remove(t);
            //Ticket deletedTicket = tickets.FirstOrDefault(x => x.PassengerName.Trim().ToLower() == passengerName.Trim().ToLower());
            //tickets.Remove(deletedTicket);
            var deletedName = tickets.FirstOrDefault(x => x.PassengerName == passengerName);
            if (deletedName != null)
            {
                tickets.RemoveAll(x => x.PassengerName.Trim().ToLower() == passengerName.Trim().ToLower());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nSilinecek yolcu bulunamadı!");
            }
        }

        public void showTickets()
        {
            Console.WriteLine("Satılan biletler:\n");
            if (tickets.Count > 0)
            {
                foreach (var item in tickets)
                {
                    Console.WriteLine($"Yolcu adı: {item.PassengerName}, yolcu yaşı: {item.PassengerAge}, güzergah: {item.Route.RouteName}, fiyat: {item.TicketPrice}");
                }
            }
            else
            {
                Console.WriteLine("Henüz bilet satışı yok!");
            }

            Console.WriteLine("***********************************\nGüzergah bazlı satış bilgileri:\n");
            foreach (var item in routes)
            {
                int selledCount = tickets.Count(x => x.Route.RouteName == item.RouteName);
                double totalPrice = tickets.Where(x => x.Route.RouteName == item.RouteName).Sum(x => x.TicketPrice);
                Console.WriteLine($"Güzergah: {item.RouteName}, satılan toplam bilet sayısı: {selledCount}, toplam fiyat: {totalPrice}");
            }
            Console.WriteLine("***********************************");
        }

    }
}
