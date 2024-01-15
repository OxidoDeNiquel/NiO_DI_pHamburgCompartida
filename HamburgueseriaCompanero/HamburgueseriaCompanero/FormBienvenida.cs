using MyBrgLib_1;

namespace HamburgueseriaCompanero
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {

            // Abre el nuevo formulario (Form2)
            FormPagPrincipal form2 = new FormPagPrincipal();
            form2.Show();

            this.Visible = false;
        }
    }
}