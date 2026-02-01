using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Concrete;
using Hotelier.Api.DataAccessLayer.Repositories;
using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var values = context.Staffs.Count();
            return values;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return values;
        }
    }
}
