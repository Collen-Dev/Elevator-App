using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSimulationApp.Interfaces
{
    public interface IElevator
    {
        void MoveToFloor(int targetFloor);
    }
}
