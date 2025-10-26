using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class NotificadorConsola: Notificador
    {
        public override void Enviar(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Notificación en consola: " + mensaje);
            Console.ResetColor();
        }
    }
}
