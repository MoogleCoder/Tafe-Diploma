using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class SittingType//breakfast, lunch, dinner or special
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public List<Sitting> Sittings { get; set; }

        public SittingType()
        {
            Sittings = new List<Sitting>();
        }
    }
}