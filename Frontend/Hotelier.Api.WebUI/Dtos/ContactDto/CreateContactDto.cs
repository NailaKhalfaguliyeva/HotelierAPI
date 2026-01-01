using Hotelier.Api.EntityLayer.Concrete;

namespace Hotelier.Api.WebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }
        public MessageCategory MessageCategory { get; set; }
    }
}
