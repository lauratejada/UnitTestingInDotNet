using Parkomatic.Data;

namespace Parkomatic.Models.BusinessLogicLayer
{
    public class VehicleBusinessLogic
    {
        private IRepository<Vehicle> _vehicleRepository;
        private IRepository<Pass> _passRepository;
        public VehicleBusinessLogic(IRepository<Vehicle> vehicleRepository, IRepository<Pass> passRepository)
        {
            _vehicleRepository = vehicleRepository;
            _passRepository = passRepository;
        }

        public Vehicle GetVehicle(int id)
        {
            try
            {
                return _vehicleRepository.Get(id);
            }
            catch
            {
                throw new Exception();
            }
        }

        /*
         * If a Vehicle has an associated Pass, it can book a ParkingSpace. 
         */
        public void AddPassToVehicle(Vehicle vehicle, int passId)
        {
            try
            {
                if (vehicle != null && passId > 0)
                {
                    vehicle.PassID = passId;
                    _vehicleRepository.Update(vehicle);
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public bool VehicleHasAssociatedPass(Vehicle vehicle, int? passId)
        {
            if (vehicle == null || passId <= 0)
            {
                return false;
            }

            if (vehicle.PassID != passId || vehicle.PassID <= 0)
            {
                return false;
            }

            return true;
        }

        public ICollection<Vehicle> GetAllVehicles()
        {
            try
            {
                return _vehicleRepository.GetAll();
            }
            catch
            {
                throw new Exception();
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            try
            {
                _vehicleRepository.Add(vehicle);
            }
            catch
            {
                throw new Exception();
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            try
            {
                _vehicleRepository.Delete(vehicle);
            }
            catch
            {
                throw new Exception();
            }
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            try
            {
                _vehicleRepository.Update(vehicle);
            }
            catch
            {
                throw new Exception();
            }
        }

        public ICollection<Pass> GetAllPasses()
        {
            try
            {
                return _passRepository.GetAll();
            }
            catch
            {
                throw new Exception();
            }
        }

    }
}
