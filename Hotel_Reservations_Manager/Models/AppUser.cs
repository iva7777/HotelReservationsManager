using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservations_Manager.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base()
        {
            IsActive = true;
            StartTime = DateTime.Now;
            this.Reservations = new List<Reservation>();
        }
        [Required]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public int Telephone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(10)]
        public string UserNewRole { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? FinishedTime { get; set; }
        public bool? IsActive { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
