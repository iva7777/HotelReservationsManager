using System;
using System.ComponentModel.DataAnnotations;
using Hotel_Reservations_Manager.Models.Enumeration;
namespace Hotel_Reservations_Manager.Models
{
    public class Room
    {
        public Room()
        {

        }

        public Room(string number)
        {
            this.Capacity = 1;
            this.Type = 0;
            this.IsFree = true;
            this.AdultPrice = 50;
            this.ChildPrice = 25;
            this.Number = number;
        }

        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomType Type { get; set; }
        public bool IsFree { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }

        [Required]
        [MinLength(3), MaxLength(3)]
        public string Number { get; set; }
    }
}
