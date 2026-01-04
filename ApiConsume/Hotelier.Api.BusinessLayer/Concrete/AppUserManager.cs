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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public void TInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
            return _appUserDal.UsersListWithWorkLocations();
        }
    }
}
