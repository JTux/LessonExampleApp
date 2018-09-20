using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class PlanetRepository
    {
        private List<Planet> planetList = new List<Planet>();

        public void Add(int size, bool habitable, string color)
        {
            Planet newPlanet = new Planet(size, habitable, color);
            planetList.Add(newPlanet);
        }

        public List<Planet> GetPlanets() => planetList;

        public void RemoveByColor(string color)
        {
            var removePlanet = planetList.Find(p => p.Color.ToLower() == color.ToLower());
            if (removePlanet != null) planetList.Remove(removePlanet);
        }
    }
}
