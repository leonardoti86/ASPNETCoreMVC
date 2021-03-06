using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Mail
{
    public class Constants
    {
        /*
         POP3, IMAP - ler mensagem de email
         SMTP - enviar e-mail
         */

        //Autenticação - Gmail
        public readonly static string Usuario = "leopanzer@gmail.com";
        public readonly static string Senha = "101Tagima";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 587; //465 SSL, 587 TLS
    }
}
