namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota","IrgendeinModell",2020);
            myCar.Honk();
            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}