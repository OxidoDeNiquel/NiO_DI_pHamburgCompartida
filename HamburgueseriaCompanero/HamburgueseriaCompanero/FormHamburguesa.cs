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
    public partial class FormHamburguesa : Form
    {
        public FormHamburguesa()
        {
            InitializeComponent();
        }

        private void pictureBox_atras_Click(object sender, EventArgs e)
        {
            // Abre el nuevo formulario (Form2)
            FormPagPrincipal form2 = new FormPagPrincipal();
            form2.Show();

            this.Visible = false;
        }
    }
}
