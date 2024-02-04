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
            ((System.ComponentModel.ISupportInitialize)button_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
            SuspendLayout();
            // 
            // button_info
            // 
            button_info.BackColor = Color.Transparent;
            button_info.Image = Properties.Resources.info;
            button_info.Location = new Point(454, 98);
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
            label1.Location = new Point(363, 92);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 7;
            label1.Text = "TICKET";
            // 
            // label_TituloApp
            // 
            label_TituloApp.AutoSize = true;
            label_TituloApp.BackColor = Color.Transparent;
            label_TituloApp.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label_TituloApp.Location = new Point(162, 30);
            label_TituloApp.Name = "label_TituloApp";
            label_TituloApp.Size = new Size(464, 40);
            label_TituloApp.TabIndex = 6;
            label_TituloApp.Text = "BURGUER CANGREBURGUER";
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
            pictureBox_atras.TabIndex = 19;
            pictureBox_atras.TabStop = false;
            pictureBox_atras.Click += pictureBox_atras_Click;
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.BackgroundColor = Color.White;
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Columns.AddRange(new DataGridViewColumn[] { column_name, column_price });
            dataGridViewTicket.Location = new Point(268, 125);
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.RowTemplate.Height = 25;
            dataGridViewTicket.Size = new Size(294, 382);
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
            button_pagar.Location = new Point(359, 513);
            button_pagar.Name = "button_pagar";
            button_pagar.Size = new Size(113, 41);
            button_pagar.TabIndex = 21;
            button_pagar.Text = "PAGAR";
            button_pagar.UseVisualStyleBackColor = true;
            // 
            // button_borrar
            // 
            button_borrar.Location = new Point(591, 298);
            button_borrar.Name = "button_borrar";
            button_borrar.Size = new Size(151, 23);
            button_borrar.TabIndex = 22;
            button_borrar.Text = "Borrar Articulo";
            button_borrar.UseVisualStyleBackColor = true;
            button_borrar.Click += button_borrar_Click;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 584);
            Controls.Add(button_borrar);
            Controls.Add(button_pagar);
            Controls.Add(dataGridViewTicket);
            Controls.Add(pictureBox_atras);
            Controls.Add(button_info);
            Controls.Add(label1);
            Controls.Add(label_TituloApp);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
            ((System.ComponentModel.ISupportInitialize)button_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_atras).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}