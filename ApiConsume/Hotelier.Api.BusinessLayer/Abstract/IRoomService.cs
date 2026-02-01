using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Abstract
{
    public interface IRoomService : IGenericService<Room>
    {
        int TRoomCount();
    }
}
