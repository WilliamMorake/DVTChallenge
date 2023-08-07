using System;

namespace DVTElevatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int numFloors = 10;
             int numElevators = 3;
             int maxCapacity = 8;

             ElevatorController elevatorController = new ElevatorController(numFloors, numElevators, maxCapacity);

             // Setting the number of people waiting on each floor and their destination floors
             elevatorController.SetWaitingPassengers(2, 4, 7); // passengers on floor 2 going to floors 4 and 7
             elevatorController.SetWaitingPassengers(1, 3);    // passengers on floor 1 going to floor 3
             elevatorController.SetWaitingPassengers(8, 4, 5, 6); // passengers on floor 8 going to floors 4, 5, and 6

             // Showing the initial elevator status
             Console.WriteLine("Initial Elevator Status:");
             elevatorController.ShowElevatorStatus();

             // Showing the waiting passenger destinations
             Console.WriteLine("\nWaiting Passenger Destinations:");
             elevatorController.ShowWaitingPassengerDestinations();

             // Calling the elevators to specific floors
             elevatorController.CallElevator(2);
             elevatorController.CallElevator(1);
             //elevatorController.CallElevator(10);

             // Showing the updated elevator status
             Console.WriteLine("\nUpdated Elevator Status:");
             elevatorController.ShowElevatorStatus();
             elevatorController.CallElevator(8);

             // Showing the updated elevator status
             Console.WriteLine("\nUpdated Elevator Status:");
             elevatorController.ShowElevatorStatus();

             // Showing the updated waiting passenger destinations
             Console.WriteLine("\nUpdated Waiting Passenger Destinations:");
             elevatorController.ShowWaitingPassengerDestinations();*/
            // Arrange

            int maxCapacity = 8;
            Elevator elevator = new Elevator(maxCapacity);
            int numPassengers = 7;
            for (int i = 0; i < numPassengers; i++)
            {
                elevator.AddPassenger(i + 1);
            }
            Console.WriteLine("\n count: "+ elevator.MaxCapacity);

            // Act
            elevator.RemovePassenger(numPassengers + 1);

            Console.WriteLine("\n After count: " + elevator.MaxCapacity);
            Console.ReadKey();
        }
    }


}
