using Hotelier.Api.EntityLayer.Concrete;


namespace Hotelier.Api.DataAccessLayer.Abstract
{
   public interface ISendMessageDal:IGenericDal<SendMessage>
    {
        public int GetSendMessageCount();
    }
}
