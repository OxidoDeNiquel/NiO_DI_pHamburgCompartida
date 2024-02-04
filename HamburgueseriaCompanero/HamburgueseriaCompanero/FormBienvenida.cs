using MyBrgLib_1;

namespace HamburgueseriaCompanero
{
    public partial class FormBienvenida : Form
    {
        GestorInterfaz gestor;
        public FormBienvenida()
        {
            gestor = new GestorInterfaz();
            InitializeComponent();
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {

            // Abre el nuevo formulario (Form2)
            FormPagPrincipal form2 = new FormPagPrincipal(gestor);
            form2.Show();

            this.Visible = false;
        }
    }
}