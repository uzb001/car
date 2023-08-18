namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car = new Cars(001, "Audi", "Q7", 100_000);
            Cars car1 = new Cars(002, "BYD", "XAN", 65_000);
            Cars car2 = new Cars(003, "Chevrolet", "Malibu XL", 36_000);
            
            Cars.TaxPercentage = 50;

            car.CalculateTotal();
            car1.CalculateTotal();
            car2.CalculateTotal();

            Console.WriteLine("Another tax.");

            Cars.TaxPercentage = 20;

            car.CalculateTotal();
            car1.CalculateTotal();
            car2.CalculateTotal();
        }
    }
}