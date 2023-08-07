using System;
using System.Collections.Generic;
using System.Text;

namespace DVTElevatorChallenge
{
    public class Floor
    {
        public int FloorNumber { get; private set; }
        public List<int> WaitingPassengers { get; private set; }

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            WaitingPassengers = new List<int>();
        }

        public void AddWaitingPassengers(params int[] destinationFloors)
        {
            WaitingPassengers.AddRange(destinationFloors);
            Console.WriteLine($"Passengers are waiting on floor {FloorNumber}.");
        }

        public List<int> GetWaitingPassengers()
        {
            return WaitingPassengers;
        }

        public void RemoveWaitingPassengers(int numPassengers)
        {
            WaitingPassengers.RemoveRange(0, numPassengers);
            Console.WriteLine($"{numPassengers} passengers were picked up from floor {FloorNumber}.");
        }
    }

}
