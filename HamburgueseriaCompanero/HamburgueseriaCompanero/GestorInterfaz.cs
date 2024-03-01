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
            TicketFormat ticket = new TicketFormat();

            // Iterar sobre los productos en datosTicket y agregarlos al ticket
            foreach (MyBrgLib_1.Producto producto in datosTicket)
            {
                // Crear una instancia de ProductoTicket para cada producto
                ProductoTicket productoTicket = new ProductoTicket(producto);

                // Obtener el último pedido en el ticket o crear uno nuevo si no hay pedidos
                PedidoTicket ultimoPedido = ticket.Pedidos.Count > 0 ? ticket.Pedidos[ticket.Pedidos.Count - 1] : null;

                // Si no hay pedidos o el último pedido está completo, agregar un nuevo pedido al ticket
                if (ultimoPedido == null || ultimoPedido.Pedido.Count >= 10)
                {
                    ultimoPedido = new PedidoTicket();
                    ticket.Pedidos.Add(ultimoPedido);
                }

                // Agregar el producto al pedido actual
                ultimoPedido.Pedido.Add(productoTicket);
            }

            // Serializar a JSON
            string jsonTicket = JsonSerializer.Serialize(ticket);

            // Guardar el JSON en un archivo
            string filePath = "./ticket.json";
            File.WriteAllText(filePath, jsonTicket);

            // Puedes mostrar un mensaje al usuario o realizar otras acciones necesarias
            Console.WriteLine("Ticket guardado correctamente en " + filePath);
        }


        public TicketFormat LoadOrder()
        {
            string filePath = "./ticket.json";

            // Verificar si el archivo existe antes de intentar cargarlo
            if (File.Exists(filePath))
            {
                // Leer el contenido del archivo JSON
                string jsonTicket = File.ReadAllText(filePath);

                // Deserializar el JSON a una instancia de TicketFormat
                TicketFormat loadedTicket = JsonSerializer.Deserialize<TicketFormat>(jsonTicket);

                // Puedes mostrar un mensaje al usuario o realizar otras acciones necesarias
                Console.WriteLine("Ticket cargado correctamente desde " + filePath);

                // Devolver la instancia deserializada
                return loadedTicket;
            }
            else
            {
                // Si el archivo no existe, puedes manejarlo de alguna manera (por ejemplo, mostrar un mensaje al usuario)
                Console.WriteLine("El archivo " + filePath + " no existe.");
                return null;
            }
        }

    }
}
