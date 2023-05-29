using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TareaMajo.Entity;

namespace TareaMajo.Services
{
    public class Funcion
    {
        public void RealizarCompra()
        {
            try
            {
                Cliente cliente = new Cliente();

              
                int total = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Ingrese el precio del artículo " + i + ": ");
                    int precio = int.Parse(Console.ReadLine());
                    total += precio;
                }

                if (total > 10000)
                {
                    int mensualidad = total / 6;
                    Console.WriteLine("El total de su pago es "+total+" pesos");
                    Console.WriteLine("Sus pagos se dividirán en 6 meses sin intereses; Cada mensualidad será de: " + mensualidad+ " pesos");
                }
                else if (total > 8000)
                {
                    int mensualidad = total / 3;
                    Console.WriteLine("El total de su pago es " + total + " pesos");
                    Console.WriteLine("Sus pagos se dividirá en 3 meses sin intereses; Cada mensualidad será de: " + mensualidad + " pesos");
                }
                else if (total > 5000)
                {
                    double descuento = ((int)(total * 0.10));
                    Console.WriteLine("Total a pagar: " + total + " pesos");
                    Console.WriteLine("\nSe aplicó un descuento del 10%, su pago queda a: "+(total-descuento)+" pesos");
                }
                else
                {
                    Console.WriteLine("Total a pagar: " + total +" pesos");
                }
                Console.WriteLine("\nDatos ingresados:");
                Console.WriteLine("\nNombre: " + cliente.Nombre);
                Console.WriteLine("Apellido: " + cliente.Apellido);
                Console.WriteLine("Edad: " + cliente.Edad);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine("Correo: " + cliente.Correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
