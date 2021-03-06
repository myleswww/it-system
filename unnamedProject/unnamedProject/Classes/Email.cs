using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace unnamedProject.Classes
{
    public class Email
    {
        private string smtpAddress = "smtp.gmail.com";
        private int portNumber = 587;
        private bool enableSSL = true;
        private string emailFromAddress = "uwuteam225@gmail.com"; //Sender Email Address  
        private string password = "sneakysnake"; //Sender Password  
        public string emailToAddress { get; set; } //Receiver Email Address  
        public string subject { get; set; }
        public string body { get; set; }

        //true = a ticket email
        //false = a account email

        public Email(string email, string psubject, string pbody)
        {
            emailToAddress = email;
            subject = psubject;
            body = pbody;

            SendEmail();
        }

        private void SendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}
