using Hotelier.Api.EntityLayer.Concrete;

namespace Hotelier.Api.BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        public int TGetContactCount();
    }
}
