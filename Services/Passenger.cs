using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulationApp.Services
{
    public class Passenger
    {
        public int DestinationFloor { get; }

        public Passenger(int destinationFloor)
        {
            DestinationFloor = destinationFloor;
        }
    }
}
