using System;

namespace DVTElevatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFloors = 10;
            int numElevators = 3;
            int maxCapacity = 8;

            ElevatorController elevatorController = new ElevatorController(numFloors, numElevators, maxCapacity);

            // Setting the number of people waiting on each floor
            elevatorController.SetWaitingPassengers(2, 4);
            elevatorController.SetWaitingPassengers(5, 2);
            elevatorController.SetWaitingPassengers(8, 3);

            // Showing the initial elevator status
            Console.WriteLine("Initial Elevator Status:");
            elevatorController.ShowElevatorStatus();

            // Calling the elevators to specific floors
            elevatorController.CallElevator(3);
            elevatorController.CallElevator(7);
            elevatorController.CallElevator(10);

            // Showing the updated elevator status
            Console.WriteLine("Updated Elevator Status:");
            elevatorController.ShowElevatorStatus();

            Console.ReadKey();
        }
    }

}
