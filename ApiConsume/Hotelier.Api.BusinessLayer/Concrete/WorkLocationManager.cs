using Hotelier.Api.BusinessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Concrete
{
   public class WorkLocationManager:IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void TDelete(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation TGetByID(int id)
        {
            return _workLocationDal.GetByID(id);
        }

        public List<WorkLocation> TGetList()
        {
            return _workLocationDal.GetList();
        }

        public void TInsert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void TUpdate(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
