using ElevatorSimulationApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulationApp.Services
{
    public class Building : IBuilding
    {
        public List<Elevator> Elevators { get; } = new List<Elevator>();
        public int NumFloors { get; }

        public Building(int numFloors, int numElevators)
        {
            NumFloors = numFloors;
            for (int i = 0; i < numElevators; i++)
            {
                Elevators.Add(new Elevator(1)); // All elevators start at floor 0
            }
        }

        public Elevator GetNearestElevator(int floor)
        {
            // Implement SCAN scheduling algorithm to find the nearest elevator
            // (e.g., FCFS, SCAN, or custom logic).
            Elevator nearestElevator = Elevators[0];
            int shortestDistance = Math.Abs(nearestElevator.CurrentFloor - floor);

            foreach (var elevator in Elevators)
            {
                int distance = Math.Abs(elevator.CurrentFloor - floor);
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    nearestElevator = elevator;
                }
            }

            return nearestElevator;
        }

        public void PickupPassenger(int floor, int destinationFloor)
        {
            Elevator elevator = GetNearestElevator(floor);
            elevator.Passengers.Add(new Passenger(destinationFloor));
        }

        public void DropOffPassengers(Elevator elevator)
        {
            // Check if any passengers have reached their destination floor and remove them.
            elevator.Passengers.RemoveAll(p => p.DestinationFloor == elevator.CurrentFloor);
        }
    }
}
