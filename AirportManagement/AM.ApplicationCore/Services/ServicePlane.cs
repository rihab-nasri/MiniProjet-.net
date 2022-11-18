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
        private IUnitOfWork _unitOfWork;
        IGenericRepository<Plane> genericRepository;
        public ServicePlane(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void Add(Plane P)
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
        }
    }
}
