using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prototype.Data
{
    public class Table
    {
        public Table()
        {
            ReservationTables = new List<ReservationTable>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Area Area { get; set; }
        [Required]
        public int AreaId { get; set; }
       
        public List<ReservationTable> ReservationTables { get; set; }
    }
}