using Hotelier.Api.EntityLayer.Concrete;

namespace Hotelier.Api.BusinessLayer.Abstract
{
   public interface ISendMessageService:IGenericService<SendMessage>
    {
        public int TGetSendMessageCount();
    }
}
