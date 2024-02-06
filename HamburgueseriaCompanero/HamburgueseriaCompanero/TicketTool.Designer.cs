namespace HamburgueseriaCompanero
{
    partial class TicketTool
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            button_borrar = new Button();
            button_guardar = new Button();
            button_pagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Precio });
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(293, 369);
            dataGridView1.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // button_borrar
            // 
            button_borrar.Location = new Point(176, 375);
            button_borrar.Name = "button_borrar";
            button_borrar.Size = new Size(114, 37);
            button_borrar.TabIndex = 1;
            button_borrar.Text = "Borrar Articulo";
            button_borrar.UseVisualStyleBackColor = true;
            // 
            // button_guardar
            // 
            button_guardar.Location = new Point(3, 375);
            button_guardar.Name = "button_guardar";
            button_guardar.Size = new Size(114, 37);
            button_guardar.TabIndex = 2;
            button_guardar.Text = "Guardar pedido";
            button_guardar.UseVisualStyleBackColor = true;
            // 
            // button_pagar
            // 
            button_pagar.Location = new Point(88, 429);
            button_pagar.Name = "button_pagar";
            button_pagar.Size = new Size(114, 37);
            button_pagar.TabIndex = 3;
            button_pagar.Text = "PAGAR";
            button_pagar.UseVisualStyleBackColor = true;
            // 
            // BotonProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_pagar);
            Controls.Add(button_guardar);
            Controls.Add(button_borrar);
            Controls.Add(dataGridView1);
            Name = "BotonProductos";
            Size = new Size(293, 469);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private Button button_borrar;
        private Button button_guardar;
        private Button button_pagar;
    }
}
