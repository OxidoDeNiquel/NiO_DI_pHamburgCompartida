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
            pictureBox_imagen = new PictureBox();
            label_bienvenida = new Label();
            button_iniciar = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagen).BeginInit();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_imagen
            // 
            pictureBox_imagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_imagen.Image = Properties.Resources.crustaceocrujiente;
            pictureBox_imagen.Location = new Point(3, 3);
            pictureBox_imagen.Name = "pictureBox_imagen";
            pictureBox_imagen.Size = new Size(461, 308);
            pictureBox_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_imagen.TabIndex = 0;
            pictureBox_imagen.TabStop = false;
            // 
            // label_bienvenida
            // 
            label_bienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_bienvenida.AutoSize = true;
            label_bienvenida.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_bienvenida.Location = new Point(3, 314);
            label_bienvenida.Name = "label_bienvenida";
            label_bienvenida.Size = new Size(461, 44);
            label_bienvenida.TabIndex = 1;
            label_bienvenida.Text = "Bienvenid@!\r\nHaz click en el botón para inciar";
            label_bienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_iniciar
            // 
            button_iniciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button_iniciar.BackColor = Color.PaleTurquoise;
            button_iniciar.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_iniciar.Location = new Point(185, 361);
            button_iniciar.Name = "button_iniciar";
            button_iniciar.Size = new Size(97, 38);
            button_iniciar.TabIndex = 2;
            button_iniciar.Text = "Iniciar";
            button_iniciar.UseVisualStyleBackColor = false;
            button_iniciar.Click += button_iniciar_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(pictureBox_imagen, 0, 0);
            tableLayoutPanel.Controls.Add(label_bienvenida, 0, 1);
            tableLayoutPanel.Controls.Add(button_iniciar, 0, 2);
            tableLayoutPanel.Location = new Point(12, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(467, 449);
            tableLayoutPanel.TabIndex = 3;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(491, 473);
            Controls.Add(tableLayoutPanel);
            Name = "FormBienvenida";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagen).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_imagen;
        private Label label_bienvenida;
        private Button button_iniciar;
        private TableLayoutPanel tableLayoutPanel;
    }
}