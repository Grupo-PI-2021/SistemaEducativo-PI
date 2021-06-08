using System;

using System.Drawing;

using System.Windows.Forms;

namespace Sistema.Forms
{

    public partial class LoginRegistro : Form
    {
        Class.Data cl_data = new Class.Data();
        public LoginRegistro()
        {
            InitializeComponent();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            Principal PrincipalForm = new Principal();
            PrincipalForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
          //Forms.Register RegisterForm = new Forms.Register();
        }

        private void LoginRegistro_Load(object sender, EventArgs e)
        {
            this.txtUser.BackColor = Color.LimeGreen;
        }
    }
}
