using Domain.DomainEntities;

namespace Persistence
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ISQLDataAccess _db;

        public ReservationRepository(ISQLDataAccess db)
        {
            _db = db;
        }

        public async Task<Reservation?> GetReservation(int id)
        {
            var result = await _db.LoadData<Reservation, dynamic>("dbo.spReservation_Get", new { Id = id });
            return result.FirstOrDefault();
        }

        public async Task<IEnumerable<Reservation>> GetReservations()
        {
            var result = await _db.LoadData<Reservation, dynamic>("dbo.spReservation_GetAll", new { });
            return result;
        }

        public  Task InsertReservation(Reservation reservation) => 
             _db.SaveData("dbo.spReservation_Insert", new { 
                      reservation.Id,
                      reservation.Starting,
                      reservation.Ending,
                      reservation.Title,
                      reservation.Total,
                      reservation.PrimaryColor,
                      reservation.SecondaryColor,
                      reservation.CustomerId });

        public  Task UpdateReservation(Reservation reservation) =>
               _db.SaveData("dbo.spReservation_Update", reservation);

        public  Task DeleteReservation(int id) =>
              _db.SaveData("dbo.spReservation_Delete", new { Id = id });
    }
}
