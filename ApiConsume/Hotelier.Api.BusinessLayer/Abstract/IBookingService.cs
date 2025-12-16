using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Abstract
{
   public interface IBookingService: IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        void TBookingStatusChangeApproved2(int id);
    }
}
