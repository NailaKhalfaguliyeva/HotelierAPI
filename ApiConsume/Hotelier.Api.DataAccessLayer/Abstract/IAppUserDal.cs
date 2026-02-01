using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.Abstract
{
   public interface IAppUserDal:IGenericDal<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        List<AppUser> UsersListWithWorkLocations();
        int AppUserCount();

    }
}
