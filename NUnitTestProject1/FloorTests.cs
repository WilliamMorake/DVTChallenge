using System;
using System.Collections.Generic;
using System.Text;
using DVTElevatorChallenge;
using NUnit.Framework;

namespace DVTElevatorUnitTests
{
    [TestFixture]
    public class FloorTests
    {
        private Floor floor;

        [SetUp]
        public void SetUp()
        {
            floor = new Floor(3);
        }

        [Test]
        public void AddWaitingPassengers_AddPassengers_DestinationFloorsAreSet()
        {
            // Arrange
            int[] destinationFloors = new int[] { 5, 2, 7 };

            // Act
            floor.AddWaitingPassengers(destinationFloors);

            // Assert
            CollectionAssert.AreEquivalent(destinationFloors, floor.GetWaitingPassengers());
        }

        [Test]
        public void RemoveWaitingPassengers_ValidNumPassengers_PassengersAreRemoved()
        {
            // Arrange
            int numPassengers = 4;
            for (int i = 0; i < numPassengers; i++)
            {
                floor.AddWaitingPassengers(5);
            }

            // Act
            floor.RemoveWaitingPassengers(numPassengers);

            // Assert
            CollectionAssert.IsEmpty(floor.GetWaitingPassengers());
        }
    }

}
