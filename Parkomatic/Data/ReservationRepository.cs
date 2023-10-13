using Parkomatic.Models;

namespace Parkomatic.Data
{
    public class ReservationRepository : IRepository<Reservation>
    {
        private ParkomaticContext _context;
        public ReservationRepository(ParkomaticContext context)
        {
            _context = context;
        }

        public Reservation Create(Reservation entity)
        {
            _context.Reservations.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Add(Reservation entity)
        {
            _context.Reservations.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Reservation entity)
        {
            _context.Reservations.Remove(entity);
            _context.SaveChanges();
        }

        public Reservation Get(int id)
        {
            Reservation reservation = _context.Reservations.Find(id);
            return reservation;
        }

        public ICollection<Reservation> GetAll()
        {
            return _context.Reservations.ToHashSet();
        }

        public Reservation Update(Reservation entity)
        {
            _context.Reservations.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
