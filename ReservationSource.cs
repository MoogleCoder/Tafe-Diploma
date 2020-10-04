using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class ReservationSource
    {//phone, email, in person, online or mobile
        [Required]
        public string reservationSource { get; set; }
        [Required]
        public List<Reservation> Reservations { get; set; }

        public ReservationSource()
        {
            Reservations = new List<Reservation>();
        }

    }
    }
