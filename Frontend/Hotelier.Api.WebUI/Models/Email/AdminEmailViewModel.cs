namespace Hotelier.Api.WebUI.Models.Email
{
    public class AdminEmailViewModel
    {
        public string Name { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
