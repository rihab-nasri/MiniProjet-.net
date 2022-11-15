using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public double prix { get; set; }
        public int siege { get; set; }
        public bool vip { get; set; }
       // [ForeignKey("MyFlight")]
        public int FlightFK {get; set; }
       // [ForeignKey("MyPassenger")]
        public string PassengerFK { get; set; }
         [ForeignKey("PassengerFK")]//SI ON APPELLE PassangerId pas besoin de faire annotation il comprend tt seule que c est une forgein Key 
        public virtual Passenger MyPassenger { get; set; }
        [ForeignKey("FlightFK")]
        public virtual Flight MyFlight { get; set; }


    }
}
