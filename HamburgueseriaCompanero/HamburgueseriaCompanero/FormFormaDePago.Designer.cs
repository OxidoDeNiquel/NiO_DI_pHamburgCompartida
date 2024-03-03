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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_efectivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(481, 3);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 8;
            button_info.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(309, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 7;
            label1.Text = "Forma de pago";
            // 
            // label_TituloApp
            // 
            label_TituloApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(3, 35);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(770, 67);
            label_TituloApp.TabIndex = 6;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            label_TituloApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_efectivo
            // 
            pictureBox_efectivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox_efectivo.BackColor = Color.Transparent;
            pictureBox_efectivo.Image = Properties.Resources.efectivo;
            pictureBox_efectivo.Location = new Point(80, 3);
            pictureBox_efectivo.Name = "pictureBox_efectivo";
            pictureBox_efectivo.Size = new Size(224, 188);
            pictureBox_efectivo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_efectivo.TabIndex = 9;
            pictureBox_efectivo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.tarjeta;
            pictureBox1.Location = new Point(470, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button_efectivo
            // 
            button_efectivo.Anchor = AnchorStyles.Top;
            button_efectivo.Location = new Point(142, 197);
            button_efectivo.Name = "button_efectivo";
            button_efectivo.Size = new Size(101, 38);
            button_efectivo.TabIndex = 11;
            button_efectivo.Text = "EFECTIVO";
            button_efectivo.UseVisualStyleBackColor = true;
            button_efectivo.Click += button_efectivo_Click;
            // 
            // button_tarjeta
            // 
            button_tarjeta.Anchor = AnchorStyles.Top;
            button_tarjeta.Location = new Point(528, 197);
            button_tarjeta.Name = "button_tarjeta";
            button_tarjeta.Size = new Size(99, 41);
            button_tarjeta.TabIndex = 12;
            button_tarjeta.Text = "TARJETA";
            button_tarjeta.UseVisualStyleBackColor = true;
            button_tarjeta.Click += button_tarjeta_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.Location = new Point(3, 3);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(71, 29);
            button_cancelar.TabIndex = 13;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label_TituloApp, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(button_cancelar, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.215962F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7276993F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.389671F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.0779228F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.9220772F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(button_info, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(770, 34);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pictureBox_efectivo, 0, 0);
            tableLayoutPanel3.Controls.Add(button_tarjeta, 1, 1);
            tableLayoutPanel3.Controls.Add(button_efectivo, 0, 1);
            tableLayoutPanel3.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 145);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 69.78417F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30.2158279F));
            tableLayoutPanel3.Size = new Size(770, 278);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // FormFormaDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoDeBikini_definitivo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FormFormaDePago";
            Text = "FormFormaDePago";
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_efectivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}