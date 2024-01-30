using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBrgLib_1;

namespace HamburgueseriaCompanero
{
    internal class GestorInterfaz
    {
        private List<Producto> datosTicket = new List<Producto>();

        public void addTicket(Producto producto)
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

        public void createChips(string name, int size, double precio)
        {
            Patatas patatas = new Patatas(2, size);
            patatas.setNombre(name);
            patatas.setPrecio(precio) ;
            addTicket(patatas);
        }

        public void createDrinks(string name, int size, double precio)
        {
            Bebida bebida = new Bebida(3, size, name);
            bebida.setNombre(name);
            bebida.setPrecio(precio);
            addTicket(bebida);
        }

        public List<Producto> getTicket()
        {
            return datosTicket;
        }
    }
}
