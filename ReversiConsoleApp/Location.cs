using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiConsoleApp
{
    class Location
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Location(int X_coordinate, int Y_coordinate) 
        {
            this.X = X_coordinate;
            this.Y = Y_coordinate;
        }
    }
}
