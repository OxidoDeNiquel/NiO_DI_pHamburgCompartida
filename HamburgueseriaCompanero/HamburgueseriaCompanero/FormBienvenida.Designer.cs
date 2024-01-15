namespace HamburgueseriaCompanero
{
    partial class FormBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox_image = new PictureBox();
            labelBienvenida = new Label();
            button_iniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_image
            // 
            pictureBox_image.Image = Properties.Resources.crustaceocrujiente;
            pictureBox_image.Location = new Point(12, 12);
            pictureBox_image.Name = "pictureBox_image";
            pictureBox_image.Size = new Size(472, 336);
            pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_image.TabIndex = 0;
            pictureBox_image.TabStop = false;
            // 
            // labelBienvenida
            // 
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelBienvenida.Location = new Point(141, 351);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(216, 38);
            labelBienvenida.TabIndex = 1;
            labelBienvenida.Text = "Bienvenid@!\r\nHaz click en el botón para inciar";
            labelBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_iniciar
            // 
            button_iniciar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_iniciar.Location = new Point(200, 399);
            button_iniciar.Name = "button_iniciar";
            button_iniciar.Size = new Size(97, 35);
            button_iniciar.TabIndex = 2;
            button_iniciar.Text = "Iniciar";
            button_iniciar.UseVisualStyleBackColor = true;
            button_iniciar.Click += button_iniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 473);
            Controls.Add(button_iniciar);
            Controls.Add(labelBienvenida);
            Controls.Add(pictureBox_image);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_image;
        private Label labelBienvenida;
        private Button button_iniciar;
    }
}