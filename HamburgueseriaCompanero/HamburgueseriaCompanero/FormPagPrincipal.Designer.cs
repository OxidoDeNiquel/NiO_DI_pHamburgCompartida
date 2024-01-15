namespace HamburgueseriaCompanero
{
    partial class FormPagPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagPrincipal));
            botonCesta = new PictureBox();
            label_TituloApp = new Label();
            label1 = new Label();
            button_burguer = new Button();
            pictureBox_burguercangreburguer = new PictureBox();
            button_info = new PictureBox();
            pictureBox_bebida = new PictureBox();
            button_bebida = new Button();
            pictureBox_patatas = new PictureBox();
            button_patatas = new Button();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatas).BeginInit();
            SuspendLayout();
            // 
            // botonCesta
            // 
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(751, 12);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(37, 37);
            botonCesta.SizeMode = PictureBoxSizeMode.StretchImage;
            botonCesta.TabIndex = 0;
            botonCesta.TabStop = false;
            botonCesta.Click += botonCesta_Click;
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(192, 9);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 1;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 97);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 2;
            label1.Text = "¡Hola! ¿Qué deseas comer hoy?";
            // 
            // button_burguer
            // 
            button_burguer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_burguer.Location = new Point(104, 327);
            button_burguer.Name = "button_burguer";
            button_burguer.Size = new Size(102, 35);
            button_burguer.TabIndex = 3;
            button_burguer.Text = "Hamburguesa";
            button_burguer.UseVisualStyleBackColor = true;
            button_burguer.Click += button_burguer_Click;
            // 
            // pictureBox_burguercangreburguer
            // 
            pictureBox_burguercangreburguer.Image = Properties.Resources.burguercangreburguer;
            pictureBox_burguercangreburguer.Location = new Point(41, 159);
            pictureBox_burguercangreburguer.Name = "pictureBox_burguercangreburguer";
            pictureBox_burguercangreburguer.Size = new Size(226, 162);
            pictureBox_burguercangreburguer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_burguercangreburguer.TabIndex = 4;
            pictureBox_burguercangreburguer.TabStop = false;
            // 
            // button_info
            // 
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(573, 105);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 5;
            button_info.TabStop = false;
            // 
            // pictureBox_bebida
            // 
            pictureBox_bebida.Image = (Image)resources.GetObject("pictureBox_bebida.Image");
            pictureBox_bebida.Location = new Point(285, 159);
            pictureBox_bebida.Name = "pictureBox_bebida";
            pictureBox_bebida.Size = new Size(226, 162);
            pictureBox_bebida.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_bebida.TabIndex = 7;
            pictureBox_bebida.TabStop = false;
            // 
            // button_bebida
            // 
            button_bebida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_bebida.Location = new Point(348, 327);
            button_bebida.Name = "button_bebida";
            button_bebida.Size = new Size(102, 35);
            button_bebida.TabIndex = 6;
            button_bebida.Text = "Bebida";
            button_bebida.UseVisualStyleBackColor = true;
            button_bebida.Click += button_bebida_Click;
            // 
            // pictureBox_patatas
            // 
            pictureBox_patatas.Image = (Image)resources.GetObject("pictureBox_patatas.Image");
            pictureBox_patatas.Location = new Point(532, 159);
            pictureBox_patatas.Name = "pictureBox_patatas";
            pictureBox_patatas.Size = new Size(226, 162);
            pictureBox_patatas.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_patatas.TabIndex = 9;
            pictureBox_patatas.TabStop = false;
            // 
            // button_patatas
            // 
            button_patatas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_patatas.Location = new Point(595, 327);
            button_patatas.Name = "button_patatas";
            button_patatas.Size = new Size(102, 35);
            button_patatas.TabIndex = 8;
            button_patatas.Text = "Patatas";
            button_patatas.UseVisualStyleBackColor = true;
            button_patatas.Click += button_patatas_Click;
            // 
            // FormPagPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 526);
            Controls.Add(pictureBox_patatas);
            Controls.Add(button_patatas);
            Controls.Add(pictureBox_bebida);
            Controls.Add(button_bebida);
            Controls.Add(button_info);
            Controls.Add(pictureBox_burguercangreburguer);
            Controls.Add(button_burguer);
            Controls.Add(label1);
            Controls.Add(label_TituloApp);
            Controls.Add(botonCesta);
            Name = "FormPagPrincipal";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)botonCesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox botonCesta;
        private Label label_TituloApp;
        private Label label1;
        private Button button_burguer;
        private PictureBox pictureBox_burguercangreburguer;
        private PictureBox button_info;
        private PictureBox pictureBox_bebida;
        private Button button_bebida;
        private PictureBox pictureBox_patatas;
        private Button button_patatas;
    }
}