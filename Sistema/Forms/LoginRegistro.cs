using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{

    


    public partial class LoginRegistro : Form
    {
        Class.Data cl_data = new Class.Data();
        public LoginRegistro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Principal PrincipalForm = new Principal();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
          Forms.Register RegisterForm = new Forms.Register();
        }
    }
}
