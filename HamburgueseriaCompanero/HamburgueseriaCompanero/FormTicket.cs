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
        public FormTicket()
        {

            InitializeComponent();
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            // Crear una lista de objetos (pueden ser tus datos reales)
            List<Hamburguesa> listaHamburguesas = new List<Hamburguesa>
            {
                new Hamburguesa(1, 1),
                new Hamburguesa(1, 2),
                new Hamburguesa(1, 3)
            };

            // Llamar al método para agregar datos al DataGridView
            AgregarDatosAlDataGridView(listaHamburguesas);
        }

        private void AgregarDatosAlDataGridView(List<Hamburguesa> listaHamburguesas)
        {
            // Limpiar el DataGridView antes de agregar nuevos datos
            dataGridViewTicket.Rows.Clear();

            // Iterar a través de la lista y agregar cada objeto como una nueva fila
            foreach (Hamburguesa hamburguesa in listaHamburguesas)
            {
                // Agregar una nueva fila al DataGridView
                dataGridViewTicket.Rows.Add(hamburguesa.getNombre(), hamburguesa.getPrecio());
            }
        }
    }
}
