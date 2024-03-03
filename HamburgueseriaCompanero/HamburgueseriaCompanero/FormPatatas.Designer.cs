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
            pictureBox_patatasGajo = new PictureBox();
            button_pgajo = new Button();
            button_info = new PictureBox();
            pictureBox_patatasFritas = new PictureBox();
            button_pfritas = new Button();
            label1 = new Label();
            label_TituloApp = new Label();
            botonCesta = new PictureBox();
            pictureBox_atras = new PictureBox();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatasGajo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatasFritas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_patatasGajo
            // 
            pictureBox_patatasGajo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox_patatasGajo.Image = (Image)resources.GetObject("pictureBox_patatasGajo.Image");
            pictureBox_patatasGajo.Location = new Point(489, 3);
            pictureBox_patatasGajo.Name = "pictureBox_patatasGajo";
            pictureBox_patatasGajo.Size = new Size(225, 152);
            pictureBox_patatasGajo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_patatasGajo.TabIndex = 17;
            pictureBox_patatasGajo.TabStop = false;
            // 
            // button_pgajo
            // 
            button_pgajo.Anchor = AnchorStyles.Top;
            button_pgajo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_pgajo.Location = new Point(488, 161);
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
            button_info.Location = new Point(500, 3);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 15;
            button_info.TabStop = false;
            button_info.Click += button_info_Click;
            // 
            // pictureBox_patatasFritas
            // 
            pictureBox_patatasFritas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox_patatasFritas.Image = (Image)resources.GetObject("pictureBox_patatasFritas.Image");
            pictureBox_patatasFritas.Location = new Point(88, 3);
            pictureBox_patatasFritas.Name = "pictureBox_patatasFritas";
            pictureBox_patatasFritas.Size = new Size(225, 152);
            pictureBox_patatasFritas.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_patatasFritas.TabIndex = 14;
            pictureBox_patatasFritas.TabStop = false;
            // 
            // button_pfritas
            // 
            button_pfritas.Anchor = AnchorStyles.Top;
            button_pfritas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_pfritas.Location = new Point(87, 161);
            button_pfritas.Name = "button_pfritas";
            button_pfritas.Size = new Size(226, 56);
            button_pfritas.TabIndex = 13;
            button_pfritas.Text = "Patatas fritas";
            button_pfritas.UseVisualStyleBackColor = true;
            button_pfritas.Click += button_pfritas_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 12;
            label1.Text = "Nuestras patatas";
            // 
            // label_TituloApp
            // 
            label_TituloApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(3, 51);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(802, 49);
            label_TituloApp.TabIndex = 11;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            label_TituloApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botonCesta
            // 
            botonCesta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            botonCesta.BackColor = Color.Transparent;
            botonCesta.Cursor = Cursors.Hand;
            botonCesta.Image = Properties.Resources.cesta;
            botonCesta.Location = new Point(762, 3);
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
            pictureBox_atras.Location = new Point(3, 3);
            pictureBox_atras.Name = "pictureBox_atras";
            pictureBox_atras.Size = new Size(37, 37);
            pictureBox_atras.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_atras.TabIndex = 18;
            pictureBox_atras.TabStop = false;
            pictureBox_atras.Click += pictureBox_atras_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(label_TituloApp, 0, 1);
            tableLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel.Location = new Point(12, 12);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6972475F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2385321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3853207F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 64.44954F));
            tableLayoutPanel.Size = new Size(808, 436);
            tableLayoutPanel.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.9700737F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.0299263F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(button_info, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 103);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(802, 48);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox_patatasFritas, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox_patatasGajo, 1, 0);
            tableLayoutPanel2.Controls.Add(button_pgajo, 1, 1);
            tableLayoutPanel2.Controls.Add(button_pfritas, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 157);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.246376F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.753624F));
            tableLayoutPanel2.Size = new Size(802, 276);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.6109724F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.90274F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.361596F));
            tableLayoutPanel3.Controls.Add(pictureBox_atras, 0, 0);
            tableLayoutPanel3.Controls.Add(botonCesta, 2, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(802, 45);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // FormPatatas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(832, 460);
            Controls.Add(tableLayoutPanel);
            Name = "FormPatatas";
            Text = "FormPatatas";
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatasGajo).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_patatasFritas).EndInit();
            ((System.ComponentModel.ISupportInitialize)botonCesta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).EndInit();
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_patatasGajo;
        private Button button_pgajo;
        private PictureBox button_info;
        private PictureBox pictureBox_patatasFritas;
        private Button button_pfritas;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox botonCesta;
        private PictureBox pictureBox_atras;
        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}