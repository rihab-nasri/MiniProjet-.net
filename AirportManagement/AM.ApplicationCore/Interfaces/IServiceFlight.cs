using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight:IServices<Flight>
    {
         IList<DateTime> GetFlightDates(string destination);
         void GetFlights(string filtertype, string filtervalue);
         IList<DateTime> GetFlightDates2(string destination);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IList<Flight> OrderedDurationFlights();
      //  IList<Traveller> SeniorTravellers(Flight flight);
        void DestinationGroupedFlights();
       /* void Add(Flight flight);
        void Remove(Flight flight);
        IEnumerable<Flight> GetAll();*/

    }
}
