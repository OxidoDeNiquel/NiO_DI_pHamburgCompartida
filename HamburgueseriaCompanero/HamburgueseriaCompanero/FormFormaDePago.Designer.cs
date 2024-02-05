namespace HamburgueseriaCompanero
{
    partial class FormFormaDePago
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
            button_info = new PictureBox();
            label1 = new Label();
            label_TituloApp = new Label();
            pictureBox_efectivo = new PictureBox();
            pictureBox1 = new PictureBox();
            button_efectivo = new Button();
            button_tarjeta = new Button();
            button_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_efectivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(484, 115);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 8;
            button_info.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 108);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 7;
            label1.Text = "Forma de pago";
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(169, 54);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 6;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            // 
            // pictureBox_efectivo
            // 
            pictureBox_efectivo.BackColor = Color.Transparent;
            pictureBox_efectivo.Image = Properties.Resources.efectivo;
            pictureBox_efectivo.Location = new Point(92, 166);
            pictureBox_efectivo.Name = "pictureBox_efectivo";
            pictureBox_efectivo.Size = new Size(224, 192);
            pictureBox_efectivo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_efectivo.TabIndex = 9;
            pictureBox_efectivo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tarjeta;
            pictureBox1.Location = new Point(477, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button_efectivo
            // 
            button_efectivo.Location = new Point(151, 364);
            button_efectivo.Name = "button_efectivo";
            button_efectivo.Size = new Size(101, 38);
            button_efectivo.TabIndex = 11;
            button_efectivo.Text = "EFECTIVO";
            button_efectivo.UseVisualStyleBackColor = true;
            // 
            // button_tarjeta
            // 
            button_tarjeta.Location = new Point(534, 364);
            button_tarjeta.Name = "button_tarjeta";
            button_tarjeta.Size = new Size(99, 41);
            button_tarjeta.TabIndex = 12;
            button_tarjeta.Text = "TARJETA";
            button_tarjeta.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            button_cancelar.Location = new Point(12, 12);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(71, 29);
            button_cancelar.TabIndex = 13;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            // 
            // FormFormaDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoDeBikini_definitivo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancelar);
            Controls.Add(button_tarjeta);
            Controls.Add(button_efectivo);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox_efectivo);
            Controls.Add(button_info);
            Controls.Add(label1);
            Controls.Add(label_TituloApp);
            Name = "FormFormaDePago";
            Text = "FormFormaDePago";
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_efectivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox button_info;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox pictureBox_efectivo;
        private PictureBox pictureBox1;
        private Button button_efectivo;
        private Button button_tarjeta;
        private Button button_cancelar;
    }
}