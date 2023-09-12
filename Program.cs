using ElevatorSimulationApp.Interfaces;
using ElevatorSimulationApp.Services;

namespace ElevatorSimulationApp
{
    class Program
    {
        const int NUM_FLOORS = 15;
        const int NUM_ELEVATORS = 3;
        static void Main(string[] args)
        {
            Building building = new Building(NUM_FLOORS, NUM_ELEVATORS);
            Elevator elevator = new Elevator(1); // intial floor

            while (true)
            {

                Console.WriteLine("Please enter the floor you are on (1-15):");
                int currentFloor = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the destination floor (1-15):");
                int destinationFloor = int.Parse(Console.ReadLine());

                if (currentFloor >= 1 && currentFloor <= 15 
                    && destinationFloor >= 1 && destinationFloor <= 15)
                {
                    building.PickupPassenger(currentFloor, destinationFloor);
                    Console.WriteLine("Passenger has been added to queue.");

                    elevator.MoveToFloor(destinationFloor);
                }
                else
                {
                    Console.WriteLine("Wrong input. Floors must be between 1 and 15.");
                }

            }
        }
    }
}
    