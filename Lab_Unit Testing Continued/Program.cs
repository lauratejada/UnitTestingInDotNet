class Program
{
    static void Main(string[] args)
    {
        /* declare a new VehicleTracker class, with a capacity for 10 cars, on 123 Fake St.
        Construct a Dictionary of 10 key-value pairs {number, parked car}, where parked car is null and values are 1 - 10 */
        VehicleTracker vt = new VehicleTracker(10, "123 Fake st");

        // declare a new Vehicle with the licence place “A01 T22”, and with a parking pass (bool true)
        Vehicle customerOne = new Vehicle("A01 T22", true);

        /* Add a vehicle to vt’s VehicleList property. It replaces the first “unoccupied” value in VehicleList, so we expect vt.VehicleList = {{1, customerOne}, {2, null}, {3, null}, etc} */
        vt.AddVehicle(customerOne);

        // Change the value of slot 1 in VehicleList to null 
        vt.RemoveVehicle("A0T T22");
    }
}

public class Vehicle
{
    public string Licence { get; set; }
    public bool Pass { get; set; }
    public Vehicle(string licence, bool pass)
    {
        this.Licence = licence;
        this.Pass = pass;
    }
}

public class VehicleTracker
{
    //PROPERTIES
    public string Address { get; set; }
    public int Capacity { get; set; }
    public int SlotsAvailable { get; set; }
    public Dictionary<int, Vehicle> VehicleList { get; set; }

    public VehicleTracker(int capacity, string address)
    {
        this.Capacity = capacity;
        this.Address = address;
        this.VehicleList = new Dictionary<int, Vehicle>();

        this.GenerateSlots();
    }

    // STATIC PROPERTIES
    public static string BadSearchMessage = "Error: Search did not yield any result.";
    public static string BadSlotNumberMessage = "Error: No slot with number ";
    public static string SlotsFullMessage = "Error: no slots available.";

    // METHODS
    public void GenerateSlots()
    {
        for (int i = 1; i <= this.Capacity; i++)
        {
            this.VehicleList.Add(i, null);
        }
    }

    public void AddVehicle(Vehicle vehicle)
    {
        try
        {
            bool slotFound = false;

            foreach (KeyValuePair<int, Vehicle> slot in this.VehicleList)
            {
                if (slot.Value == null)
                {
                    this.VehicleList[slot.Key] = vehicle;
                    this.SlotsAvailable++;
                    slotFound = true;
                    break; // Exit the loop as soon as a slot is found
                }
            }

            if (!slotFound)
            {
                throw new InvalidOperationException(SlotsFullMessage);
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void RemoveVehicle(string licence)
    {
        try
        {
            var slotKeyValuePair = this.VehicleList.FirstOrDefault(v => v.Value != null && v.Value.Licence == licence);

            if (slotKeyValuePair.Value == null)
            {
                throw new Exception(BadSearchMessage);
            }
            
            int slot = slotKeyValuePair.Key;
            this.SlotsAvailable--;
            this.VehicleList[slot] = null;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void RemoveVehicle(int slotNumber)
    {
        try
        {
            if (slotNumber < 1 || slotNumber > this.Capacity || VehicleList[slotNumber] == null)
            {
               throw new Exception(BadSlotNumberMessage);
            }

            this.VehicleList[slotNumber] = null;
            this.SlotsAvailable++;
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Vehicle> ParkedPassholders()
    {
        List<Vehicle> passHolders = new List<Vehicle>();

        foreach (var vehicle in this.VehicleList.Values)
        {
            if (vehicle != null && vehicle.Pass)
            {
                passHolders.Add(vehicle);
            }
        }

        return passHolders;
    }

    public double PassholderPercentage()
    {
        int passHolders = ParkedPassholders().Count();

        if (this.Capacity == 0)
        {
            return 0; // Avoid division by zero
        }

        double percentage = ((double)passHolders / this.Capacity) * 100;
        return percentage;
    }
}

