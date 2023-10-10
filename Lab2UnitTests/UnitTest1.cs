using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Lab2UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        /* When initialized, a VehicleTracker object should have empty slots [{SlotNumber, Vehicle}] from 1 - Capacity in VehicleTracker.VehicleList (ie. { {1, null}, {2, null}, {3,null}, //etc}
        */
        [TestMethod]
        public void InitializeVehicleTracker_ShouldHaveEmptySlots()
        {
            // Arrange
            int capacity = 5;
            string address = "123 Fake st";

            // Act
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, address);

            // Assert
            CollectionAssert.AreEqual(
                           new Dictionary<int, Vehicle>
                            {
                            { 1, null },
                            { 2, null },
                            { 3, null },
                            { 4, null },
                            { 5, null }
                            },
                            vehicleTracker.VehicleList);
        }

        /* If the AddVehicle method is called, it should add the vehicle to the first slot in VehicleList that is not full. If there are no open slots, it should throw a generic exception with the VehicleTracker.AllSlotsFull message.
         */
        [TestMethod]
        public void AddVehicle_ShouldAddToFirstAvailableSlot()
        {
            // Arrange
            int capacity = 5;
            string address = "123 Fake st";
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, address);
            Vehicle vehicle1 = new Vehicle("A01 T22", true);
            Vehicle vehicle2 = new Vehicle("A02 T23", true);

            // Act
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.AddVehicle(vehicle2);

            // Assert
            CollectionAssert.AreEqual(
                new Dictionary<int, Vehicle>
                {
                { 1, vehicle1 },
                { 2, vehicle2 },
                { 3, null },
                { 4, null },
                { 5, null }
                },
                vehicleTracker.VehicleList);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddVehicle_ShouldThrowExceptionIfAllSlotsAreFull()
        {
            // Arrange
            int capacity = 2;
            string address = "123 Fake st";
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, address);
            Vehicle vehicle1 = new Vehicle("A01 T22", true);
            Vehicle vehicle2 = new Vehicle("A02 T23", true);
            Vehicle vehicle3 = new Vehicle("A03 T24", true);

            // Act
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.AddVehicle(vehicle2);
            vehicleTracker.AddVehicle(vehicle3); // This should throw an exception

            //assert
            //Assert.ThrowsException<IndexOutOfRangeException>(vehicleTracker.AddVehicle(vehicle3));
            
        }

        /* RemoveVehicle should accept either a licence or slot number, and set that slot’s vehicle to “null”.
         */
        [TestMethod]
        public void RemoveVehicle_ShouldRemoveByLicensePlate()
        {
            // Arrange
            int capacity = 2;
            string address = "123 Fake st";
            VehicleTracker vehicleTracker = new VehicleTracker(capacity, address);
            Vehicle vehicle1 = new Vehicle("A01 T22", true);
            Vehicle vehicle2 = new Vehicle("A02 T23", true);
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.AddVehicle(vehicle2);

            // Act
            vehicleTracker.RemoveVehicle("A02 T23");

            // Assert
            CollectionAssert.AreEqual(
                               new Dictionary<int, Vehicle>
                                {
                                { 1, vehicle1 },
                                { 2, null }
                                },
                                vehicleTracker.VehicleList);
        }

        /* RemoveVehicle should throw an exception if the licence passed to RemoveVehicle() is not found, if the slot number is invalid (greater than capacity or negative), or the slot is not filled.
         */
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveVehicle_ThrowExceptionIfLicenseNotFound()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");

            // Act
            vehicleTracker.RemoveVehicle("InvalidLicense"); // This should throw an exception

            // Assert
        }

        [TestMethod]
        public void RemoveVehicle_ShouldRemoveBySlotNumber()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");
            var vehicle1 = new Vehicle("A01 T22", true);
            vehicleTracker.AddVehicle(vehicle1);

            // Act
            vehicleTracker.RemoveVehicle(1);

            // Assert
            CollectionAssert.AreEqual(
                Enumerable.Range(1, 10).ToDictionary(i => i, _ => (Vehicle)null),
                vehicleTracker.VehicleList);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveVehicle_ShouldThrowExceptionIfInvalidSlotNumber()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");

            // Act
            vehicleTracker.RemoveVehicle(11); // This should throw an exception
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveVehicle_ShouldThrowExceptionIfSlotNotFilled()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");

            // Act
            vehicleTracker.RemoveVehicle(1); // This should throw an exception
        }

        /* The VehicleTracker.ParkedPassholders() method should return a list of all parked vehicles that have a pass.
         */
        [TestMethod]
        public void ParkedPassholders_ShouldReturnListOfPassholders()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");
            Vehicle vehicle1 = new Vehicle("A01 T22", true);
            Vehicle vehicle2 = new Vehicle("A02 T23", false);
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.AddVehicle(vehicle2);

            // Act
            var passholders = vehicleTracker.ParkedPassholders();

            // Assert
            CollectionAssert.Contains(passholders, vehicle1);
            CollectionAssert.DoesNotContain(passholders, vehicle2);
        }

        /* VehicleTracker.PassholderPercentage() method should return the percentage of vehicles that are parked which have passes. Note that this method uses the ParkedPassholders() method to get a count of passholders.
         */
        [TestMethod]
        public void PassholderPercentage_ReturnPercentageOfParkedVehiclesWithPasses()
        {
            // Arrange
            VehicleTracker vehicleTracker = new VehicleTracker(10, "123 Fake st");
            Vehicle vehicle1 = new Vehicle("A01 T22", true);
            Vehicle vehicle2 = new Vehicle("A02 T23", true);
            Vehicle vehicle3 = new Vehicle("A03 T24", false);
            vehicleTracker.AddVehicle(vehicle1);
            vehicleTracker.AddVehicle(vehicle2);
            vehicleTracker.AddVehicle(vehicle3);

            // Act
            double percentage = vehicleTracker.PassholderPercentage();

            // Assert
            Assert.AreEqual(20, percentage); // Expected percentage is 20
        }
    }
}





