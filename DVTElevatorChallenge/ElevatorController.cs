using System;
using System.Collections.Generic;
using System.Text;

namespace DVTElevatorChallenge
{
    public class ElevatorController
    {
        private List<Elevator> elevators;
        private List<Floor> floors;

        public ElevatorController(int numFloors, int numElevators, int maxCapacity)
        {
            floors = new List<Floor>();
            for (int i = 1; i <= numFloors; i++)
            {
                floors.Add(new Floor(i));
            }

            elevators = new List<Elevator>();
            for (int i = 0; i < numElevators; i++)
            {
                elevators.Add(new Elevator(maxCapacity));
            }
        }

        public void ShowElevatorStatus()
        {
            foreach (var elevator in elevators)
            {
                string status = $"{(elevator.CurrentDirection == Direction.None ? "Idle" : elevator.CurrentDirection.ToString())} " +
                                $"at floor {elevator.CurrentFloor}, " +
                                $"Carrying {elevator.CurrentCapacity}/{elevator.MaxCapacity} passengers.";
                Console.WriteLine(status);
            }
        }

        public void CallElevator(int floorNumber)
        {
            // Find the nearest available elevator
            Elevator nearestElevator = null;
            int minDistance = int.MaxValue;

            foreach (var elevator in elevators)
            {
                if (elevator.CurrentDirection == Direction.None)
                {
                    int distance = Math.Abs(elevator.CurrentFloor - floorNumber);
                    if (distance < minDistance)
                    {
                        nearestElevator = elevator;
                        minDistance = distance;
                    }
                }
            }

            if (nearestElevator == null)
            {
                Console.WriteLine("All elevators are busy. Please wait.");
                return;
            }

            nearestElevator.MoveToFloor(floorNumber);
            nearestElevator.RemovePassenger(floors[floorNumber - 1].NumberOfPeopleWaiting);
            floors[floorNumber - 1].RemoveWaitingPassengers(floors[floorNumber - 1].NumberOfPeopleWaiting);
        }

        public void SetWaitingPassengers(int floorNumber, int numPassengers)
        {
            floors[floorNumber - 1].AddWaitingPassengers(numPassengers);
        }
    }

}
