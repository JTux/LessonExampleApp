using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    class Planet
    {
        public Planet() { }

        public Planet(int size, bool habitable, string color)
        {
            PlanetSize = size;
            Habitable = habitable;
            Color = color;
        }

        public int PlanetSize { get; set; }
        public bool Habitable { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{PlanetSize} {Habitable} {Color}";
        }
    }
}
