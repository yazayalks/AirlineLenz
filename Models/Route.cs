using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AirlineLenz.Models
{
    public class Route
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Airport StartingPoint { get; set; }
        public Airport EndingPoint { get; set; }
        public ICollection<Airport> WayPoints { get; set; }
    }
}
