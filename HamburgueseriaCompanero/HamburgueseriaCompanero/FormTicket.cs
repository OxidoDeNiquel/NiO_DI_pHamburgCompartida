using MyBrgLib_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaCompanero
{
    public partial class FormTicket : Form
    {
        private GestorInterfaz gestor;

        public FormTicket(GestorInterfaz gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
        }
        private void volverAtras()
        {
            gestor.setTicket(dataGridViewTicket);
            FormPagPrincipal form2 = new FormPagPrincipal(gestor);
            form2.Show();

            this.Visible = false;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            List<Producto> listaPedido = gestor.getTicket();

            AgregarDatosAlDataGridView(listaPedido);
        }

        private void AgregarDatosAlDataGridView(List<Producto> listaProductos)
        {
            dataGridViewTicket.Rows.Clear();

            foreach (Producto producto in listaProductos)
            {
                dataGridViewTicket.Rows.Add(producto.getNombre(), producto.getPrecio());
            }
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicket.SelectedRows.Count > 0)
            {
                int indiceSeleccionado = dataGridViewTicket.SelectedRows[0].Index;

                Producto productoSeleccionado = gestor.getTicket()[indiceSeleccionado];

                gestor.removeTicket(productoSeleccionado);

                // Actualizar el DataGridView
                AgregarDatosAlDataGridView(gestor.getTicket());
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en Borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox_atras_Click(object sender, EventArgs e)
        {
            volverAtras();
        }

        private void button_pagar_Click(object sender, EventArgs e)
        {
            gestor.generateTicket();
            FormFormaDePago form = new FormFormaDePago();
            form.Show();

            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestor.saveOrder();
            MessageBox.Show("El pedido ha sido guardado con éxito");

        }

        // Función para mostrar los datos en un DataGridView
        public void DisplayDataInDataGridView(TicketFormat ticket)
        {

            dataGridViewTicket.Rows.Clear();

            foreach (PedidoTicket pedido in ticket.Pedidos)
            {
                foreach (ProductoTicket producto in pedido.Pedido)
                {
                    dataGridViewTicket.Rows.Add(producto.Nombre, producto.Precio);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDataInDataGridView(gestor.LoadOrder());
        }
    }
}
