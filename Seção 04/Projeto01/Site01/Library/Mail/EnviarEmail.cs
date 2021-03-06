using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> Email: {1}<br /> Assunto: {2}<br /> Mensagem: {3}<br />", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);


            //Configurar o servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false; // pra não usar as credenciais locais
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //Mensagem de email
            MailMessage mensagem = new MailMessage();
            mensagem.To.Add("leonardoti86@gmail.com");
            mensagem.From = new MailAddress(Constants.Usuario);
            mensagem.Subject = "formulario de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulario de controle</h1>" + conteudo;

            smtp.Send(mensagem);                
        }
    }
}
