using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.Abstract
{
   public interface IBookingDal:IGenericDal<Booking>
    {
        void BookingStatusChangeApproved(Booking booking);
        void BookingStatusChangeApproved2(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
        void BookingStatusChangeApproved3(int id);
        void BookingStatusChangeCancel(int id);
        void BookingStatusChangeWait(int id);
    }
}
