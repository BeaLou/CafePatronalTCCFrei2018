using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Nsf._2018.Modulo2.DB.Filosofia.Plugin
{
    public class Email
    {


        public string Para { get; set; }
        public string Assunto { get; set; }
        
        public string Mensagem { get; set; }

        MailMessage email = new MailMessage();

        public void Enviar()
        {
            Task.Factory.StartNew(() =>
            {
                // Se for usar seu email, habilite ele em: https://myaccount.google.com/lesssecureapps?pli=1
                string remetente = "parthenoninfoc@gmail.com";
                string senha = "integrador";

                if (Assunto == string.Empty)
                {
                    Assunto = "Nova Mensagem | Café Patronal ";
                }
               
                Mensagem = CriarMensagemComHtml(Mensagem);


                // Configura Remetente, Destinatário
                email.From = new MailAddress(remetente);
                email.To.Add(Para);

                // Configura Assunto, Corpo e se o Corpo está em Html
                email.Subject = Assunto;
                email.Body = Mensagem;
                email.IsBodyHtml = true;

                // Adiciona Imagem no Corpo do Email
                AdicionarImagem(email);

                
                // Configura os parâmetros do objeto SMTP
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;


                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente, senha);

                // Envia a mensagem
                smtp.Send(email);

            });
        }

        public string CriarMensagemComHtml(string Mensagem)
        {
            // Lê o html do arquivo email.html
            string html = System.IO.File.ReadAllText("Programacao/API/email.html");

            // Substitui as quebras de linhas pela tag <br>
            Mensagem = Mensagem.Replace("\n", "<br>");

            // Coloca a mensagem no template em html
            Mensagem = html.Replace("{MENSAGEM}", Mensagem);
            
            return Mensagem;
        }

        public void AdicionarImagem(MailMessage mail)
        {
            string attachmentPath = "Programacao/API/logopatronal.jpg";
            Attachment inline = new Attachment(attachmentPath);
            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            inline.ContentId = "icon";
            inline.ContentType.MediaType = "image/jpg";

            mail.Attachments.Add(inline);


        }

        public void AdicionarAnexo(string arquivo)
        {
            Attachment inline = new Attachment(arquivo);
            this.email.Attachments.Add(inline);
        }
    }
}
