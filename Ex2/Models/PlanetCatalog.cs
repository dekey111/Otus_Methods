using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class PlanetCatalog
    {
        static List<Planet> _planets = new List<Planet>();
        private static int _counter;

        public PlanetCatalog()
        {
            _planets.Add(new Planet("Venus", 2, 37604.5, "Mercury"));
            _planets.Add(new Planet("Earth", 3, 40075.0, "Venus"));
            _planets.Add(new Planet("Mars", 4, 21344.0, "Earth"));
        }

        public static (int, double, string) GetPlanet(string planetName)
        {
            _counter++;
            if (_counter == 3)
            {
                _counter = 0;
                return (-1, -1.0, "Вы спрашиваете слишком часто");          
            }


            var findPlanet = _planets.FirstOrDefault(x => x.Name.ToLower().Contains(planetName.ToLower()));
            if (findPlanet == null)
                return (-1, -1.0, "Не удалось найти планету!");

            return (findPlanet.OrderNumber, findPlanet.EquatorLength, string.Empty);
        }
    }
}
