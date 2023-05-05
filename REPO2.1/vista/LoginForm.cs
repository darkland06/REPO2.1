using datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void imageStreamer1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su usuario");
                return;

            }
            errorProvider1.Clear();

            if (txtContra.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese su contraseña");
                return;

            }
            errorProvider1.Clear();

            //Validadar login
            login login = new login(txtUsuario.Text, txtContra.Text);

            ticketDB ticketBD = new ticketDB();
            ticked Ticked = new ticked();

            Ticked = ticketBD.Autenticar(login);


            if (Ticked != null)
            {
                menu menuFormulario = new menu();
                this.Hide();
                menuFormulario.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos");
            }
            //llamado al menu

        }

        private void abrirbtn_Click(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '*')
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }

        }
    }
}
