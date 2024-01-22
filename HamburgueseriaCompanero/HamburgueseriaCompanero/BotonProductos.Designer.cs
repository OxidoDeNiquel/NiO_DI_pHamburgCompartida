namespace HamburgueseriaCompanero
{
    partial class BotonProductos
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
            pictureBox_image = new PictureBox();
            button_elem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_image
            // 
            pictureBox_image.Image = Properties.Resources.burguercangreburguer;
            pictureBox_image.Location = new Point(3, 3);
            pictureBox_image.Name = "pictureBox_image";
            pictureBox_image.Size = new Size(226, 162);
            pictureBox_image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_image.TabIndex = 8;
            pictureBox_image.TabStop = false;
            // 
            // button_elem
            // 
            button_elem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_elem.Location = new Point(3, 164);
            button_elem.Name = "button_elem";
            button_elem.Size = new Size(226, 48);
            button_elem.TabIndex = 7;
            button_elem.Text = "Hamburguesa";
            button_elem.UseVisualStyleBackColor = true;
            // 
            // BotonProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox_image);
            Controls.Add(button_elem);
            Name = "BotonProductos";
            Size = new Size(232, 216);
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox_image;
        private Button button_elem;
    }
}
