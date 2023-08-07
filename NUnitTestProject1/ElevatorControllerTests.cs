using DVTElevatorChallenge;
using NUnit.Framework;
using System;

namespace DVTElevatorUnitTests
{
    [TestFixture]
    public class ElevatorControllerTests
    {
        private ElevatorController elevatorController;

        [SetUp]
        public void SetUp()
        {
            int numFloors = 10;
            int numElevators = 1;
            int maxCapacity = 8;

            elevatorController = new ElevatorController(numFloors, numElevators, maxCapacity);
        }
    
        [Test]
        public void CallElevator_ElevatorIsAvailable_ElevatorMovesToRequestedFloor()
        {
            // Arrange
            int floorNumber = 5;
            int lastfloorNumber = 7;
            elevatorController.SetWaitingPassengers(floorNumber, 4, lastfloorNumber); // 2 passengers on floor 5 going to floors 4 and 7

            // Act
            elevatorController.CallElevator(floorNumber);

            // Assert
            var elevators = elevatorController.GetElevators();
            var elevator = elevators[0]; // Assuming there's only one elevator in the list
            Assert.AreEqual(lastfloorNumber, elevator.CurrentFloor);
        }

        [Test]
        public void SetWaitingPassengers_AddWaitingPassengers_ElevatorHasDestinationFloors()
        {
            // Arrange
            int floorNumber = 3;
            int[] destinationFloors = new int[] { 1, 6, 9 };

            // Act
            elevatorController.SetWaitingPassengers(floorNumber, destinationFloors);
            elevatorController.CallElevator(3);

            // Assert
            var elevators = elevatorController.GetElevators();
            var elevator = elevators[0]; // Assuming there's only one elevator in the list
            var destinationFloorsInElevator = elevator.GetDestinationFloors();
            Assert.AreEqual(destinationFloors.Length, destinationFloorsInElevator.Count);
            Assert.AreEqual(destinationFloors[0], destinationFloorsInElevator[0]);
            Assert.AreEqual(destinationFloors[1], destinationFloorsInElevator[1]);
            Assert.AreEqual(destinationFloors[2], destinationFloorsInElevator[2]);
        }
    }

}