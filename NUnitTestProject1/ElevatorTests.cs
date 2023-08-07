using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using DVTElevatorChallenge;

namespace DVTElevatorUnitTests
{


    [TestFixture]
    public class ElevatorTests
    {
        private Elevator elevator;

        [SetUp]
        public void SetUp()
        {
            int maxCapacity = 8;
            elevator = new Elevator(maxCapacity);
        }

        [Test]
        public void MoveToFloor_ValidFloorNumber_ElevatorArrivesAtRequestedFloor()
        {
            // Arrange
            int targetFloor = 4;

            // Act
            elevator.MoveToFloor(targetFloor);

            // Assert
            Assert.AreEqual(targetFloor, elevator.CurrentFloor);
        }

        [Test]
        public void AddPassenger_ElevatorNotAtMaxCapacity_PassengerIsAdded()
        {
            // Arrange
            int destinationFloor = 3;

            // Act
            elevator.AddPassenger(destinationFloor);

            // Assert
            Assert.Contains(destinationFloor, elevator.GetDestinationFloors());
            Assert.AreEqual(1, elevator.CurrentCapacity);
        }

        [Test]
        public void AddPassenger_ElevatorAtMaxCapacity_PassengerIsNotAdded()
        {
            // Arrange
            int maxCapacity = elevator.MaxCapacity;
            for (int i = 0; i < maxCapacity; i++)
            {
                elevator.AddPassenger(i + 1);
            }

            // Act
            elevator.AddPassenger(maxCapacity + 1);

            // Assert
            Assert.IsFalse(elevator.GetDestinationFloors().Contains(maxCapacity + 1));
            Assert.AreEqual(maxCapacity, elevator.CurrentCapacity);
        }

        [Test]
        public void RemovePassenger_ValidNumPassengers_PassengersAreRemoved()
        {
            // Arrange
            int numPassengers = 3;
            for (int i = 0; i < numPassengers; i++)
            {
                elevator.AddPassenger(i + 1);
            }

            // Act
            elevator.RemovePassenger(numPassengers);

            // Assert
            Assert.IsEmpty(elevator.GetDestinationFloors());
            Assert.AreEqual(0, elevator.CurrentCapacity);
        }

    }

}
