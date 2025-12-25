using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Concrete;
using Hotelier.Api.DataAccessLayer.Repositories;
using Hotelier.Api.EntityLayer.Concrete;

namespace Hotelier.Api.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {
        }
    }
}
