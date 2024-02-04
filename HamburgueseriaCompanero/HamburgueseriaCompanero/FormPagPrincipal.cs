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
    public partial class FormPagPrincipal : Form
    {
        GestorInterfaz gestor;
        public FormPagPrincipal(GestorInterfaz gestor)
        {
            this.gestor = gestor;
            InitializeComponent();

        }

        private void botonCesta_Click(object sender, EventArgs e)
        {
            FormTicket FormTicket = new FormTicket(gestor);
            FormTicket.Show();

            this.Visible = false;
        }

        /*private void button_bebida_Click(object sender, EventArgs e)
        {
            FormBebida formBebida = new FormBebida();
            formBebida.Show();

            this.Visible = false;
        }*/

        private void button_burguer_Click(object sender, EventArgs e)
        {
            FormHamburguesa formHamburguesa = new FormHamburguesa(gestor);
            formHamburguesa.Show();

            this.Visible = false;
        }

        private void button_bebida_Click(object sender, EventArgs e)
        {
            FormBebida formBebida = new FormBebida(gestor);
            formBebida.Show();

            this.Visible = false;
        }

        private void button_patatas_Click(object sender, EventArgs e)
        {
            FormPatatas formPatatas = new FormPatatas(gestor);
            formPatatas.Show();

            this.Visible = false;
        }
    }
}
