using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz.Models
{
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Passenger Passenger { get; set; }
        public Employee Employee { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public int CheckoutNumber { get; set; }
        //public ICollection<Departure> Departures { get; set; }
        public Departure Departure { get; set; }
        public ServiceType ServiceClass { get; set; }
        public string Place { get; set; }


    }
}
