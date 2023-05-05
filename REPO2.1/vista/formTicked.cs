using Microsoft.VisualBasic.PowerPacks.Printing;
using System;
using System.Windows.Forms;

namespace vista
{
    public partial class formTicket : Form
    {
       

        public formTicket()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese el usuario");
                return;

            }
            errorProvider1.Clear();



            if (comboboxServicio.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese el servicio solicitado");
                return;

            }
            errorProvider1.Clear();


            if (txtDescripcionServicio.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese una descripcion minima");
                return;

            }
            errorProvider1.Clear();


            if (txtDescripcionSolicitud.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Ingrese una descripcion minimaIngrese una descripcion minima");
                return;

            }
            errorProvider1.Clear();
            PrintForm formTicket = new PrintForm();
            formTicket.Form = this;
            formTicket.PrinterSettings.DefaultPageSettings.Landscape = true;
            formTicket.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            formTicket.Print(this, PrintForm.PrintOption.FullWindow);
        }

        private void comboboxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescripcionSolicitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboboxServicio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescripcionServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void formTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
