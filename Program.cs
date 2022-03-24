using System.Net;
using System.Net.Mail;

Console.WriteLine("Please enter subject of an email:");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string subject = Console.ReadLine().Trim();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

Console.WriteLine("\nWrite Message You want to send:");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string body = Console.ReadLine().Trim();

Console.WriteLine("\nPlease enter email you want to send message:");
string to = Console.ReadLine().Trim();

Console.WriteLine("\nEnter Your Email");
string from = Console.ReadLine().Trim();

Console.WriteLine("\nEnter Your Password");
string password = Console.ReadLine().Trim();

SmtpClient smtpClient = new();
smtpClient.Host = "smtp.gmail.com";
smtpClient.Port = 587;
smtpClient.Credentials = new NetworkCredential(from, password);
smtpClient.EnableSsl = true;

MailMessage message = new();
message.To.Add(to);
message.Subject = subject;
message.From = new MailAddress(from);
message.Body = body;
Console.WriteLine("\nSending.... Please wait");
smtpClient.Send(message);
Console.WriteLine("\nCongratulations! Your email Successfully sent");