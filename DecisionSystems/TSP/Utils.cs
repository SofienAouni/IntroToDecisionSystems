using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionSystems.TSP
{
    public static class Utils
    {
        public static double GetDistance(IReadOnlyCollection<int> solution, IReadOnlyList<Location> cities)
        {
            var previousCityIndex = solution.Last();
            var distance = 0.0;

            foreach (var cityIndex in solution)
            {
                var previousCity = cities[previousCityIndex - 1];
                var city = cities[cityIndex - 1];

                distance += city.GetDistance(previousCity);
                previousCityIndex = cityIndex;
            }


            return distance;
        }
    }
}