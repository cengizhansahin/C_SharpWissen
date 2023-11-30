namespace PolimorfizmStart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kedi kedi = new Kedi();
            //kedi.Age = 2;
            //kedi.SesCikar();
            Kopek k = new Kopek();
            k.SesCikar();
        }
    }
    public class Hayvan
    {
        public string Name { get; set; }
        public int Age;
        public virtual void SesCikar()
        {
            Console.WriteLine("Bu hayvanın sesi yok.");
        }
    }
    public class Kedi : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Miyaaaaavvvv");
        }
    }
    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav");
        }
    }
}
