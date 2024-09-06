using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RO__Windows_Task_Scheduler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fromMail = "ameenalodhi9@gmail.com";
            string fromPassword = "ohck ewzf jxdy jdcn";

            // Calculate the previous date
            DateTime yesterday = DateTime.Now.AddDays(-1);
            string formattedDate = yesterday.ToString("yyyy-MM-dd"); // Format as needed, e.g., "yyyy-MM-dd" for "2024-09-02"

            // Create the email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = formattedDate;
            message.To.Add(new MailAddress("usmanlodhi0811@gmail.com"));
            message.Body = "<html><body> PFA </body></html>";
            message.IsBodyHtml = true;

            //string filePath = @"C:\Users\HP\source\repos\SMTP email\testfile.txt";

            // Check if the file exists
            /*         if (File.Exists(filePath))
                     {
                         // Create the attachment and add it to the email
                         Attachment attachment = new Attachment(filePath);
                         message.Attachments.Add(attachment);
                     }
                     else
                     {
                         Console.WriteLine("File not found.");
                     }*/

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
