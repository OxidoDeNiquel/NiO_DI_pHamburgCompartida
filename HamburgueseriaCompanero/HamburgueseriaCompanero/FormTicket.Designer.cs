namespace HamburgueseriaCompanero
{
    partial class FormTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicket));
            button_info = new PictureBox();
            label1 = new Label();
            label_TituloApp = new Label();
            pictureBox_atras = new PictureBox();
            dataGridViewTicket = new DataGridView();
            column_name = new DataGridViewTextBoxColumn();
            column_price = new DataGridViewTextBoxColumn();
            button_pagar = new Button();
            button_borrar = new Button();
            button_guardar = new Button();
            button_importar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.Anchor = AnchorStyles.Left;
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(623, 18);
            button_info.Name = "button_info";
            button_info.Size = new Size(18, 19);
            button_info.SizeMode = PictureBoxSizeMode.StretchImage;
            button_info.TabIndex = 8;
            button_info.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 56);
            label1.Name = "label1";
            label1.Size = new Size(85, 56);
            label1.TabIndex = 7;
            label1.Text = "TICKET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_TituloApp
            // 
            label_TituloApp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(176, 0);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(422, 56);
            label_TituloApp.TabIndex = 6;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
            label_TituloApp.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBox_atras.TabIndex = 19;
            pictureBox_atras.TabStop = false;
            pictureBox_atras.Click += pictureBox_atras_Click;
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridViewTicket.BackgroundColor = Color.White;
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { column_name, column_price });
            dataGridViewTicket.Location = new Point(240, 115);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowTemplate.Height = 25;
            dataGridViewTicket.Size = new Size(294, 386);
            dataGridViewTicket.TabIndex = 20;
            // 
            // column_name
            // 
            column_name.HeaderText = "Nombre";
            column_name.Name = "column_name";
            column_name.Width = 150;
            // 
            // column_price
            // 
            column_price.HeaderText = "Precio";
            column_price.Name = "column_price";
            // 
            // button_pagar
            // 
            button_pagar.Anchor = AnchorStyles.Top;
            button_pagar.Location = new Point(331, 507);
            button_pagar.Name = "button_pagar";
            button_pagar.Size = new Size(113, 41);
            button_pagar.TabIndex = 21;
            button_pagar.Text = "PAGAR";
            button_pagar.UseVisualStyleBackColor = true;
            button_pagar.Click += button_pagar_Click;
            // 
            // button_borrar
            // 
            button_borrar.Location = new Point(3, 138);
            button_borrar.Name = "button_borrar";
            button_borrar.Size = new Size(144, 23);
            button_borrar.TabIndex = 22;
            button_borrar.Text = "Borrar Articulo";
            button_borrar.UseVisualStyleBackColor = true;
            button_borrar.Click += button_borrar_Click;
            // 
            // button_guardar
            // 
            button_guardar.Location = new Point(3, 176);
            button_guardar.Name = "button_guardar";
            button_guardar.Size = new Size(144, 23);
            button_guardar.TabIndex = 23;
            button_guardar.Text = "Guardar pedido";
            button_guardar.UseVisualStyleBackColor = true;
            button_guardar.Click += button1_Click;
            // 
            // button_importar
            // 
            button_importar.Location = new Point(3, 214);
            button_importar.Name = "button_importar";
            button_importar.Size = new Size(144, 23);
            button_importar.TabIndex = 24;
            button_importar.Text = "Importar pedido";
            button_importar.UseVisualStyleBackColor = true;
            button_importar.Click += button2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(dataGridViewTicket, 1, 2);
            tableLayoutPanel1.Controls.Add(pictureBox_atras, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label_TituloApp, 1, 0);
            tableLayoutPanel1.Controls.Add(button_info, 2, 0);
            tableLayoutPanel1.Controls.Add(button_pagar, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(776, 560);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button_borrar, 0, 1);
            tableLayoutPanel2.Controls.Add(button_guardar, 0, 2);
            tableLayoutPanel2.Controls.Add(button_importar, 0, 3);
            tableLayoutPanel2.Location = new Point(623, 115);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(150, 386);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoDeBikini;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 584);
            Controls.Add(tableLayoutPanel1);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox button_info;
        private Label label1;
        private Label label_TituloApp;
        private PictureBox pictureBox_atras;
        private DataGridView dataGridViewTicket;
        private Button button_pagar;
        private Button button_borrar;
        private DataGridViewTextBoxColumn column_name;
        private DataGridViewTextBoxColumn column_price;
        private Button button_guardar;
        private Button button_importar;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}