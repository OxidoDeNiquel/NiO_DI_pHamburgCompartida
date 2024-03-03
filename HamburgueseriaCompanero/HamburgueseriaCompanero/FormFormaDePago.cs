﻿using System;
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
    public partial class FormFormaDePago : Form
    {
        public FormFormaDePago()
        {
            InitializeComponent();
        }

        private void button_efectivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu pedido ha sido realizado con éxito");
            Application.Exit();
        }

        private void button_tarjeta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tu pedido ha sido realizado con éxito");
            Application.Exit();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            FormBienvenida formBienvenida = new FormBienvenida();
            formBienvenida.Show();
        }
    }
}
