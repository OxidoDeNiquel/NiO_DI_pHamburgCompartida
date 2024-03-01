﻿using MyBrgLib_1;
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
            FormPagPrincipal form2 = new FormPagPrincipal(gestor);
            form2.Show();

            this.Visible = false;
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            // Crear una lista de objetos (pueden ser tus datos reales)
            List<Producto> listaPedido = gestor.getTicket();

            // Llamar al método para agregar datos al DataGridView
            AgregarDatosAlDataGridView(listaPedido);
        }

        private void AgregarDatosAlDataGridView(List<Producto> listaProductos)
        {
            // Limpiar el DataGridView antes de agregar nuevos datos
            dataGridViewTicket.Rows.Clear();

            // Iterar a través de la lista y agregar cada objeto como una nueva fila
            foreach (Producto producto in listaProductos)
            {
                // Agregar una nueva fila al DataGridView
                dataGridViewTicket.Rows.Add(producto.getNombre(), producto.getPrecio());
            }
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTicket.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceSeleccionado = dataGridViewTicket.SelectedRows[0].Index;

                // Obtener el producto correspondiente a la fila seleccionada
                Producto productoSeleccionado = gestor.getTicket()[indiceSeleccionado];

                // Eliminar el producto de la lista en el GestorInterfaz
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
            gestor.generateTicket();
            MessageBox.Show("El pedido ha sido guardado con éxito");

        }

        // Función para mostrar los datos en un DataGridView
        public void DisplayDataInDataGridView(TicketFormat ticket)
        {
            // Supongamos que tienes un DataGridView llamado dgvOrder en tu formulario

            // Limpiar cualquier dato existente en el DataGridView
            dataGridViewTicket.Rows.Clear();

            // Iterar sobre los pedidos y productos para agregarlos al DataGridView
            foreach (PedidoTicket pedido in ticket.Pedidos)
            {
                foreach (ProductoTicket producto in pedido.Pedido)
                {
                    // Añadir una nueva fila al DataGridView con los datos del producto
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
