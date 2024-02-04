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
    public partial class FormPatatas : Form
    {
        GestorInterfaz gestor;
        public FormPatatas(GestorInterfaz gestor)
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

        private void button_pfritas_Click(object sender, EventArgs e)
        {
            DialogResult resultadoPFritas = MessageBox.Show(
                "¿Quieres añadir unas patatas fritas a tu pedido?\n" +
                "\nPrecio: 2,5€",
                "¡Añade patatas fritas a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoPFritas)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createChips("Patatas fritas", 2.5);
                    MessageBox.Show(
                        "Tus patatas han sido añadidas con éxito.",
                        "¡Patatas fritas añadidas!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    volverAtras();
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void button_pgajo_Click(object sender, EventArgs e)
        {
            DialogResult resultadoPGajo = MessageBox.Show(
                "¿Quieres añadir unas patatas gajo a tu pedido?\n" +
                "\nPrecio: 2,5€",
                "¡Añade patatas gajo a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoPGajo)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createChips("Patatas gajo", 2.5);
                    MessageBox.Show(
                        "Tus patatas han sido añadidas con éxito.",
                        "¡Patatas gajo añadidas!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    volverAtras();
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void pictureBox_atras_Click(object sender, EventArgs e)
        {
            volverAtras();
        }
        private void verCesta()
        {
            FormTicket formTicket = new FormTicket(gestor);
            formTicket.Show();

            this.Visible = false;
        }

        private void botonCesta_Click(object sender, EventArgs e)
        {
            verCesta();
        }
    }
}
