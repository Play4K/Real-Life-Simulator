using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Life_Simulator
{
    internal class World
    {
        //List for all Locations of Game
        private List<Location> _locations = new List<Location>();

        //World Location Adder
        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imagePath)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImagePath = imagePath;

            _locations.Add(loc);
        }

        public Location GetLocationAt(int xCoordinate, int yCoordinate)
        {
            foreach(Location loc in _locations)
            {
                if (loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}
