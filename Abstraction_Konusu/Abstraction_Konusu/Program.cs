namespace Abstraction_Konusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction class --> Soyout sınıflar olarak adlandırılan bir OOP yapısıdır. Bu sınıflar doğrudan nesne oluşturamaz. Bir sınıfın veyahut bir nesnenin önemli olduğunu düşündüğünüz özelliklerinin ve işlevlerinin dışarıya bir sınıf (Abstract class) aracılığıyla sunmak anlamına gelen bir yapıdır.
            //Abstract classlar: tamamlanmamış (daha doğrusu henüz uygulanmamış) metodları içerebilirler. Abstract classladan türetilen alt sınıflar bu tamamlanmamış metodları uygulamak zorundadırlar.
            //Soyut sınıflar soyut metodlar taşıyabilirler.
            //Abstract class lar genelde bir temel yapı bir şablon oluşturmak için kullanılırlar.
            //Monster monster = new Monster("hasan"); // Bu şekilde nesne oluşturamazsınız. çünkü abstract class lar nesne üretme bilgisine sahip değildir.
            Dragon dragon = new Dragon("Ejderya"); // bu şekilde nesne üretebiliriz. Abstract class sadece kendi mirasını Dragona aktarmak için var olan bir class oldu.
            dragon.Saldir();
            Zombie zombie = new Zombie("Eyşan");
            zombie.Saldir();
        }
    }
    public abstract class Monster
    {
        public string Name { get; set; }
        public Monster(string isim)
        {
            Name = isim;
        }
        public abstract void Saldir();
    }
    public class Dragon : Monster
    {
        public Dragon(string isim) : base(isim) { } //constructor koyduk böylece base class'a gerekli parametreyi göndermiş olduk.

        public override void Saldir()
        {
            Console.WriteLine($"{Name} adındaki ejderya ateş püskürtüyor.");
        }
    }
    public class Zombie : Monster
    {
        public Zombie(string isim) : base(isim)
        {

        }

        public override void Saldir()
        {
            Console.WriteLine($"{Name} adındaki zombi ısırıyor.");
        }
    }
}
