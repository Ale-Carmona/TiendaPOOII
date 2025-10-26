using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;

namespace TiendaPOOII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acc = new Acciones();

            Notificador correo = new NotificadorCorreo(); // Simulado
            Notificador consola = new NotificadorConsola();
            Notificador log = new NotificadorLog();

            while (true)
            {

                switch (Menu())
                {
                    case 1:
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        double precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el stock del producto: ");
                        int stock = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la categoría del producto: ");
                        string categoria = Console.ReadLine();
                        Console.Write("Ingrese la garantía (meses) del producto: ");
                        int garantia = Convert.ToInt32(Console.ReadLine());

                        ProductoElectonico nuevoProducto = new ProductoElectonico
                        {
                            Nombre = nombre,
                            Precio = precio,
                            Stock = stock,
                            Categoria = categoria,
                            Garantia = garantia
                        };

                        acc.AgregarProducto(nuevoProducto);
                        Console.WriteLine("Producto añadido exitosamente. Presiona ENTER para continuar...");
                        Console.ReadLine();
                        break;


                    case 2:
                        List<ProductoElectonico> productos = acc.MostrarProducto();
                        Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
                        foreach (var p in productos)
                        {
                            Console.WriteLine($"Nombre: {p.Nombre}, Precio: {p.Precio}, Stock: {p.Stock}, Categoría: {p.Categoria}, Garantía: {p.Garantia} meses");
                        }
                        Console.WriteLine("Presiona ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Write("Ingrese el mensaje para enviar por correo: ");
                        string msgCorreo = Console.ReadLine();
                        correo.Enviar(msgCorreo);
                        Console.WriteLine("Presiona ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Write("Ingrese el mensaje para mostrar en consola: ");
                        string msgConsola = Console.ReadLine();
                        consola.Enviar(msgConsola);
                        Console.WriteLine("Presiona ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 5:

                        Console.Write("Ingrese el mensaje para guardar en log: ");
                        string msgLog = Console.ReadLine();

                        // Obtener todos los productos del sistema
                        string productosRegistrados = acc.ObtenerTodosLosProductos();

                        // Concatenar el mensaje con la lista de productos
                        string detallesLog = $"{msgLog}\n{productosRegistrados}";

                        log.Enviar(detallesLog);

                        Console.WriteLine("✅ Todos los productos fueron guardados en el log. Presiona ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    #region
                    //Console.Write("Ingrese el mensaje para guardar en log: ");
                    //string msgLog = Console.ReadLine();
                    //log.Enviar(msgLog);

                    //if (acc.UltimoProducto != null)
                    //{
                    //    // Se concatena el mensaje con la información del último producto agregado
                    //    string detalles = $"{msgLog} | Producto: Nombre: {acc.UltimoProducto.Nombre}, Precio: {acc.UltimoProducto.Precio}, Stock: {acc.UltimoProducto.Stock}, Categoría: {acc.UltimoProducto.Categoria}, Garantía: {acc.UltimoProducto.Garantia} meses";
                    //    log.Enviar(detalles);
                    //}
                    //else
                    //{
                    //    log.Enviar(msgLog + " | No hay productos registrados aún.");
                    //}

                    //Console.WriteLine("Mensaje con información del último producto guardado en log. Presiona ENTER para continuar...");
                    //Console.ReadLine();
                    //break;

                    //Console.Write("Ingrese el mensaje para guardar en log: ");
                    //string msgLog = Console.ReadLine();

                    //if (acc.UltimoProducto != null)
                    //{
                    //    // Se incluye automáticamente la información del último producto
                    //    string detalles = $"{msgLog} | Producto agregado recientemente: " +
                    //                      $"Nombre: {acc.UltimoProducto.Nombre}, " +
                    //                      $"Precio: {acc.UltimoProducto.Precio}, " +
                    //                      $"Stock: {acc.UltimoProducto.Stock}, " +
                    //                      $"Categoría: {acc.UltimoProducto.Categoria}, " +
                    //                      $"Garantía: {acc.UltimoProducto.Garantia}";

                    //    log.Enviar(detalles);
                    //}
                    //else
                    //{
                    //    log.Enviar(msgLog + " | No hay productos registrados aún.");
                    //}

                    //Console.WriteLine("✅ Mensaje guardado en log con información del producto (si existe). Presiona ENTER para continuar...");
                    //Console.ReadLine();
                    //break;
                    #endregion

                    default:
                        break;
                }
            }
        }
        static int Menu()
        {

            Console.Clear();
            Console.WriteLine("--- TIENDA POO II ---");
            Console.WriteLine("1) Añadir producto electrónico");
            Console.WriteLine("2) Mostrar productos");
            Console.WriteLine("3) Enviar notificación por correo");
            Console.WriteLine("4) Mostrar notificación en consola");
            Console.WriteLine("5) Guardar notificación en log");
            Console.Write("Opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}