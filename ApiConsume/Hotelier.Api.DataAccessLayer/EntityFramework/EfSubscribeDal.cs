using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Concrete;
using Hotelier.Api.DataAccessLayer.Repositories;
using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {
        }
    }
}
