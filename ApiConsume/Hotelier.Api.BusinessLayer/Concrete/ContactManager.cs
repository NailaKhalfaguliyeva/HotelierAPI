using Hotelier.Api.BusinessLayer.Abstract;
using Hotelier.Api.DataAccessLayer.Abstract;
using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.BusinessLayer.Concrete
{
   public class ContactManager:IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList();
        }

        public void TInsert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
