using System;
using System.Collections.Generic;
using System.Text;

namespace DVTElevatorChallenge
{
    public enum Direction
    {
        Up,
        Down,
        None
    }

    public class Elevator
    {
        public int MaxCapacity { get; private set; }
        public int CurrentCapacity { get; private set; }
        public int CurrentFloor { get; private set; }
        public Direction CurrentDirection { get; private set; }
        private List<int> DestinationFloors { get; set; }

        public Elevator(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
            CurrentCapacity = 0;
            CurrentFloor = 1;
            CurrentDirection = Direction.None;
            DestinationFloors = new List<int>();
        }

        public void MoveToFloor(int floorNumber)
        {
            if (floorNumber < 1 || floorNumber > 10)
            {
                Console.WriteLine("Invalid floor number.");
                return;
            }

            if (CurrentFloor == floorNumber)
            {
                Console.WriteLine($"Elevator is already on floor {floorNumber}.");
                return;
            }

            CurrentDirection = floorNumber > CurrentFloor ? Direction.Up : Direction.Down;

            // Move the elevator to the target floor
            while (CurrentFloor != floorNumber)
            {
                Console.WriteLine($"Elevator moving {CurrentDirection.ToString().ToLower()}... Current floor: {CurrentFloor}");
                System.Threading.Thread.Sleep(1000); // Simulating elevator movement between floors (1 second delay)
                if (CurrentDirection == Direction.Up)
                    CurrentFloor++;
                else
                    CurrentFloor--;

            }

            Console.WriteLine($"Elevator arrived at floor {CurrentFloor}");
            CurrentDirection = Direction.None;
        }

        public void AddPassenger(int destinationFloor)
        {
            if (CurrentCapacity >= MaxCapacity)
            {
                Console.WriteLine("Elevator is at full capacity. Cannot add more passengers.");
                return;
            }

            DestinationFloors.Add(destinationFloor);
            CurrentCapacity++;
        }

        public void RemovePassenger(int numPassengers)
        {
            if (CurrentCapacity >= numPassengers)
            {
                DestinationFloors.RemoveRange(0, numPassengers);
                CurrentCapacity -= numPassengers;
            }
        }

        public List<int> GetDestinationFloors()
        {
            return DestinationFloors;
        }

        public void ClearCapacity()
        {
            CurrentCapacity = 0;
        }
    }


}
