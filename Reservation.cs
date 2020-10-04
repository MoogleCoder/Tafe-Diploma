using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class Reservation
    {
        public Reservation()
        {
            ReservationTables = new List<ReservationTable>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public Person Person { get; set; }
        [Required]


        public bool IsMember
        {
            get
            {
                return Person.IsMember;
            }
        }
        [Required]
        public DateTime StartTime { get; set; }

        //want to see how many guest
        [Required]
        public int Guests { get; set; }
        [Required]
        public int StatusId { get; set; }
        [Required]
        public ReservationStatus Status { get; set; }
        public int SittingId { get; set; }
        [Required]
        public Sitting Sitting { get; set; }

        [Required]
        public decimal Duration { get; set; }

        public string AdditionalNote { get; set; }
        [Required]
        public List<ReservationTable> ReservationTables { get; set; }
        [Required]
        public ReservationSource ReservationSource { get; set; }
        [Required]
        public int ReservationSourceId { get; set; }

        public static implicit operator List<object>(Reservation v)
        {
            throw new NotImplementedException();
        }
    }
}

