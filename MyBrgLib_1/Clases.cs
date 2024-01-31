using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBrgLib_1
{
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                    PRODUCTO
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //cualquier elemento que un cliente puede pedir, se considerara un producto
    public class Producto 
    {
        //variables
        private string _nombre;
        private string _bebida="";
        private string _tamaño;
        private double _precio = 2.0;
        private string[] _ingredientes;
        private Boolean _pagado = false;
        private static int _numProducSigui = 1;
        private int _numProduc;

        //getters
        public int getNumProducSiguiente() { return _numProducSigui; }
        public int getNumProduc() { return _numProduc; }
        public string getNombre() {  return _nombre; }
        public string getBebida() { return _bebida; }
        public string getTamaño() { return _tamaño; }
        public double getPrecio() {  return _precio; }
        public Boolean getPagado() { return _pagado; }
        public string[] getIngredientes() {  return _ingredientes; }


        //setters
        public void setNombre(string nombre) {  _nombre = nombre; }
        public void setBebida(string bebida) { _bebida = bebida; }
        public void setTamaño(string tamaño) { _tamaño = tamaño; }
        public void setPrecio(double precio) {  _precio = precio; }
        public void setPagado(Boolean pagado) { _pagado = pagado; }
        public void setIngredientes(string[] ingredientes) { _ingredientes = ingredientes; }

        //constructor, se le pasa el nombre del producto por int y el tamaño del producto.
        public Producto(int nombreP, int tamañoP) 
        {
            this._numProduc = _numProducSigui;
            _numProducSigui++;
            this._nombre = nombreProducto(nombreP);
            this._tamaño = tamañoProducto(tamañoP);
        }

        //agencia tamaño dependiendo del valor numerico que le hallamos pasado en el constructor
        private string tamañoProducto(int tamañoP) 
        {
            string s = "";
            if (tamañoP == 1)
            {
                s = "M";
            }
            else if (tamañoP == 2)
            {
                s = "L";
            }
            else if (tamañoP == 3)
            {
                s = "XL";
            }
            else
            {
                s = "Valor de tamaño de producto no valido";
            }
            return s;
        }

        //agencia nobre de producto dependiendo del valor numerico que le hallamos pasado en el constructor
        private string nombreProducto(int nombreP) 
        {
            string s = "";
            if (nombreP == 1)
            {
                s = "Hamburguesa";
            }
            else if (nombreP == 2)
            {
                s = "Bebida";
            }
            else if (nombreP == 3)
            {
                s = "Patatas";
            }
            else 
            {
                s = "Valor de nombre de producto no valido";
            }
            return s;
        }

        //Muestra el producto, si tiene ingredientes, tambien los mostrara.
        public void mostrarProducto() 
        {
            string s = "";
            if (_ingredientes != null)
            {
                for (int i = 0; i < _ingredientes.Length; i++)
                {
                    s += _ingredientes[i] + " | ";
                }
                Console.WriteLine("Nombre: " + _nombre + "\nTamaño: " + _tamaño + "\nNumero de Producto:"+_numProduc+"\nIngredientes:( | " + s + " )" + "\nPrecio: " + _precio + " Euros");
            }
            else if (_bebida != "")
            {
                Console.WriteLine("Nombre: " + _bebida + "\nTamaño: " + _tamaño  + "\n"+"Numero de Producto:" + _numProduc + "\nPrecio: " + _precio + " Euros");
            }
            else 
            {
                Console.WriteLine("Nombre: " + _nombre + "\nTamaño: " + _tamaño + "\n" + "Numero de Producto:" + _numProduc + "\nPrecio: " + _precio + " Euros");
            }

        }

        

        //Paga el producto en especifico
        public void pagarProducto()
        {
            this._pagado = true;
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                    HAMBORGUESA
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //un tipo de producto, la cual dependiendo del tamaño, variara el precio y los ingredientes.
    public class Hamburguesa : Producto
    {
        //constructor, usamos el metodo añadir ingredientes, en funcion del tamaño. El precio tambien dependera del tamaño.
        public Hamburguesa(int nombreP, int tamañoP) : base(nombreP, tamañoP)
        {
            añadirIngredientes(this.getTamaño());
            this.setPrecio(this.getPrecio() + 3 + (tamañoP * 0.5));
        }

        //crea los ingredientes de la Hamburguesa, dependiendo del tamaño que tenga.
        private void añadirIngredientes(string tamaño)
        {
            string[] ingredientes = null;
            if (tamaño == "M")
            { 
                ingredientes = new string[] { "Carne de vacuno", "Lechuga", "Tomate", "Queso" };
                this.setIngredientes(ingredientes);
            }
            else if (tamaño == "L")
            {
                ingredientes = new string[] { "Carne de vacuno x 2", "Lechuga", "Tomate", "Queso x 2", "Cebolla Morada" };
                this.setIngredientes(ingredientes);
            }
            else if (tamaño == "XL")
            {
                ingredientes = new string[] { "Carne de vacuno x 3", "Lechuga", "Tomate", "Queso x 2", "Cebolla Morada", "Huevo" };
                this.setIngredientes(ingredientes);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                    PATATAS
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //tipo de producto, cullo precio variara del tamaño
    public class Patatas : Producto 
    {
        //constructor, usamos el setter del precio para modificarlo en funcion de su tamaño.
        public Patatas(int nombreP, int tamañoP) : base(nombreP, tamañoP)
        {
            this.setPrecio(this.getPrecio() + (tamañoP * 0.5));
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                    BEBIDA
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //tipo de producto, cullo nombre variara, pero el precio solo variara por el tamaño
    public class Bebida : Producto
    {
        //constructor, la bebida puede tener cualquier nombre, pero su precio solo variara del tamaño.
        public Bebida(int nombreP, int tamañoP,string bebida) : base(nombreP, tamañoP)
        {   
            this.setPrecio(this.getPrecio() + (tamañoP * 0.5));
            this.setBebida(this.getBebida()+bebida);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                    PEDIDO
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //agrupa todos los productos que se piden en un solo pedido, para que pagar sea mas sencillo
    public class Pedido
    {
        //variables
        private List<Producto> _pedido;
        private double _precio;
        private static int _numPedidoSigui = 1;
        private int _numPedido;

        //getters
        public List<Producto> getListaP() { return _pedido; }
        public double getPrecio() { return _precio; }
        public int getNumPedido() { return _numPedido; }

        //setters
        public void setListaP(List<Producto> pedido) { this._pedido = pedido; }
        public void setPrecio(double precio) { this._precio = precio; }

        //constructor
        public Pedido(List<Producto> pedido)
        {
            this._pedido = pedido;
            this._numPedido = _numPedidoSigui;
            _numPedidoSigui++;
            this._precio = calculoPrecio(pedido);
        }

        //obtiene el precio total de todos los productos del pedido
        private double calculoPrecio(List<Producto> pedido)
        {
            double precio = 0;
            foreach (var Producto in pedido)
            {
                precio += Producto.getPrecio();
            }
            return precio;
        }
        //mostrar todos los Productos del pedido;
        public void mostrarPedido()
        {

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("Pedido nº: "+_numPedido+ "\n");
            Console.WriteLine("=============================================================" + "\n");
            foreach (var Producto in _pedido) 
            { 
                Producto.mostrarProducto();
                Console.WriteLine("=============================================================" + "\n");
            }
           
            Console.WriteLine("Total a pagar: "+calculoPrecio(_pedido)+" Euros");
            Console.WriteLine("*****************************************************************************");
        }

        //paga los productos de un pedido en concreto
        public void pagarPedido() 
        {
            foreach (var item in _pedido)
            {
                item.pagarProducto();
            }
            Console.WriteLine("Pago confirmado, disfrute de su Hamburguesa =)");
        }

        //inserta un producto en el pedido
        public void insertarProducto(Producto p) 
        {
            this._pedido.Add(p);
            this._precio=calculoPrecio(_pedido);
            Console.WriteLine("Producto añadido correctamente al pedido");
        }

        //borra un producto del pedido, usando el nº de producto unico por cada producto.
        public void sacarproducto(int producto) 
        {
            foreach (var p in _pedido) 
            {
                if (p.getNumProduc() == producto) 
                {
                    _pedido.Remove(p);
                    this._precio = calculoPrecio(_pedido);
                }
            }
        }

        //Limpia el pedido completo, borrarndo todos los Productos.
        public void borrarPedido() 
        {
            _pedido.Clear();
            this._precio = 0;
            Console.WriteLine("Se ha borrado el pedido completo");
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //                                                                                  METODOS MAIN
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    //agrupa todos los metodos usados en el main que no estan desarrollados dentro del resto de clases.
    public class MetodosMain 
    {

        //funcion que muestra el tiquet del pedido y realiza el pago automatico. Utiliza metodos de la clase Producto 
        static public void MostrarYPagar(Pedido pedido)
        {
            if (pedido.getListaP().Any())
            {
                pedido.mostrarPedido();
                pedido.pagarPedido();
            }
            else
            {
                Console.WriteLine("Muchas gracias, vuelva pronto");
            }
        }

        //Crea una Hamburguesa y la añade a la lista, se elige el tamaño de la hamburguesa, y una vez elegido,
        //te permite cancelar la operacion o aceptarla.
        static public void CrearHamburguesa(Pedido pedido)
        {
            Hamburguesa h;
            int opcion = 1;
            Console.WriteLine("¿que tamaño desea de Hamburguesa?");
            Console.WriteLine("1. M Ingredientes: Carne de vacuno, Lechuga, Tomate, Queso");
            Console.WriteLine("2. L Ingredientes: Carne de vacuno x 2, Lechuga, Tomate, Queso x 2, Cebolla Morada");
            Console.WriteLine("3. XL Ingredientes: Carne de vacuno x 3, Lechuga, Tomate, Queso x 2, Cebolla Morada, Huevo");
            Console.WriteLine("0. Volver a menu principal");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Volviendo al menu principal.....");
            }
            else if (opcion == 1 || opcion == 2 || opcion == 3)
            {
                h = new Hamburguesa(1, opcion);
                h.mostrarProducto();
                Console.WriteLine("Ha elegido esta Hamburguesa, desea añadirla al pedido?(Y/N)");
                if (Console.ReadLine() == "Y")
                {
                    pedido.insertarProducto(h);
                    return;
                }
                Console.WriteLine("Cancelando pedido, volviendo al Menu principal...");



            }
            else
            {
                Console.WriteLine("Valor no valido, volviendo al menu principal.....");

            }

            return;

        }

        //Crea una Bebida y la añade al pedido,se elige el tamaño de la bebida, y una vez elegido,
        //te permite cancelar la operacion o aceptarla.
        static public void CrearBebida(Pedido pedido)
        {
            Bebida b;
            string s = "";
            Console.WriteLine("introduzca el nombre de la bebida: ");
            s = Console.ReadLine();
            int opcion = 1;
            Console.WriteLine("¿que tamaño desea de Bebida?");
            Console.WriteLine("1. M");
            Console.WriteLine("2. L");
            Console.WriteLine("3. XL");
            Console.WriteLine("0. Volver a menu principal");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Volviendo al menu principal.....");
            }
            else if (opcion == 1 || opcion == 2 || opcion == 3)
            {
                b = new Bebida(2, opcion, s);
                b.mostrarProducto();
                Console.WriteLine("Ha elegido esta Bebida, desea añadirla al pedido?(Y/N)");
                if (Console.ReadLine() == "Y")
                {
                    pedido.insertarProducto(b);
                    return;

                }
                Console.WriteLine("Cancelando pedido, volviendo al Menu principal...");
            }
            else
            {
                Console.WriteLine("Valor no valido, volviendo al menu principal.....");

            }
            return;
        }

        //Crear patatas y añadirlas al pedido,se elige el tamaño de las patatas, y una vez elegido,
        //te permite cancelar la operacion o aceptarla.
        static public void CrearPatatas(Pedido pedido)
        {
            Patatas p;
            int opcion = 1;
            Console.WriteLine("¿que tamaño desea de Patatas?");
            Console.WriteLine("1. M");
            Console.WriteLine("2. L");
            Console.WriteLine("3. XL");
            Console.WriteLine("0. Volver a menu principal");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 0)
            {
                Console.WriteLine("Volviendo al menu principal.....");
            }
            else if (opcion == 1 || opcion == 2 || opcion == 3)
            {
                p = new Patatas(3, opcion);
                p.mostrarProducto();
                Console.WriteLine("Ha elegido estas Patatas, desea añadirla al pedido?(Y/N)");
                if (Console.ReadLine() == "Y")
                {
                    pedido.insertarProducto(p);
                    return;

                }

                Console.WriteLine("Cancelando pedido, volviendo al Menu principal...");


            }
            else
            {
                Console.WriteLine("Valor no valido, volviendo al menu principal.....");

            }
            return;
        }

        //Muestra el pedido en un formato especifico, se puede usar en el punto 4 del menu principal,
        //pero he elegido usar el metodo del objeto Pedido.
        static public void MostrarPedido(Pedido pedido)
        {
            int pH = 0, pB = 0, pP = 0;
            double preH = 0, preB = 0, preP = 0;
            if (pedido.getListaP() != null)
            {
                foreach (Producto produc in pedido.getListaP())
                {
                    if (produc.getNombre() == "Hamburguesa")
                    {
                        pH++;
                        preH += produc.getPrecio();
                    }
                    else if (produc.getNombre() == "Bebida")
                    {
                        pB++;
                        preB += produc.getPrecio();
                    }
                    else
                    {
                        pP++;
                        preP += produc.getPrecio();
                    }
                }
                Console.WriteLine("========================================================================================");
                Console.WriteLine("PEDIDO:\n");
                Console.WriteLine(" ");
                Console.WriteLine("Hamburguesas " + pH + "................................." + preH + " euros.\n");
                Console.WriteLine(" ");
                Console.WriteLine("Bebidas " + pB + "................................." + preB + " euros.\n");
                Console.WriteLine(" ");
                Console.WriteLine("Patatas " + pP + "................................." + preP + " euros.");
                Console.WriteLine(" ");
                Console.WriteLine("========================================================================================");

            }
            else
            {
                Console.WriteLine("No ha elementos en el pedido");
            }
        }
    }
}
