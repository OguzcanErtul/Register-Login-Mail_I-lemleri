
using MailKit.Security;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
namespace HS14Register.MailServices
{
    public class MailService : IMailService
    {
        public async Task SendMailAsync(string email, string subject, string message)
        {
           
            try
            {
                //yoxrnfqwyttippdm


                var newmail = new MimeMessage();
				newmail.From.Add(MailboxAddress.Parse("ozicanertul@gmail.com"));
                newmail.To.Add(MailboxAddress.Parse(email));
                newmail.Subject = subject;
                var builder = new BodyBuilder();
                builder.HtmlBody = message;
                newmail.Body = builder.ToMessageBody();
                var smtp = new SmtpClient();
                await smtp.ConnectAsync("smtp.gmail.com",587,SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync("ozicanertul@gmail.com", "yoxrnfqwyttippdm");
                await smtp.SendAsync(newmail);
                await smtp.DisconnectAsync(true);


            }
			catch (Exception ex)
			{

                throw new InvalidOperationException($"E-posta gönderilirker hata oluştu: {ex.Message}");
			}

        }
    }
}
