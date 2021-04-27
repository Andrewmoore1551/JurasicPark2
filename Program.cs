using System;
using System.Collections.Generic;
using System.Linq;

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
            Matt.Name = "matt";
            Matt.DietType = "carnivore";
            Matt.Weight = 500;
            Matt.EnclosureNumber = 3;

            var James = new Dino()
            {
                Name = "james",
                DietType = "herbivore",
                Weight = 100,
                EnclosureNumber = 6,
            };
            var Andrew = new Dino()
            {
                Name = "andrew",
                DietType = "carnivore",
                Weight = 120,
                EnclosureNumber = 11,
            };
            var dinos = new List<Dino>();

            dinos.Add(Matt);
            dinos.Add(James);
            dinos.Add(Andrew);

            BannerMessage("Welcome to Jurasic Park");

            var userHasChosenToQuit = false;

            while (userHasChosenToQuit == false)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("ADD - Add a new dino");
                Console.WriteLine("SEE - see all the dinos");
                Console.WriteLine("TRANSFER - Transfer a dino");
                Console.WriteLine("REMOVE - Remove a dino");
                Console.WriteLine("SUMMARY - View amount of herbivores and carnivores");

                Console.WriteLine("-------------------");
                Console.WriteLine("QUIT _ Quit the app");
                Console.WriteLine();
                Console.Write("What is your choice? ");
                var choice = Console.ReadLine().ToUpper().Trim();

                if (choice == "QUIT")
                {
                    userHasChosenToQuit = true;
                }

                if (choice == "ADD")
                {
                    var dino = new Dino();
                    Console.WriteLine("-------------------");
                    Console.Write("What is the dinos name? ");
                    dino.Name = Console.ReadLine().ToLower();
                    Console.Write("What is the diet type? ");
                    dino.DietType = Console.ReadLine().ToLower();
                    Console.Write("What is the dinos weight? ");
                    dino.Weight = int.Parse(Console.ReadLine());
                    Console.Write("What is the dinos enclosure number? ");
                    dino.EnclosureNumber = int.Parse(Console.ReadLine());
                    dinos.Add(dino);
                }
                if (choice == "REMOVE")
                {
                    Console.Write("What dino would you like to delete? ");
                    var dinoToDeleteName = Console.ReadLine().ToLower();
                    var dinoToDelete = dinos.First(firstDino => firstDino.Name == dinoToDeleteName);
                    dinos.Remove(dinoToDelete);
                }
                // error with transfering 
                if (choice == "TRANSFER")
                {
                    Console.Write("What is the name of the dino you'd like to transfer? ");
                    var dinoToTransferName = Console.ReadLine().ToLower();
                    var dinoToTransfer = dinos.Find(firstdino => firstdino.Name == dinoToTransferName);
                    Console.Write("Where would you like to transfer this dino to? ");
                    var newEnclosureNumber = int.Parse(Console.ReadLine());
                    dinoToTransfer.EnclosureNumber = newEnclosureNumber;


                }
                if (choice == "SEE")
                {
                    Console.WriteLine("List of dinos");
                    Console.WriteLine("----------------");
                    foreach (var dino in dinos)
                    {
                        Console.WriteLine($"{dino.Name} is a {dino.DietType} is weighing {dino.Weight}lbs and is in enclosure number {dino.EnclosureNumber}");
                    }

                }
                // error displaying how many carnivores and herbivores there is 
                if (choice == "SUMMARY")
                {
                    var carnivores = dinos.Where(dino => dino.DietType == "carnivore").Count();
                    var herbivores = dinos.Where(dino => dino.DietType == "herbivore").Count();
                    Console.Write($"There are {carnivores} number of carnivores. There are {herbivores} number of herbivores");
                }
            }
            BannerMessage("Goodbye");
        }
    }
}
