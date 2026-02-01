using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staff();
    }
}
