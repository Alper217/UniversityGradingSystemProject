using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace UniversityGradingSystem.Entity
{

    internal class Teachers : BaseFields
    {
        private Dictionary<string, string> TeacherAndBranch;
        public Teachers(string username, string password) : base(username, password)
        {
            if (username == "teacher1" && password == "password11")
            {
                TeacherAndBranch = new Dictionary<string, string>()
            {
                {"Doğuş", "Software"}

            };
               
            }
            else if (username == "teacher2" && password == "password12")
            {
                TeacherAndBranch = new Dictionary<string, string>()
            {
                {"Mehmet", "Designer"}

            };
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
           
        }
        public void TeacherSendMailFromTheirFamily()
        {
            // Gönderen e-posta adresi ve şifresi
            string senderEmail = "smtpmailsender11@gmail.com";
            string password = "zzgq xmpz tvie ibhh";

            // Alıcı e-posta adresi
            string receiverEmail = "palikarya23@gmail.com";

            // E-posta konusu ve içeriği
            string subject = "Test E-postası";
            string body = "Bu bir test e-postasıdır.";

            // SMTP sunucusu ve portu
            string smtpServer = "smtp.gmail.com";
            int port = 587; // Örnek olarak TLS kullanımı için

            // E-posta gönderme işlemi
            try
            {
                using (SmtpClient client = new SmtpClient(smtpServer, port))
                {
                    client.EnableSsl =true; // TLS kullanılacaksa true, yoksa false olarak ayarlayın
                    client.Credentials = new NetworkCredential(senderEmail, password);

                    MailMessage mail = new MailMessage(senderEmail, receiverEmail, subject, body);
                    client.Send(mail);
                    Console.WriteLine("E-posta başarıyla gönderildi.");
                    foreach (var item in TeacherAndBranch)
                    {
                        Console.WriteLine($"Message Sended Mr.{item.Key}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderilirken hata oluştu: " + ex.InnerException);
            }
        }

    }
}
