using System;
using System.Net.Mail;

namespace Mailsender
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length<5){
                Console.WriteLine("Ussage: server from to subj body");
                return;
            }
            try{
                SmtpClient client = new SmtpClient(args[0]);
    
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(args[1]);
                mailMessage.To.Add(args[2]);
                mailMessage.Body = args[4];
                mailMessage.Subject = args[3];
            
                client.Send(mailMessage);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
