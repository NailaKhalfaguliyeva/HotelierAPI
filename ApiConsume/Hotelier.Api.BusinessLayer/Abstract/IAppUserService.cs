using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Abstract
{
   public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> TUserListWithWorkLocation();
        List<AppUser> TUsersListWithWorkLocations();
        int TAppUserCount();
    }
}
