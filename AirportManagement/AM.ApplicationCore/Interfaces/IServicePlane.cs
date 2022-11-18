using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane:IServices<Plane>
    {
      /*  void Add(Plane P);
        void Remove(Plane P);
        IEnumerable<Plane> GetAll();*/
      IEnumerable<Passenger> GetPasenger(Plane p);
        IEnumerable<Flight> GetFlights(int n);
         bool IsAvailablePlane(Flight flight, int n);
        void DeletePlanes();
    }
}
