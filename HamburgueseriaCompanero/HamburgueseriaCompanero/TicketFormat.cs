using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgueseriaCompanero
{
    using MyBrgLib_1;
    using System.Collections.Generic;

    public class Ticket
    {
        public List<PedidoTicket> Pedidos { get; set; }

        public Ticket()
        {
            Pedidos = new List<PedidoTicket>();
        }
    }

    public class PedidoTicket
    {
        public List<ProductoTicket> Pedido {  get; set; }

        public PedidoTicket()
        {
            Pedido = new List<ProductoTicket>();
        }
    }

    public class ProductoTicket
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }  

        public ProductoTicket(Producto producto)
        {
            this.Nombre = producto.getNombre();
            this.Precio = producto.getPrecio();
        }
    }

}
