using ElevatorSimulationApp.Interfaces;
using System.Timers;

namespace ElevatorSimulationApp.Services
{
    public class Building : IBuilding
    {
        public List<Elevator> Elevators { get; } = new List<Elevator>();
        public int NumFloors { get; }
        public Elevator elevator { get; set; }

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
            // We implement SCAN scheduling algorithm to find the nearest elevator
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
            elevator = GetNearestElevator(floor);
            elevator.Passengers.Add(new Passenger(destinationFloor));
        }

        public void DropOffPassengers(Elevator elevator)
        {
            // Check if any passengers have reached their destination floor and remove them.
            elevator.Passengers.RemoveAll(p => p.DestinationFloor == elevator.CurrentFloor);

        }

        //public void GetElevatorFloor(object sender, ElapsedEventArgs e)
        //{

        //    if (elevator.CurrentFloor == elevator.Passengers.FirstOrDefault()?.DestinationFloor)
        //    {
        //        DropOffPassengers(elevator);

        //        int count = elevator.Passengers.Where(p=> p.DestinationFloor == elevator.CurrentFloor).Count();
        //        Console.WriteLine($"{count} passengers getting off.");
        //    }
        //}
    }
}
