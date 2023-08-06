using System;
using System.Collections.Generic;
using System.Text;

namespace DVTElevatorChallenge
{
    public class Floor
    {
        public int FloorNumber { get; private set; }
        public int NumberOfPeopleWaiting { get; private set; }

        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            NumberOfPeopleWaiting = 0;
        }

        public void AddWaitingPassengers(int numPassengers)
        {
            NumberOfPeopleWaiting += numPassengers;
            Console.WriteLine($"{numPassengers} passengers are waiting on floor {FloorNumber}.");
        }

        public void RemoveWaitingPassengers(int numPassengers)
        {
            NumberOfPeopleWaiting -= numPassengers;
            Console.WriteLine($"{numPassengers} passengers were picked up from floor {FloorNumber}.");
        }
    }

}
