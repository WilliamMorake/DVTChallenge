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
        public int CurrentFloor { get; private set; }
        public Direction CurrentDirection { get; private set; }
        public int MaxCapacity { get; private set; }
        public int CurrentCapacity { get; private set; }

        public Elevator(int maxCapacity)
        {
            CurrentFloor = 1; // The elevator starts at the first floor
            CurrentDirection = Direction.None; // The initial direction is none
            MaxCapacity = maxCapacity;
            CurrentCapacity = 0;
        }

        public void MoveToFloor(int targetFloor)
        {
            CurrentDirection = targetFloor > CurrentFloor ? Direction.Up : Direction.Down;
            while (CurrentFloor != targetFloor)
            {
                CurrentFloor += CurrentDirection == Direction.Up ? 1 : -1;
                Console.WriteLine($"Elevator is moving to floor {CurrentFloor}.");
            }
            CurrentDirection = Direction.None;
        }

        public void AddPassenger(int numPassengers)
        {
            if (CurrentCapacity + numPassengers > MaxCapacity)
            {
                Console.WriteLine("Cannot add passengers, weight limit reached.");
                return;
            }

            CurrentCapacity += numPassengers;
            Console.WriteLine($"{numPassengers} passengers added. Current capacity: {CurrentCapacity}/{MaxCapacity}");
        }

        public void RemovePassenger(int numPassengers)
        {
            CurrentCapacity -= numPassengers;
            Console.WriteLine($"{numPassengers} passengers removed. Current capacity: {CurrentCapacity}/{MaxCapacity}");
        }
    }

}
