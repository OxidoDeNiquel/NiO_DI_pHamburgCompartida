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

        //Funcion para meter los datos recien importados en la lista del ticket para que permanezca durante la ejecución.
        public void setTicket(DataGridView dataGridView)
        {
            List<Producto> ticket = new List<Producto>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow && row.Cells.Count >= 2)
                {
                    string nombre = row.Cells[0].Value?.ToString();
                    double precio = 0;

                    if (double.TryParse(row.Cells[1].Value?.ToString(), out precio))
                    {
                        Producto producto = new Producto(1, 1);
                        producto.setNombre(nombre);
                        producto.setPrecio(precio);
                        ticket.Add(producto);
                    }
                }
            }

            this.datosTicket = ticket;
        }


        public void saveOrder()
        {
            TicketFormat ticket = new TicketFormat();

            foreach (MyBrgLib_1.Producto producto in datosTicket)
            {
                ProductoTicket productoTicket = new ProductoTicket(producto);

                PedidoTicket ultimoPedido = ticket.Pedidos.Count > 0 ? ticket.Pedidos[ticket.Pedidos.Count - 1] : null;

                if (ultimoPedido == null || ultimoPedido.Pedido.Count >= 10)
                {
                    ultimoPedido = new PedidoTicket();
                    ticket.Pedidos.Add(ultimoPedido);
                }

                ultimoPedido.Pedido.Add(productoTicket);
            }

            string jsonTicket = JsonSerializer.Serialize(ticket);

            string filePath = "./order.json";
            File.WriteAllText(filePath, jsonTicket);

            Console.WriteLine("Ticket guardado correctamente en " + filePath);
        }


        public TicketFormat LoadOrder()
        {
            string filePath = "./order.json";

            if (File.Exists(filePath))
            {
                string jsonTicket = File.ReadAllText(filePath);

                TicketFormat loadedTicket = JsonSerializer.Deserialize<TicketFormat>(jsonTicket);

                Console.WriteLine("Ticket cargado correctamente desde " + filePath);

                return loadedTicket;
            }
            else
            {
                Console.WriteLine("El archivo " + filePath + " no existe.");
                return null;
            }
        }

        public void generateTicket()
        {
            TicketFormat ticket = new TicketFormat();

            foreach (MyBrgLib_1.Producto producto in datosTicket)
            {
                ProductoTicket productoTicket = new ProductoTicket(producto);

                PedidoTicket ultimoPedido = ticket.Pedidos.Count > 0 ? ticket.Pedidos[ticket.Pedidos.Count - 1] : null;

                if (ultimoPedido == null || ultimoPedido.Pedido.Count >= 10)
                {
                    ultimoPedido = new PedidoTicket();
                    ticket.Pedidos.Add(ultimoPedido);
                }

                ultimoPedido.Pedido.Add(productoTicket);
            }

            string ticketText = GenerateTicketText(ticket);
            // Dirección de guardado --> ".\bin\Debug\net6.0-windows\ticket.txt"
            string filePath = "./ticket.txt";
            File.WriteAllText(filePath, ticketText);

            Console.WriteLine("Ticket guardado correctamente en " + filePath);
        }

        // Función para generar la representación gráfica del ticket en formato de texto
        private string GenerateTicketText(TicketFormat ticket)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("------------------------------");
            sb.AppendLine("        TICKET DE COMPRA       ");
            sb.AppendLine("------------------------------");

            foreach (PedidoTicket pedido in ticket.Pedidos)
            {
                sb.AppendLine("Pedido:");

                foreach (ProductoTicket productoTicket in pedido.Pedido)
                {
                    sb.AppendLine($"  - {productoTicket.Nombre} - {productoTicket.Precio}");
                }

                sb.AppendLine(); 
            }

            double total = ticket.Pedidos.Sum(pedido => pedido.Pedido.Sum(producto => producto.Precio));

            sb.AppendLine($"TOTAL: {total:C}");

            sb.AppendLine("------------------------------");

            return sb.ToString();
        }


    }
}
