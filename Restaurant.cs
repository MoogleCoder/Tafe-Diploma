using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Data
{
    public class Restaurant
    {
        public Restaurant()
        {
            Sittings = new List<Sitting>();
            Areas = new List<Area>();
        }

        [Required]
        public int Id { get; set; } = 1;

        [Required]
        public string Name { get; set; } = "Bean Scene";
        [Required]
        public List<Sitting> Sittings { get; set; }
        [Required]
        public List<Area> Areas { get; set; }
    }
}
