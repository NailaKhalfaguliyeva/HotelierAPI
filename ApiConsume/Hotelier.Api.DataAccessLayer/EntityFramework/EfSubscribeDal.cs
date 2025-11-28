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
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {
        }
    }
}
