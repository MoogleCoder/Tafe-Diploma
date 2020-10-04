using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class Sitting
    {
        public Sitting()//Sitting for BK, Lunch, Dinner
        {
            Reservations = new List<Reservation>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
     
        [Required]
        public int Capacity { get; set; }
        [Required]

        public int RestaurantId { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }//1 to many

        public List<Reservation> Reservations { get; set; }//FK
        [Required]
        public int SittingTypeId { get; set; }
        [Required]
        public SittingType SittingType { get; set; }
    }
}