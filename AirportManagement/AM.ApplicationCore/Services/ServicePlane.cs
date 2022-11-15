using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane:IServicePlane
    {
        IGenericRepository<Plane> genericRepository;
        public ServicePlane(IGenericRepository<Plane> genericRepository)
        {
            this.genericRepository = genericRepository;

        }
        public void Add(Plane P)
        {
            genericRepository.Add(P);
        }

        public IEnumerable<Plane> GetAll()
        {
            return genericRepository.GetAll();
        }

        public void Remove(Plane P)
        {
            genericRepository.Delete(P);
        }
    }
}
