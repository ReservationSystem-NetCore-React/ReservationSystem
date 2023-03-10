using Domain.DomainEntities;

namespace Persistence
{
    public interface IReservationRepository
    {
        Task<Reservation?> GetReservation(int id);
        Task<IEnumerable<Reservation>> GetReservations();
        Task DeleteReservation(int id);
        Task InsertReservation(Reservation reservation);
        Task UpdateReservation(Reservation reservation);
    }
}