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
        public List<Producto> Productos { get; set; }

        public Ticket()
        {
            Productos = new List<Producto>();
        }
    }

    public class Producto
    {
        public string Tipo { get; set; }
        // Otros atributos del producto si es necesario
    }

}
