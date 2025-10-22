namespace VeterinariaProyecto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "user" && txtContraseña.Text == "user")
            {
                frmMenuPrincipal frmMenu = new frmMenuPrincipal();
                this.Hide();
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
