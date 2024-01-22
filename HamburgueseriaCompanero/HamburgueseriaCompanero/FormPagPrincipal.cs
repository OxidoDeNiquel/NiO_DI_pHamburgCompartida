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
        public FormPagPrincipal()
        {

            InitializeComponent();

        }

        private void botonCesta_Click(object sender, EventArgs e)
        {
            FormTicket FormTicket = new FormTicket();
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
            FormHamburguesa formHamburguesa = new FormHamburguesa();
            formHamburguesa.Show();

            this.Visible = false;
        }

        private void button_bebida_Click(object sender, EventArgs e)
        {
            FormBebida formBebida = new FormBebida();
            formBebida.Show();

            this.Visible = false;
        }

        private void button_patatas_Click(object sender, EventArgs e)
        {
            FormPatatas formPatatas = new FormPatatas();
            formPatatas.Show();

            this.Visible = false;
        }
    }
}
