namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car myCar = new Car("Toyota", "IrgendeinModell", 2020);
            myCar.Honk();
            Console.WriteLine(myCar.Brand);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);


            Car myCarTwo = new Car("Toyota", "IrgendeinModell", 2020);
            string info = myCar.GetFullInfo();
            Console.WriteLine(info);
            Console.WriteLine(myCar.GetFullInfo());
            //Beides möglich, nur ist es mit der variable, besser zu lesen

            float consumption = myCar.CalculateFuelConsumption(400,6);
       
          

        }





    }
}