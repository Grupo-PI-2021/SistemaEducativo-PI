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
    public partial class Fix : Form
    {
        public Fix()
        {
            InitializeComponent();
        }

        private void Fix_Load(object sender, EventArgs e)
        {
            this.Hide();

            Forms.LoginRegistro frmlogin = new Forms.LoginRegistro();
            frmlogin.Show();
        }
    }
}
