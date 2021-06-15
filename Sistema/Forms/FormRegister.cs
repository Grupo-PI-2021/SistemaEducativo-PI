using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema.Forms
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        MySqlConnection objCon = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=usbw;Database=eduforall");

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Insira seu Email...")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.White;
            }
            else if (String.IsNullOrEmpty(txtMail.Text))
            {
                txtMail.Text = "Insira seu Email...";
                txtMail.ForeColor = Color.LightGray;
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMail.Text))
            {
                txtMail.Text = "Insira seu Email...";
                txtMail.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Insira uma Senha...")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Insira uma Senha...";
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Insira uma Senha...";
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

            Class.Data cl_data = new Class.Data();

            this.BackColor = cl_data.ColorBackgDark;
            txtMail.BackColor = cl_data.ColorBackgDark;
            txtPass.BackColor = cl_data.ColorBackgDark;
            rbtnCadastro.BackColor = cl_data.ColorC_PurpleH;
        }

        private void FormRegister_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 4);
            Pen penTudo = new Pen(Color.White, 4);
            Rectangle rectCentro = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectTudo = new Rectangle(0, 0, this.Width, this.Height);

            //ENVOLTA-CENTRO
            e.Graphics.DrawRectangle(pen, rectCentro);
            e.Graphics.DrawRectangle(penTudo, rectTudo);
            //TXT'S
            e.Graphics.DrawLine(pen,
                txtMail.Location.X,
                txtMail.Location.Y + 20,
                txtMail.Location.X + txtMail.Width,
                txtMail.Location.Y + 20);

            e.Graphics.DrawLine(pen,
                txtPass.Location.X,
                txtPass.Location.Y + 20,
                txtPass.Location.X + txtPass.Width,
                txtPass.Location.Y + 20);

        }

        private void rbtnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text == "Insira uma Senha..." && txtMail.Text == "Insira seu Email...")
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Email ou Senha - Fora do formato necessário.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else
                {
                    string comando = "INSERT INTO `eduforall`.`usuarios` (`email`, `senha`, `xp`, `nivel`)" +
                    "VALUES ('" + txtMail.Text + "', '" + txtPass.Text + "', '0', '0');";
                    //instância do comando
                    MySqlCommand cmd = new MySqlCommand(comando, objCon);

                    objCon.Open();

                    cmd.ExecuteNonQuery();

                    objCon.Close();

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Usuário: " + txtMail.Text + " Cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Forms.FormLevelSelector fsc = new Forms.FormLevelSelector();
                    fsc.ShowDialog();
                }

            }catch(Exception a)
            {
                MessageBox.Show("Error: " + a.ToString());
            }


        }
       
    }
}
