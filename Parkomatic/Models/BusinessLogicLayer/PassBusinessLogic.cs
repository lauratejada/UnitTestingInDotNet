using Parkomatic.Data;

namespace Parkomatic.Models.BusinessLogicLayer
{
    public class PassBusinessLogic
    {
        private IRepository<Pass> _passRepository;
        private IRepository<Vehicle> _vehicleRepository;

        public PassBusinessLogic(IRepository<Pass> passRepository, IRepository<Vehicle> vehicleRepository)
        {
            _passRepository = passRepository;
            _vehicleRepository = vehicleRepository;
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

        public Pass GetPass(int id)
        {
            try
            {
                return _passRepository.Get(id);
            }
            catch
            {
                throw new Exception();
            }
        }

        /*Users buy a Pass, which can be applied up to a number of vehicles up to its Capacity. If a user buys a pass for three cars, that Pass’ Vehicles list may list up to three vehicles.
        */
        public bool UserBuyAPass(int capacity)
        {
            if (capacity <= 0)
            {
                return false;
            }

            Pass newPass = new Pass
            {
                Capacity = capacity
            };

            try
            {
                _passRepository.Add(newPass);   

                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
            
        }

    }
}
