using System;
using System.Collections.Generic;

namespace Hotel_Reservations_Manager.Models
{
    public class Reservation
    {
        public Reservation()
        {
            this.StartDate = DateTime.UtcNow;
            this.Breakfast = true;
            this.AllInclusive = true;
            this.Price = CalculatePrice();
            this.ClientReservations = new List<ClientReservation>();
        }

        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public List<ClientReservation> ClientReservations { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public bool Breakfast { get; set; }
        public bool AllInclusive { get; set; }
        public double Price { get; set; }

        private double CalculatePrice()
        {
            return 0.0;
        }

    }
}
