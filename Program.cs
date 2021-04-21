using System;

namespace JurasicPark2
{
    class Dino
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
    }
    class Program
    {
        static void BannerMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var Matt = new Dino();
            Matt.Name = "Matt";
            Matt.DietType = "Carnivore";
            Matt.Weight = 500;
            Matt.EnclosureNumber = 3;

            var James = new Dino();
            James.Name = "James";
            James.DietType = "Herbivore";
            James.Weight = 100;
            James.EnclosureNumber = 6;

            var Andrew = new Dino();
            Andrew.Name = "Andrew";
            Andrew.DietType = "Carnivore";
            Andrew.Weight = 120;
            Andrew.EnclosureNumber = 11;

        }
    }
}
