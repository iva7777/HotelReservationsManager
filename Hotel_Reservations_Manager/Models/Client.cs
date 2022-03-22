using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Hotel_Reservations_Manager.Models
{
    public class Client
    {
        public Client()
        {
            this.IsAdult = true;
            this.ClientReservations = new List<ClientReservation>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        [Required]
        public bool IsAdult { get; set; }

        public int ReservationId { get; set; }
        public List<ClientReservation> ClientReservations { get; set; }

    }
}
