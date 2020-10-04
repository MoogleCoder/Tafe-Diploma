using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class Area
    {
        public Area()
        {
            Tables = new List<Table>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }//main
        [Required]
        public List<Table> Tables { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }
        [Required]
        public int RestaurantId { get; set; }//FK

    }
}