using Parkomatic.Data;

namespace Parkomatic.Models.BusinessLogicLayer
{
    public class ReservationBusinessLogic
    {
        private IRepository<Reservation> _reservationRepository;

        public ReservationBusinessLogic(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        /*
         * To book a ParkingSpace, the system attempts to create a Reservation relationship between a ParkingSpace and a Vehicle, with a property Current = true.
         */
    }
}
