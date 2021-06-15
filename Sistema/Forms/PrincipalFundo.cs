using System;
using System.Windows.Forms;

namespace Sistema.Forms
{
    public partial class PrincipalFundo : Form
    {
        public PrincipalFundo()
        {
            InitializeComponent();
        }

        private void PrincipalFundo_Load(object sender, EventArgs e)
        {
            Class.Data cl_data = new Class.Data();
            Forms.Principal frmPrincipal = new Forms.Principal();
            frmPrincipal.MdiParent = this;
            frmPrincipal.Show();

        }

        private void PrincipalFundo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(4);
        }
    }
}
