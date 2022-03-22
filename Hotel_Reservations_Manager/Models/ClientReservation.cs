using System;
namespace Hotel_Reservations_Manager.Models
{
    public class ClientReservation
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }
    }
}
