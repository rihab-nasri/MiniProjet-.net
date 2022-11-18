using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane:Service<Plane>,IServicePlane
    {
       // private IUnitOfWork _unitOfWork;
        IGenericRepository<Plane> genericRepository;
        public ServicePlane(IUnitOfWork unitOfWork): base(unitOfWork)
        {
           // this._unitOfWork = unitOfWork;
        }

        public void DeletePlanes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetFlights(int n)
        {
            return GetAll().OrderByDescending(p => p.PlaneId).
                Take(n).SelectMany(p => p.Flights).
                OrderBy(f => f.Departure);
        }

        public IEnumerable<Passenger> GetPasenger(Plane p)
        {
            return GetById(p.PlaneId).Flights.
                SelectMany(f => f.TicketList).
                Select(t => t.MyPassenger);
        }

        public bool IsAvailablePlane(Flight flight, int n)
        {
            throw new NotImplementedException();
        }
        /* public void Add(Plane P)
            {
                _unitOfWork.Repository<Plane>().Add(P);
            }

           public IEnumerable<Plane> GetAll()
            {
              return  _unitOfWork.Repository<Plane>().GetAll();
            }

           public void Remove(Plane P)
            {
                _unitOfWork.Repository<Plane>().Delete(P);
            }*/
    }
}
