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
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(498, 103);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 9;
            button_info.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 92);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 8;
            label1.Text = "Hamburguesa";
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(167, 30);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 7;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            // 
            // botonCesta
            // 
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(747, 10);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(37, 37);
            botonCesta.SizeMode = PictureBoxSizeMode.StretchImage;
            botonCesta.TabIndex = 6;
            botonCesta.TabStop = false;
            // 
            // pictureBox_atras
            // 
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
            // FormHamburguesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox button_info;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox botonCesta;
        private PictureBox pictureBox_atras;
    }
}