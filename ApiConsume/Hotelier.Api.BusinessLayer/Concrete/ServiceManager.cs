using Hotelier.Api.BusinessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.Api.BusinessLayer.Concrete
{
    public class ServiceManager : IServicesService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
