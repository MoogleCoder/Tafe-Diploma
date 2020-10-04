using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    
        [Required]
        public string Email { get; set; }
        [Required]
        public string phoneNumber { get; set; }

        public virtual bool IsMember
        {
            get
            {
                return false;
            }
        }

        public virtual bool IsEmployee
        {
            get
            {
                return false;
            }
        }


        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
