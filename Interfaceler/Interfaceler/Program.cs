namespace Interfaceler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler (Arayüzler), genelde interfaceleri sözleşme şeklinde kodlarlar. içerisinde barındırdığı metodlar kesinlikle abstract classlardaki gibi kullanılmak zorundadır. Fakat nasıl kullanılacağnı belirtmezler. Interfacelerde access 
            //Orangutan o1 = new Orangutan();
            //o1.Speak();
            //BalPorsugu balPorsugu = new BalPorsugu();
            //balPorsugu.Speak();
            TV tV = new TV("OLED TV", "LG");
            CepTelefonu cepTelefonu = new CepTelefonu("Iphone 15 pro", "Apple");

            tV.BilgileriGoster();
            cepTelefonu.BilgileriGoster();
        }
    }
    //interface ISpeakable
    //{
    //    void Speak();
    //}
    //public class Orangutan : ISpeakable
    //{
    //    public void Speak()
    //    {
    //        Console.WriteLine("Grawh");
    //    }
    //}
    //public class BalPorsugu : ISpeakable
    //{
    //    public void Speak() { Console.WriteLine("Skrrt"); }
    //}

    interface IElektronikCİhaz
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        void BilgileriGoster();
    }
    public class TV : IElektronikCİhaz
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public TV(string model, string marka)
        {
            Model = model;
            Marka = marka;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Televizyon Marka: {Marka}, Model: {Model}");
        }
    }
    public class CepTelefonu : IElektronikCİhaz
    {
        public string Model { get; set; }
        public string Marka { get; set; }
        public CepTelefonu(string model, string marka)
        {
            Model = model;
            Marka = marka;
        }
        public void BilgileriGoster()
        {
            Console.WriteLine($"Telefon Marka: {Marka}, Model: {Model}"); ;
        }
    }
}
