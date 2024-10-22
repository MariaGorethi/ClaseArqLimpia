using ReservacionesRestFul.Bussines.Entities;
using ReservacionesRestFul.Data.DTO_s;

namespace ReservacionesRestFul.Bussines.Services
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        int Insert(ReservationDTO dto);
        List<Room> GetAvailableRooms();

    }
}
