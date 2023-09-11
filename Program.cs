using ElevatorSimulationApp.Services;

namespace ElevatorSimulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(10, 3);

            while (true)
            {
                Console.WriteLine("Enter the floor you are on (0-15):");
                int currentFloor = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the destination floor (0-15):");
                int destinationFloor = int.Parse(Console.ReadLine());

                if (currentFloor >= 0 && currentFloor <= 15 &&
                    destinationFloor >= 0 && destinationFloor <= 15)
                {
                    building.PickupPassenger(currentFloor, destinationFloor);
                    Console.WriteLine("Passenger added to queue.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Floors must be between 1 and 10.");
                }
            }
        }
    }
}
    