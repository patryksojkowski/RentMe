using System.Net;
using System.Net.Mail;
using RentMe.Models;

namespace RentMe.Helpers
{
    public static class MailHelper
    {
        public static void SendConfirmationMail(Client client)
        {
            using (var smtpClient = new SmtpClient("SMTP.SERVER", 0)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("LOGIN", "PASSWORD")
            })
            {
                smtpClient.Send("FROM", client.Email, "Rental confirmation", "Rental is successful");
            }
        }
    }
}