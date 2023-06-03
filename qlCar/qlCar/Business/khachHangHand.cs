using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace qlCar.Business
{
    public class khachHangHand
    {
        public List<DataAcess.KHACHHANG> getallKhachang()
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            List<DataAcess.KHACHHANG> khl = new List<KHACHHANG>();

            using (db)
            {
                var kh = from it in db.KHACHHANGs select it;
                foreach(var i in kh)
                {
                    khl.Add(i);
                }
            }
            return khl;
        }


        public void sendMail()
        {
            string fromEmail = "itchauduongphattien@gmail.com";
            string toEmail = "chauduongphattien2003@gmail.com";
            string subject = "Hello from C#";
            string body = "This is the email body.";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(fromEmail);
                    mail.To.Add(toEmail);
                    mail.Subject = subject;
                    mail.Body = body;

                    using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpClient.Credentials = new NetworkCredential("itchauduongphattien@gmail.com", "tien22012003");
                        smtpClient.EnableSsl = true;

                        smtpClient.Send(mail);
                        Console.WriteLine("Email sent successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }

        }
    }
}
