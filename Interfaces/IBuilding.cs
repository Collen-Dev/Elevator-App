using ElevatorSimulationApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulationApp.Interfaces
{
    public interface IBuilding
    {
        void PickupPassenger(int floor, int destinationFloor);
        void DropOffPassengers(Elevator elevator);
        Elevator GetNearestElevator(int floor);
    }
}
