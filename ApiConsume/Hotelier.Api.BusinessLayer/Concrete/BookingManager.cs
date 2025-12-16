

using Hotelier.Api.BusinessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.EntityLayer.Concrete;

namespace Hotelier.Api.BusinessLayer.Concrete
{
   public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;
        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            _bookingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bookingDal.BookingStatusChangeApproved2(id);
        }

        public void TDelete(Booking t)
        {
            _bookingDal.Delete(t);
        }
        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }
        public List<Booking> TGetList()
        {
            return _bookingDal.GetList();
        }
        public void TInsert(Booking t)
        {
            _bookingDal.Insert(t);
        }
        public void TUpdate(Booking t)
        {
            _bookingDal.Update(t);
        }
    }
}
