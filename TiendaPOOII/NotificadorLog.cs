using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII
{
    internal class NotificadorLog: Notificador
    {
        private string rutaArchivo;
        public NotificadorLog()
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaArchivo = Path.Combine(escritorio, "log.txt");
        }

        public override void Enviar(string mensaje)
        {
            try
            {
                File.AppendAllText(rutaArchivo, $"🗒️ {mensaje}{Environment.NewLine}");
                Console.WriteLine("🗒️ Notificación guardada en log.txt en el Escritorio");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar log: {ex.Message}");
            }
        }
    }
}
