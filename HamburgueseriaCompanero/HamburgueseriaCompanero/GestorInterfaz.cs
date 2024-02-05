using MyBrgLib_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HamburgueseriaCompanero
{
    public class GestorInterfaz
    {
        private List<Producto> datosTicket = new List<Producto>();

        private void addTicket(Producto producto)
        {
            datosTicket.Add(producto);
        }

        public void removeTicket(Producto producto)
        {
            datosTicket.Remove(producto);
        }

        public void createHamburguer(string name, double precio)
        {
            Hamburguesa hamburguesa = new Hamburguesa(1, 1);
            hamburguesa.setNombre(name);
            hamburguesa.setPrecio(precio);
            addTicket(hamburguesa);
        }

        public void createChips(string name,double precio)
        {
            Patatas patatas = new Patatas(2, 1);
            patatas.setNombre(name);
            patatas.setPrecio(precio) ;
            addTicket(patatas);
        }

        public void createDrinks(string name, double precio)
        {
            Bebida bebida = new Bebida(3, 1, name);
            bebida.setNombre(name);
            bebida.setPrecio(precio);
            addTicket(bebida);
        }

        public List<Producto> getTicket()
        {
            return datosTicket;
        }

        public void generateTicket()
        {
            // Crear una instancia de la clase Ticket
            Ticket ticket = new Ticket();

            // Agregar productos al ticket desde tu lista datosTicket
            foreach (Producto producto in datosTicket)
            {
                ticket.Productos.Add(producto);
            }

            // Serializar a JSON
            string jsonTicket = JsonSerializer.Serialize(ticket);

            // Guardar el JSON en un archivo (ajusta la ruta y nombre del archivo según tu necesidad)
            string filePath = "./ticket.json";
            File.WriteAllText(filePath, jsonTicket);

            // Puedes mostrar un mensaje al usuario o realizar otras acciones necesarias
            Console.WriteLine("Ticket guardado correctamente en " + filePath);
        }
    }
}
