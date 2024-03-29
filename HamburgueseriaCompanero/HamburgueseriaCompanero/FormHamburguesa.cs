﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueseriaCompanero
{
    public partial class FormHamburguesa : Form
    {
        GestorInterfaz gestor;
        public FormHamburguesa(GestorInterfaz gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
        }

        private void pictureBox_atras_Click(object sender, EventArgs e)
        {
            volverAtras();
        }

        private void volverAtras()
        {
            FormPagPrincipal form2 = new FormPagPrincipal(gestor);
            form2.Show();

            this.Visible = false;
        }

        private void button_burguer_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje irresistible con botones de aventura y deleite
            DialogResult resultadoCangreburguer = MessageBox.Show(
                "¡Prueba la Cangreburguer!\n\n" +
                "Sumérgete en la deliciosa experiencia de la Cangreburguer.\n\n¿Te animas a añadirla a tu pedido?\n\nPRECIO: 5€",
                "¡Descubre la Cangreburguer!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoCangreburguer)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createHamburguer("Cangreburguer", 5.0);
                    MessageBox.Show(
                        "Tu hamburguesa ha sido añadida con éxito.",
                        "¡Cangreburguer añadida!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;

                case DialogResult.Cancel:
                    break;
            }

        }

        private void button_verIngredientesCarnivora_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de información con botones de aceptar y cancelar
            DialogResult resultado = MessageBox.Show("CANGREBURGUER\n" +
                "\nIngredientes:\n - Carne de vacuno\n - Lechuga\n - Tomate\n - Queso\n - Cangrejo",
                "Ingredientes Cangreburguer",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

        }

        private void button_burguerMeltExplosivo_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCangreMelt = MessageBox.Show(
                "¡Descubre la CANGRE-MELT EXPLOSIVA!\n\n" +
                "Sumérgete en la explosión de sabores de esta deliciosa hamburguesa.\n\n¿Te animas a añadirla a tu pedido?\n\nPRECIO: 5€",
                "¡Siente la Explosión!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoCangreMelt)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createHamburguer("Cangre-Melt Exposiva", 5.0);
                    MessageBox.Show(
                        "Tu hamburguesa ha sido añadida con éxito.",
                        "¡Cangre-Melt Exposiva añadida!",
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
        private void button_VerIngredientesCME_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "CANGRE-MELT EXPLOSIVO\n\nIngredientes:\n - Carne de vacuno x 2\n - Lechuga\n - Tomate\n - Queso x 2\n - Cebolla Morada\n - Secreto Explosivo",
                "Ingredientes Cangre-Melt Explosivo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );

        }

        private void button_burguerDeliciaArenosa_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDeliciaArenosa = MessageBox.Show(
                "¡Prueba la DELICIA ARENOSA!\n\n" +
                "Disfruta de una hamburguesa única con sabores sorprendentes.\n\n¿Te animas a añadirla a tu pedido?\n\nPRECIO: 5€",
                "¡Explora la Delicia!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            // Verificar la respuesta del usuario
            switch (resultadoDeliciaArenosa)
            {
                case DialogResult.OK:
                    Console.WriteLine("El usuario ha seleccionado 'OK'.");
                    gestor.createHamburguer("Delicia Arenosa", 5.0);
                    MessageBox.Show(
                        "Tu hamburguesa ha sido añadida con éxito.",
                        "¡Delicia Arenosa añadida!",
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
        private void button_VerIngredientesDA_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "DELICIA ARENOSA\n\nIngredientes:\n - Carne de vacuno x 3\n - Lechuga\n - Tomate\n - Queso x 2\n - Cebolla Morada\n - Huevo de corral\n - Delicia Marina (Arena de mar)",
                "Ingredientes Cangreburguer",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );

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

        private void button_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona los botones para elegir el artículo que deseas incluir en tu pedido.\r\n",
                "Info adicional de las hamburguesas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
        }

        private void pictureBox_cesta_Click(object sender, EventArgs e)
        {
            FormTicket formTicket = new FormTicket(gestor);
            formTicket.Show();
            this.Visible = false;
        }
    }
}
