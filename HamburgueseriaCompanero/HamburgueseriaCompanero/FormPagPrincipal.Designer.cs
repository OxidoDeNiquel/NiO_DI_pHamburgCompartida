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
            label_tituloApp = new Label();
            label_subtitulo = new Label();
            button_burguer = new Button();
            pictureBox_burguercangreburguer = new PictureBox();
            button_info = new PictureBox();
            pictureBox_bebida = new PictureBox();
            button_bebida = new Button();
            pictureBox_patatas = new PictureBox();
            button_patatas = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // botonCesta
            // 
            botonCesta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            botonCesta.BackColor = Color.Transparent;
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(730, 3);
            botonCesta.Name = "botonCesta";
            botonCesta.Size = new Size(37, 38);
            botonCesta.SizeMode = PictureBoxSizeMode.StretchImage;
            botonCesta.TabIndex = 0;
            botonCesta.TabStop = false;
            botonCesta.Click += botonCesta_Click;
            // 
            // label_tituloApp
            // 
            label_tituloApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_tituloApp.AutoSize = true;
            label_tituloApp.BackColor = Color.Transparent;
            label_tituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_tituloApp.Location = new Point(3, 50);
            label_tituloApp.Name = "label_tituloApp";
            label_tituloApp.Size = new Size(770, 60);
            label_tituloApp.TabIndex = 1;
            label_tituloApp.Text = "BURGUER CANGREBURGUER";
            label_tituloApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_subtitulo
            // 
            label_subtitulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_subtitulo.AutoSize = true;
            label_subtitulo.BackColor = Color.Transparent;
            label_subtitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_subtitulo.Location = new Point(226, 0);
            label_subtitulo.Name = "label_subtitulo";
            label_subtitulo.Size = new Size(331, 30);
            label_subtitulo.TabIndex = 2;
            label_subtitulo.Text = "¡Hola! ¿Qué deseas comer hoy?";
            // 
            // button_burguer
            // 
            button_burguer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_burguer.Location = new Point(3, 175);
            button_burguer.Name = "button_burguer";
            button_burguer.Size = new Size(226, 56);
            button_burguer.TabIndex = 3;
            button_burguer.Text = "Hamburguesa";
            button_burguer.UseVisualStyleBackColor = true;
            button_burguer.Click += button_burguer_Click;
            // 
            // pictureBox_burguercangreburguer
            // 
            pictureBox_burguercangreburguer.Image = Properties.Resources.burguercangreburguer;
            pictureBox_burguercangreburguer.Location = new Point(3, 3);
            pictureBox_burguercangreburguer.Name = "pictureBox_burguercangreburguer";
            pictureBox_burguercangreburguer.Size = new Size(226, 162);
            pictureBox_burguercangreburguer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_burguercangreburguer.TabIndex = 4;
            pictureBox_burguercangreburguer.TabStop = false;
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(563, 3);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 5;
            button_info.TabStop = false;
            button_info.Click += button_info_Click;
            // 
            // pictureBox_bebida
            // 
            pictureBox_bebida.Image = (Image)resources.GetObject("pictureBox_bebida.Image");
            pictureBox_bebida.Location = new Point(259, 3);
            pictureBox_bebida.Name = "pictureBox_bebida";
            pictureBox_bebida.Size = new Size(226, 162);
            pictureBox_bebida.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_bebida.TabIndex = 7;
            pictureBox_bebida.TabStop = false;
            // 
            // button_bebida
            // 
            button_bebida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_bebida.Location = new Point(259, 175);
            button_bebida.Name = "button_bebida";
            button_bebida.Size = new Size(226, 56);
            button_bebida.TabIndex = 6;
            button_bebida.Text = "Bebida";
            button_bebida.UseVisualStyleBackColor = true;
            button_bebida.Click += button_bebida_Click;
            // 
            // pictureBox_patatas
            // 
            pictureBox_patatas.BackColor = Color.White;
            pictureBox_patatas.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_patatas.Image = (Image)resources.GetObject("pictureBox_patatas.Image");
            pictureBox_patatas.Location = new Point(515, 3);
            pictureBox_patatas.Name = "pictureBox_patatas";
            pictureBox_patatas.Size = new Size(226, 162);
            pictureBox_patatas.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_patatas.TabIndex = 9;
            pictureBox_patatas.TabStop = false;
            // 
            // button_patatas
            // 
            button_patatas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_patatas.Location = new Point(515, 175);
            button_patatas.Name = "button_patatas";
            button_patatas.Size = new Size(227, 56);
            button_patatas.TabIndex = 8;
            button_patatas.Text = "Patatas";
            button_patatas.UseVisualStyleBackColor = true;
            button_patatas.Click += button_patatas_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(label_tituloApp, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1513948F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.565737F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.52191F));
            tableLayoutPanel1.Size = new Size(776, 502);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.85714F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.1428566F));
            tableLayoutPanel2.Controls.Add(label_subtitulo, 0, 0);
            tableLayoutPanel2.Controls.Add(button_info, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 113);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(770, 36);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.41558F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.58441544F));
            tableLayoutPanel3.Controls.Add(botonCesta, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(770, 44);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.Controls.Add(pictureBox_burguercangreburguer, 0, 0);
            tableLayoutPanel4.Controls.Add(button_patatas, 2, 1);
            tableLayoutPanel4.Controls.Add(pictureBox_patatas, 2, 0);
            tableLayoutPanel4.Controls.Add(button_bebida, 1, 1);
            tableLayoutPanel4.Controls.Add(pictureBox_bebida, 1, 0);
            tableLayoutPanel4.Controls.Add(button_burguer, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 155);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(770, 344);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // FormPagPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 526);
            Controls.Add(tableLayoutPanel1);
            Name = "FormPagPrincipal";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)botonCesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_burguercangreburguer).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_bebida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox botonCesta;
        private Label label_tituloApp;
        private Label label_subtitulo;
        private Button button_burguer;
        private PictureBox pictureBox_burguercangreburguer;
        private PictureBox button_info;
        private PictureBox pictureBox_bebida;
        private Button button_bebida;
        private PictureBox pictureBox_patatas;
        private Button button_patatas;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}