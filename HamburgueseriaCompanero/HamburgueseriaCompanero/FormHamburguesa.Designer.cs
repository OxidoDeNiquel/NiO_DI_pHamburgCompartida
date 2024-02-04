namespace HamburgueseriaCompanero
{
    partial class FormHamburguesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHamburguesa));
            button_info = new PictureBox();
            label1 = new Label();
            label_TituloApp = new Label();
            botonCesta = new PictureBox();
            pictureBox_atras = new PictureBox();
            pictureBox_burguercangreburguer = new PictureBox();
            button_burguerCangreburguer = new Button();
            pictureBox1 = new PictureBox();
            button_burguerMeltExplosivo = new Button();
            pictureBox2 = new PictureBox();
            button_burguerDeliciaArenosa = new Button();
            label2 = new Label();
            button_verIngredientesCangreburguer = new Button();
            button_VerIngredientesCME = new Button();
            button_VerIngredientesDA = new Button();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(475, 91);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 9;
            button_info.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 80);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 8;
            label1.Text = "Hamburguesa";
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(167, 30);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 7;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            // 
            // botonCesta
            // 
            botonCesta.BackColor = Color.Transparent;
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(747, 10);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(37, 37);
            botonCesta.SizeMode = PictureBoxSizeMode.StretchImage;
            botonCesta.TabIndex = 6;
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
            pictureBox_atras.TabIndex = 10;
            pictureBox_atras.TabStop = false;
            pictureBox_atras.Click += pictureBox_atras_Click;
            // 
            // pictureBox_burguercangreburguer
            // 
            pictureBox_burguercangreburguer.Image = Properties.Resources.burguercangreburguer;
            pictureBox_burguercangreburguer.Location = new Point(33, 159);
            pictureBox_burguercangreburguer.Name = "pictureBox_burguercangreburguer";
            pictureBox_burguercangreburguer.Size = new Size(226, 162);
            pictureBox_burguercangreburguer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_burguercangreburguer.TabIndex = 12;
            pictureBox_burguercangreburguer.TabStop = false;
            // 
            // button_burguerCangreburguer
            // 
            button_burguerCangreburguer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_burguerCangreburguer.Location = new Point(33, 318);
            button_burguerCangreburguer.Name = "button_burguerCangreburguer";
            button_burguerCangreburguer.Size = new Size(226, 56);
            button_burguerCangreburguer.TabIndex = 11;
            button_burguerCangreburguer.Text = "Cangreburguer";
            button_burguerCangreburguer.UseVisualStyleBackColor = true;
            button_burguerCangreburguer.Click += button_burguer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.burguercangreburguer;
            pictureBox1.Location = new Point(290, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button_burguerMeltExplosivo
            // 
            button_burguerMeltExplosivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_burguerMeltExplosivo.Location = new Point(290, 318);
            button_burguerMeltExplosivo.Name = "button_burguerMeltExplosivo";
            button_burguerMeltExplosivo.Size = new Size(226, 56);
            button_burguerMeltExplosivo.TabIndex = 13;
            button_burguerMeltExplosivo.Text = "Cangre-Melt Explosivo";
            button_burguerMeltExplosivo.UseVisualStyleBackColor = true;
            button_burguerMeltExplosivo.Click += button_burguerMeltExplosivo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.burguercangreburguer;
            pictureBox2.Location = new Point(545, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 162);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // button_burguerDeliciaArenosa
            // 
            button_burguerDeliciaArenosa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_burguerDeliciaArenosa.Location = new Point(545, 318);
            button_burguerDeliciaArenosa.Name = "button_burguerDeliciaArenosa";
            button_burguerDeliciaArenosa.Size = new Size(226, 56);
            button_burguerDeliciaArenosa.TabIndex = 15;
            button_burguerDeliciaArenosa.Text = "Delicia Arenosa";
            button_burguerDeliciaArenosa.UseVisualStyleBackColor = true;
            button_burguerDeliciaArenosa.Click += button_burguerDeliciaArenosa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 123);
            label2.Name = "label2";
            label2.Size = new Size(358, 21);
            label2.TabIndex = 17;
            label2.Text = "Elige el tipo de hamburguesa que se te antoje";
            // 
            // button_verIngredientesCangreburguer
            // 
            button_verIngredientesCangreburguer.BackColor = Color.IndianRed;
            button_verIngredientesCangreburguer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_verIngredientesCangreburguer.Location = new Point(72, 380);
            button_verIngredientesCangreburguer.Name = "button_verIngredientesCangreburguer";
            button_verIngredientesCangreburguer.Size = new Size(152, 29);
            button_verIngredientesCangreburguer.TabIndex = 18;
            button_verIngredientesCangreburguer.Text = "Ver Ingredientes";
            button_verIngredientesCangreburguer.UseVisualStyleBackColor = false;
            button_verIngredientesCangreburguer.Click += button_verIngredientesCarnivora_Click;
            // 
            // button_VerIngredientesCME
            // 
            button_VerIngredientesCME.BackColor = Color.IndianRed;
            button_VerIngredientesCME.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_VerIngredientesCME.Location = new Point(328, 380);
            button_VerIngredientesCME.Name = "button_VerIngredientesCME";
            button_VerIngredientesCME.Size = new Size(152, 29);
            button_VerIngredientesCME.TabIndex = 19;
            button_VerIngredientesCME.Text = "Ver Ingredientes";
            button_VerIngredientesCME.UseVisualStyleBackColor = false;
            button_VerIngredientesCME.Click += button_VerIngredientesCME_Click;
            // 
            // button_VerIngredientesDA
            // 
            button_VerIngredientesDA.BackColor = Color.IndianRed;
            button_VerIngredientesDA.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_VerIngredientesDA.Location = new Point(578, 380);
            button_VerIngredientesDA.Name = "button_VerIngredientesDA";
            button_VerIngredientesDA.Size = new Size(152, 29);
            button_VerIngredientesDA.TabIndex = 20;
            button_VerIngredientesDA.Text = "Ver Ingredientes";
            button_VerIngredientesDA.UseVisualStyleBackColor = false;
            button_VerIngredientesDA.Click += button_VerIngredientesDA_Click;
            // 
            // FormHamburguesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 483);
            Controls.Add(button_VerIngredientesDA);
            Controls.Add(button_VerIngredientesCME);
            Controls.Add(button_verIngredientesCangreburguer);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button_burguerDeliciaArenosa);
            Controls.Add(pictureBox1);
            Controls.Add(button_burguerMeltExplosivo);
            Controls.Add(pictureBox_burguercangreburguer);
            Controls.Add(button_burguerCangreburguer);
            Controls.Add(pictureBox_atras);
            Controls.Add(button_info);
            Controls.Add(label1);
            Controls.Add(label_TituloApp);
            Controls.Add(botonCesta);
            Name = "FormHamburguesa";
            Text = "FormHamburguesa";
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox button_info;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox botonCesta;
        private PictureBox pictureBox_atras;
        private PictureBox pictureBox_burguercangreburguer;
        private Button button_burguerCangreburguer;
        private PictureBox pictureBox1;
        private Button button_burguerMeltExplosivo;
        private PictureBox pictureBox2;
        private Button button_burguerDeliciaArenosa;
        private Label label2;
        private Button button_verIngredientesCangreburguer;
        private Button button_VerIngredientesCME;
        private Button button_VerIngredientesDA;
    }
}