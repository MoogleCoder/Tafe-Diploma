using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class ReservationTable//info about reservation and table
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int TableId { get; set; }
        [Required]
        public Table Table { get; set; }
        [Required]
        public int ReservationId { get; set; }
        [Required]
        public Reservation Reservation { get; set; }
    }
}
