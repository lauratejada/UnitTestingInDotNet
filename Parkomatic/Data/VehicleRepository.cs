using Parkomatic.Models;

namespace Parkomatic.Data
{
    public class VehicleRepository : IRepository<Vehicle>
    {
        private ParkomaticContext _context;
        public VehicleRepository(ParkomaticContext context)
        {
            _context = context;
        }

        public Vehicle Create(Vehicle entity)
        {
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Add(Vehicle entity)
        {
            _context.Vehicles.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Vehicle entity)
        {
            _context.Vehicles.Remove(entity);
            _context.SaveChanges();
        }

        public Vehicle Get(int id)
        {
            Vehicle vehicle = _context.Vehicles.Find(id);
            return vehicle;
        }

        public ICollection<Vehicle> GetAll()
        {
            return _context.Vehicles.ToHashSet();
        }

        public Vehicle Update(Vehicle entity)
        {
            _context.Vehicles.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
