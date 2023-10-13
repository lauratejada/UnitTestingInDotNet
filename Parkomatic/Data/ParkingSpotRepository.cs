using Parkomatic.Models;

namespace Parkomatic.Data
{
    public class ParkingSpotRepository : IRepository<ParkingSpot>
    {
        private ParkomaticContext _context;
        public ParkingSpotRepository(ParkomaticContext context)
        {
            _context = context;
        }

        public ParkingSpot Create(ParkingSpot entity)
        {
            _context.ParkingSpots.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Add(ParkingSpot entity)
        {
            _context.ParkingSpots.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(ParkingSpot entity)
        {
            _context.ParkingSpots.Remove(entity);
            _context.SaveChanges();
        }

        public ParkingSpot Get(int id)
        {
            ParkingSpot parkingSpot = _context.ParkingSpots.Find(id);
            return parkingSpot;
        }

        public ICollection<ParkingSpot> GetAll()
        {
            return _context.ParkingSpots.ToHashSet();
        }

        public ParkingSpot Update(ParkingSpot entity)
        {
            _context.ParkingSpots.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
