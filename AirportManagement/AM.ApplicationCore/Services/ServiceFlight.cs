using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight: Service<Flight>,IServiceFlight
    {
        public Action<Plane> FlightDetailsDel;
        public Func<string, double> DurationAverageDel;
        public List<Flight> Flights { get; set; }=new List<Flight>();
        public IList<DateTime> GetFlightDates(string destination)
        {  
            List<DateTime> dates = new List<DateTime>();
            for(int i = 0; i < Flights.Count; i++)
            {
                if(Flights[i].Destination.Equals(destination))
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
        }

        public IList<DateTime> GetFlightDates1(string destination)
        {

            IList<DateTime> dates = new List<DateTime>();

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)

                {
                    dates.Add(flight.FlightDate);
                }

            }
            return dates;
        }
        public IList<DateTime> GetFlightDates2(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return query.ToList();
        }
        public void GetFlights (string filtertype,string filtervalue)
        {
            switch (filtertype)
            {
                case "Destination":
                    foreach(Flight f in Flights)
                    {
                        if (f.Destination == filtervalue)
                        {
                            System.Console.WriteLine(f);
                        }
                    }
                    break;
                case "Date":
                    foreach(Flight f in Flights)
                    {
                        if (f.FlightDate.Equals(DateTime.Parse(filtervalue)))
                        { 
                            System.Console.WriteLine(f); 
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach(Flight f in Flights)
                    {
                        if(f.EstimatedDuration.Equals(int.Parse(filtervalue)))
                        {
                            System.Console.WriteLine(f);
                        }
                    }
                    break;
                    
            }
        }

        public void ShowFlightDetails(Plane plane)
        {
            var req=from f in Flights
                    where f.MyPlane == plane
                    select f;
            foreach(var f in req)
            {
                Console.WriteLine(f.FlightDate +" "+ f.Destination);
            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var req= from f in Flights
                     where (f.FlightDate - startDate).TotalDays<7 && (f.FlightDate - startDate).TotalDays > 0
                     select f;
            return req.Count();
           
        }
       public double DurationAverage(string destination)
        {
            var req = from f in Flights
                      where f.Destination==destination
                      select f.EstimatedDuration;
            return req.Average();
        }
        public IList<Flight> OrderedDurationFlights()
        {
            var req = from f in Flights
                      orderby f.EstimatedDuration descending
                      select f;
            return req.ToList();

        }
       /* public IList<Traveller> SeniorTravellers(Flight flight)
        {
            /* var req = from p in flight.PassengersList.OfType<Traveller>()
                       orderby p.BirthDate 
                       select p;
             return req.Take(3).ToList();
            return (flight.PassengerList.OfType<Traveller>()
                .OrderBy(p => p.BirthDate)
                .Take(3).ToList());
        }*/
        public void DestinationGroupedFlights()
        {
            /*  var req = from f in Flights
                        group f by f.Destination;*/
            var req = Flights.GroupBy(f => f.Destination);
            foreach (var g in req)
            {
                Console.WriteLine("Destination " + g.Key);
                foreach (var f in g)
                {
                    Console.WriteLine("Decollage : " + f.FlightDate);
                }

            }


        }
        IGenericRepository<Flight> genericRepository;
        private IUnitOfWork _unitOfWork;

        public ServiceFlight(IUnitOfWork unitOfWork): base(unitOfWork)
        {

            this._unitOfWork = unitOfWork;
            /*
            FlightDetailsDel = ShowFlifhtDetails;
            DurationAverageDel = DurationAverage;*/
            FlightDetailsDel = p =>
            {
                var req = from flight in Flights
                          where flight.MyPlane == p
                          select flight;
                foreach (var flight in req)
                {
                    Console.WriteLine(flight.FlightDate + "" + flight.Destination);
                }

            };
            DurationAverageDel = d =>
            {
                var req = from f in Flights
                          where (f.Destination == d)
                          select f.EstimatedDuration;
                return req.Average();
            };

        }
       /* public void Add(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Add(flight);
        }

        public void Remove(Flight flight)
        {
            _unitOfWork.Repository<Flight>().Delete(flight);
        }

        public IEnumerable<Flight> GetAll()
        {
            return  _unitOfWork.Repository<Flight>().GetAll();
        }*/


       


    }



}
