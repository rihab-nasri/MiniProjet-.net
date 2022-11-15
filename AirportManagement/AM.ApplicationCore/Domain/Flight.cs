using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane MyPlane { get; set; }
        public string Airline { get; set; }
        //[ForeignKey("MyPlane")]
        public int PlaneId { get; set; }
       // public ICollection<Passenger> PassengerList { get; set; }
        public virtual ICollection<Ticket> TicketList { get; set; }

        public override string ToString()
        {
            return "Departure: "+Departure+"Destination: "+Destination+"Effective Arrival: "+EffectiveArrival;
        }
    }
}
