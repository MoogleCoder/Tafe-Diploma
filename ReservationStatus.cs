using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class ReservationStatus
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Reservation> Reservations { get; set; }

        public ReservationStatus()
        {
            Reservations = new List<Reservation>();
        }
    }
}