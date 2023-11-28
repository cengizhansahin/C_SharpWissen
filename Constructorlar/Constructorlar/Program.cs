using System.Xml.Linq;

namespace Constructorlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructorlar (yapıcı olarak adlandırılırlar). Bir sınıfa ait nesne oluşturulurken otomatik olarak çağrılan özelleştirilmiş metotdlardır. Bir nesnenin başlangıç state'tini ayarlamak için kullanılırlar.
            //Constructorlar sınıflarla aynı isimde olurlar
            //Değer dönmez, void olarak tanımlanmaz.
            //ctor tab yapılarak kısayol yapılır.
            //overload edilebilirler
            //yani parametreli veya parametresiz olabilirler
            //eğer hiç constructor kullanmada bir class oluşturursak otomatik olarak parametresz ctor arkaplanda çalışıyor olacaktır. (nesne üretimi esnasında)

            //Car c1 = new Car(); //Boş parametreli ctor devreye girer ve  Console.WriteLine("Bir adet markasız araba oluşturuldu!");

            //Car c2 = new Car("Mercedes"); //Parametreli ctor devreye girer ve parametre olarak gönderilen markada bir araba oluşturulur.

            //Console.Write("Lütfen bir isim girelim: ");
            //string isims = Console.ReadLine();
            //Console.Write("Lütfen bir yaş girelim: ");
            //int yas = int.Parse(Console.ReadLine());

            //Student student = new Student();
            //Student student2 = new Student("Barbaros", 31);
            //Student student3 = new Student(isims, yas);
            //Console.WriteLine($"Öğrenci 1) Adı: {student.Name}, Yaşı: {student.Age}\nÖğrenci 2) Adı: {student2.Name}, Yaşı: {student2.Age}\nÖğrenci 3) Adı: {student3.Name}, Yaşı: {student3.Age}");


            //Book book1 = new Book();
            //book1.Yazdir();
            //Book book2 = new Book("falan","filan");
            //book2.Yazdir();
            //Book book3 = new Book("adı","yazaradı",1983,150.99);
            //book3.Yazdir();


        }
    }
    class Car
    {
        public string Name { get; set; }
        public Car()
        {
            Console.WriteLine("Bir adet markasız araba oluşturuldu!");
        }

        public Car(string name)
        {
            Console.WriteLine($"Bir adet {name} markalı araba oluşturuldu.");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student()
        {
            Name = "Bilinmiyor";
            Age = 0;
            //Console.WriteLine($"Öğrenci adı: {Name}, yaşı: {Age}");
        }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            //Console.WriteLine($"Öğrenci adı: {Name}, yaşı: {Age}");
        }
    }
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }



        public Book()
        {
            Name = "Bilinmiyor";
            Author = "Bilinmiyor";
            Year = 0;
            Price = 0;
        }
        public Book(string name, string authorName)
        {
            Name = name;
            Author = authorName;
            Year = 0;
            Price = 0;
        }
        public Book(string name, string authorName, int year, double price)
        {
            Name = name;
            Author = authorName;
            Year = year;
            Price = price;
        }

        public void Yazdir()
        {
            Console.WriteLine($"Kitap adı: {Name}, yazar adı: {Author}, yayın yılı: {Year}, fiyat: {Price}");
        }
    }

    // bir tren bileti otomasyonu yapılacak. program çalıştığında kullanıcıdan güzergah seçimi, yolcu bilgileri ve bilet işlemleri için girdiler alınacak. kullanıcı güzergah ekleme, bilet satışı, bilet iptali ve raporlama şeklinde seçeneklerden birini seçerek işlemi gerçekleşriecek. rota ekleme işleminde kullanıcıdan rota adı istenecek ve temel fiyat girilecek. bilet satış işleminde kullanıcı adı alınacak rota adı yazılacak yolcunun yaşı alınacak. ve bu bilgilerler bilet satışı gerçekleşecek. bilet iptali için iptal edilecek yolcunun adı girilecek.
    //her biletin detayını tutan bir ticket class'ı olacak. bu classta aynı zamanda bir fiyat hesaplayan meotd olacak. bu metod yaş ve temel fiyatı baz (parametre) alarak hesap yapacak. eğer ki 18 yaşından küçük ise yüzde elli indirim olacak.
    //güzergah detaylarını tutan bir Route class'ımız olacak. burada güzergah adı ve basePrice temel fiyatı tutulacak.
    //üçüncü class son class olarak da bilet işlemlerini yönetecek olan TicketSystem Class ınız olacak Bu class ta biletler ve güzergahlar tutulacak rota ekleme, bilet satışı, bilet iptali ve rapor hazırlama bu class ta metodlar halinde tutulacak.
}
