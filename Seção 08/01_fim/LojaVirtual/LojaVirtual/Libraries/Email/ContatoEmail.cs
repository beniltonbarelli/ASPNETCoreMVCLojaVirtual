using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.live.com", 25);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("barelli@hotmail.com.br", "B@rel#135");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                "<b>Nome: </b> {0} <br/>" +
                "<b>Email: </b> {1} <br/>" +
                "<b>Mensagem: </b> {2}<br/>", contato.Nome, contato.Email, contato.Mensagem);

            var mensagem = new MailMessage();
            mensagem.From = new MailAddress("barelli@hotmail.com.br", "Loja Virtual C#");
            mensagem.To.Add("barelli@hotmail.com.br");
            mensagem.Subject = "Contato - LojaVirtual | E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
        }
        private static MailAddress MailAddress(string v)
        {
            throw new NotImplementedException();
        }
    }
}
