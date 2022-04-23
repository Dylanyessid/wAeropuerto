using frmAeropuerto.Controllers;
namespace frmAeropuerto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Instanciación de controlador, "logueo"
            LoginController l = new LoginController(txtEmail.Text, txtPassword.Text);
            if (l.executeLogin())
            {
                MessageBox.Show("Ingreso Exitoso");
                new Views.frmFlightsList().ShowDialog();
            }
            else
            {
                MessageBox.Show("Error. Credenciales incorrectas");
            }
        }
    }
}