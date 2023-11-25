namespace Classlar_Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.name = "BMW";
            car.model = 2012;
            car.isAutomatic = true;
            car.ArabaCalistir();
        }
    }
    //önce acces modifler sonra class sonra className
    public class Car
    {
        public string name; // field
        public int model; // field
        public bool isAutomatic; // field
        public void ArabaCalistir() // function
        {
            Console.WriteLine($"Markası {name} olan {model} modelindeki Araba çalıştı :)");
        }
    }
}
