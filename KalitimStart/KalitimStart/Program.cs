namespace KalitimStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Musavir musavir = new Musavir();
            //musavir.Adi = "Hasan";
            //musavir.Soyadi = "Yılmaz";
            //musavir.MedeniHal = true;
            //Console.WriteLine($"Ad: {musavir.Adi}, soyad: {musavir.Soyadi}, medeni hal: {musavir.MedeniHal}");
            //D d = new D();
            //C c = new C();
        }
    }
    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool MedeniHal { get; set; }
    }
    class Yazilimi : Personel
    {
        public bool IsSenior { get; set; }
    }
    class Musavir : Personel
    {

    }
    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} nesnesi oluşturuldu.");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} nesnesi oluşturuldu.");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} nesnesi oluşturuldu.");
        }
    }
    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} nesnesi oluşturuldu.");
        }
    }
}
