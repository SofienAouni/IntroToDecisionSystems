using System;

namespace DecisionSystems.TSP
{
    public class Location
    {
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public double GetDistance(Location otherLocation)
        {
            return Math.Sqrt(Math.Pow(this.X - otherLocation.X, 2) + Math.Pow(this.Y - otherLocation.Y, 2));
        }
    }
}