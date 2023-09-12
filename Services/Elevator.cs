using ElevatorSimulationApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ElevatorSimulationApp.Services
{
    public class Elevator : IElevator
    {
        public int CurrentFloor { get; private set; }
        public ElevatorDirection Direction { get; private set; }
        public List<Passenger> Passengers { get; } = new List<Passenger>();

        public Elevator(int initialFloor)
        {
            CurrentFloor = initialFloor;
            Direction = ElevatorDirection.Stopped;
        }

        public void MoveToFloor(int targetFloor)
        {
            if (targetFloor > CurrentFloor)
            {
                Direction = ElevatorDirection.Up;
            }
            else if (targetFloor < CurrentFloor)
            {
                Direction = ElevatorDirection.Down;
            }
            else
            {
                Direction = ElevatorDirection.Stopped;
            }

            Console.WriteLine($"Elevator moving {Direction} from floor {CurrentFloor} to floor {targetFloor}.");
            CurrentFloor = targetFloor;
        }

        //public int GetPassengersCount() => elevator.Passengers.Count;
    }
}
