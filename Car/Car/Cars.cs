using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Cars
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public static decimal TaxPercentage { get; set; }
        public Cars(int id, string model, string brand, decimal price)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
        }
        public void CalculateTotal()
        {
            Price += Price * (TaxPercentage / 100);
            Console.WriteLine($"Price with tax: {Price}, {TaxPercentage} %");
        }
        /*
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Model: {Model}, Brand: {Brand}, Price: {Price}");
        }
        */
    }
}
