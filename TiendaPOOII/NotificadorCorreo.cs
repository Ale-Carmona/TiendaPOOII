using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class NotificadorCorreo : Notificador
    {
        private string correoEmisor = " ";
        private string contrasena = "jariffa1224";
        private string smtpServidor = "smtp.gmail.com";
        private bool usarSSL = true;
        private string correoReceptor = "112898@alumnouninter.mx";

        public override void Enviar(string mensaje)
        {
            try
            {
                using (SmtpClient cliente = new SmtpClient(smtpServidor))
                {
                    cliente.Credentials = new NetworkCredential(correoEmisor, contrasena);
                    cliente.EnableSsl = usarSSL;

                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress(correoEmisor, "Tienda POOII - Notificaciones");
                    correo.To.Add(correoReceptor);
                    correo.Subject = "Notificación Tienda POOII";
                    correo.Body = mensaje;

                    cliente.Send(correo);

                    Console.WriteLine(" Correo enviado exitosamente a " + correoReceptor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al enviar correo: " + ex.Message);
            }
        }
    }
}

