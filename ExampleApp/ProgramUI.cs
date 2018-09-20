using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class ProgramUI
    {
        private PlanetRepository planetRepo = new PlanetRepository();

        public void Run()
        {
            var keepRunning = true;
            while (keepRunning)
            {
                PrintMenu();
                var input = ParseIntput();
                switch (input)
                {
                    case 1:
                        AddPlanet();
                        break;
                    case 2:
                        DisplayPlanets();
                        break;
                    case 3:
                        RemoveByColor();
                        break;
                    case 4:
                        //-- Search Planet
                        break;
                    case 5:
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine($"Options:\n" +
                $"1) Add Planet\n" +
                $"2) View all Planets\n" +
                $"3) Remove a Planet\n" +
                $"4) Search Planets\n" +
                $"5) Exit");
        }

        private void AddPlanet()
        {
            Console.Clear();
            Console.WriteLine("How many kilometers across is the planet?");
            var planetSize = ParseIntput();

            bool habitable;
            Console.WriteLine("Can you live there? (y/n)");
            var boolResponse = Console.ReadLine();
            if (boolResponse.ToLower() == "y") habitable = true;
            else habitable = false;

            Console.WriteLine("What color is it?");
            var planetColor = Console.ReadLine();

            planetRepo.Add(planetSize, habitable, planetColor);
        }

        private void DisplayPlanets()
        {
            List<Planet> planetList = planetRepo.GetPlanets();

            foreach(Planet planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }

        private void RemoveByColor()
        {
            Console.Clear();
            Console.WriteLine("What color planet do you want to remove?");
            var input = Console.ReadLine();
            planetRepo.RemoveByColor(input);
        }

        private int ParseIntput()
        {
            int value;
            while (true)
            {
                var valueAsString = Console.ReadLine();
                if (int.TryParse(valueAsString, out value)) break;
                else Console.Write("Please enter a valid integer: ");
            }
            return value;
        }
    }
}
