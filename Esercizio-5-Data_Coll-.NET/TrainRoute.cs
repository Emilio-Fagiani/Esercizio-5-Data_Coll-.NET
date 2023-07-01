using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5_Data_Coll_.NET
{
    class TrainRoute
    {
        private LinkedList<TrainStation> route;

        public TrainRoute()
        {
            route = new LinkedList<TrainStation>();
        }

        public void AddStation(string stationName)
        {
            TrainStation station = new TrainStation(stationName);
            route.AddLast(station);
        }

        public void RemoveStation(string stationName)
        {
            TrainStation stationToRemove = null;
            foreach (var station in route)
            {
                if (station.Name.Equals(stationName, StringComparison.OrdinalIgnoreCase))
                {
                    stationToRemove = station;
                    break;
                }
            }

            if (stationToRemove != null)
            {
                route.Remove(stationToRemove);
            }
            else
            {
                Console.WriteLine("Station not found in the route.");
            }
        }

        public void DisplayRoute()
        {
            Console.WriteLine("Train Route:");
            foreach (var station in route)
            {
                Console.WriteLine(station.Name);
            }
        }
    }
}

