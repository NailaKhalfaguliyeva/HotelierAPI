using Hotelier.Api.WebUI.Models.Email;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace Hotelier.Api.WebUI.Controllers
{
    public class AdminEmailController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminEmailViewModel model)
        {
            model.SenderEmail = "yourmail@gmail.com";
            model.Name = "Naila";

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "yourmail@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverEmail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("yourmail@gmail.com.com", "Your Key");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }

    }
}
