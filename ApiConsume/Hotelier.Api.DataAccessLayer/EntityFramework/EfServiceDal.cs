using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Concrete;
using Hotelier.Api.DataAccessLayer.Repositories;
using Hotelier.Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.Api.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
