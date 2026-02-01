using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        int GetStaffCount();
        List<Staff> Last4Staff();
    }
}
