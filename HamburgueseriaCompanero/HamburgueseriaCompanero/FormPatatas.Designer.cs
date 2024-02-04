namespace HamburgueseriaCompanero
{
    partial class FormPatatas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatatas));
            pictureBox_bebida = new PictureBox();
            button_pgajo = new Button();
            button_info = new PictureBox();
            pictureBox_burguercangreburguer = new PictureBox();
            button_pfritas = new Button();
            label1 = new Label();
            label_TituloApp = new Label();
            botonCesta = new PictureBox();
            pictureBox_atras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_bebida
            // 
            pictureBox_bebida.Image = (Image)resources.GetObject("pictureBox_bebida.Image");
            pictureBox_bebida.Location = new Point(471, 148);
            pictureBox_bebida.Name = "pictureBox_bebida";
            pictureBox_bebida.Size = new Size(225, 162);
            pictureBox_bebida.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_bebida.TabIndex = 17;
            pictureBox_bebida.TabStop = false;
            // 
            // button_pgajo
            // 
            button_pgajo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_pgajo.Location = new Point(471, 307);
            button_pgajo.Name = "button_pgajo";
            button_pgajo.Size = new Size(226, 56);
            button_pgajo.TabIndex = 16;
            button_pgajo.Text = "Patatas gajo";
            button_pgajo.UseVisualStyleBackColor = true;
            button_pgajo.Click += button_pgajo_Click;
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(513, 103);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 15;
            button_info.TabStop = false;
            // 
            // pictureBox_burguercangreburguer
            // 
            pictureBox_burguercangreburguer.Image = (Image)resources.GetObject("pictureBox_burguercangreburguer.Image");
            pictureBox_burguercangreburguer.Location = new Point(115, 148);
            pictureBox_burguercangreburguer.Name = "pictureBox_burguercangreburguer";
            pictureBox_burguercangreburguer.Size = new Size(225, 162);
            pictureBox_burguercangreburguer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_burguercangreburguer.TabIndex = 14;
            pictureBox_burguercangreburguer.TabStop = false;
            // 
            // button_pfritas
            // 
            button_pfritas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_pfritas.Location = new Point(115, 307);
            button_pfritas.Name = "button_pfritas";
            button_pfritas.Size = new Size(226, 56);
            button_pfritas.TabIndex = 13;
            button_pfritas.Text = "Patatas fritas";
            button_pfritas.UseVisualStyleBackColor = true;
            button_pfritas.Click += button_pfritas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(319, 92);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 12;
            label1.Text = "Nuestras patatas";
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(173, 35);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 11;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            // 
            // botonCesta
            // 
            botonCesta.BackColor = Color.Transparent;
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(748, 10);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(37, 37);
            botonCesta.SizeMode = PictureBoxSizeMode.StretchImage;
            botonCesta.TabIndex = 10;
            botonCesta.TabStop = false;
            botonCesta.Click += botonCesta_Click;
            // 
            // pictureBox_atras
            // 
            pictureBox_atras.BackColor = Color.Transparent;
            pictureBox_atras.Cursor = Cursors.Hand;
            pictureBox_atras.Image = (Image)resources.GetObject("pictureBox_atras.Image");
            pictureBox_atras.Location = new Point(12, 12);
            pictureBox_atras.Name = "pictureBox_atras";
            pictureBox_atras.Size = new Size(37, 37);
            pictureBox_atras.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_atras.TabIndex = 18;
            pictureBox_atras.TabStop = false;
            pictureBox_atras.Click += pictureBox_atras_Click;
            // 
            // FormPatatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 434);
            Controls.Add(pictureBox_atras);
            Controls.Add(pictureBox_bebida);
            Controls.Add(button_pgajo);
            Controls.Add(button_info);
            Controls.Add(pictureBox_burguercangreburguer);
            Controls.Add(button_pfritas);
            Controls.Add(label1);
            Controls.Add(label_TituloApp);
            Controls.Add(botonCesta);
            Name = "FormPatatas";
            Text = "FormPatatas";
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_bebida;
        private Button button_pgajo;
        private PictureBox button_info;
        private PictureBox pictureBox_burguercangreburguer;
        private Button button_pfritas;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox botonCesta;
        private PictureBox pictureBox_atras;
    }
}