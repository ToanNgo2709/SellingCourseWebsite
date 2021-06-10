using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.Utilities.Email
{
    public static class EmailFeature
    {
        const string Email = "toanngongo97@gmail.com";
        const string Password = "Toan.123";

        public static int SendEmail(string to, string subject, string body)
        {
            using (MailMessage mm = new MailMessage(Email, to))
            {
                mm.Subject = subject;
                mm.Body = body;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential networkCredential = new NetworkCredential(Email, Password);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = networkCredential;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    return 1;
                }
            }
        }
    }
}
