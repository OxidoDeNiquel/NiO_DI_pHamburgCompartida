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
    public partial class FormBebida : Form
    {
        GestorInterfaz gestor;
        public FormBebida(GestorInterfaz gestor)
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

        private void button_info_Click(object sender, EventArgs e)
        {
            {
                DialogResult resultado = MessageBox.Show(
                    "Todas las bebidas son de 33cl. \nSi desea saber el precio de cada una, haz click en el botón del nombre",
                    "Info adicional de las bebidas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                );

            }
        }

        private void button_agua_Click(object sender, EventArgs e)
        {
            DialogResult resultadoAgua = MessageBox.Show(
                "¿Quieres añadir una botella de agua a tu pedido?\n" +
                "\nPrecio: 2€",
                "¡Añade agua a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoAgua)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createDrinks("Agua", 2);
                    MessageBox.Show(
                        "Tu agua ha sido añadida con éxito.",
                        "¡Agua añadida!",
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

        private void button_cocacola_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCocacola = MessageBox.Show(
                "¿Quieres añadir una CoKCola a tu pedido?\n" +
                "\nPrecio: 2,5€",
                "¡Añade CoKCola a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoCocacola)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void button_cocacola0_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCocacola0 = MessageBox.Show(
                "¿Quieres añadir una botella de CoKCola0 a tu pedido?\n" +
                "\nPrecio: 2,5€",
                "¡Añade CoKCola0 a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoCocacola0)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void button_cerveza_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCerveza = MessageBox.Show(
                "¿Quieres añadir una cerveza a tu pedido?\n" +
                "\nPrecio: 2,5€",
                "¡Añade cerveza a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoCerveza)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void button_nestea_Click(object sender, EventArgs e)
        {
            DialogResult resultadoNesty = MessageBox.Show(
                "¿Quieres añadir un Nesty a tu pedido?\n" +
                "\nPrecio: 2€",
                "¡Añade Nesty a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoNesty)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    break;

                case DialogResult.Cancel:
                    volverAtras();
                    break;
            }
        }

        private void button_limonada_Click(object sender, EventArgs e)
        {
            DialogResult resultadoLimonada = MessageBox.Show(
                "¿Quieres añadir una limonada a tu pedido?\n" +
                "\nPrecio: 3€" +
                "\n(Es natural)",
                "¡Añade limonada a tu pedido!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoLimonada)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
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
