using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema.Forms
{
    public partial class LoginRegistro : Form
    {
        Class.Data cl_data = new Class.Data();
        public LoginRegistro()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        MySqlConnection objCon = new MySqlConnection("Server=127.0.0.1;User ID=root;Password=usbw;Database=eduforall");

        private void btnLog_Click(object sender, EventArgs e)
        {
            Principal PrincipalForm = new Principal();
            PrincipalForm.Show();
            this.Hide();
        }

        private void LoginRegistro_Load(object sender, EventArgs e)
        {
            //ON LOAD
            btnExit.Focus();

            Class.Data cl_data = new Class.Data();

            this.BackColor = cl_data.ColorBackgDark;
            txtUser.BackColor = cl_data.ColorBackgDark;
            txtPass.BackColor = cl_data.ColorBackgDark;
            rbtnLogar.BackColor = cl_data.ColorC_PurpleH;
            rbtnRegistrar.BackColor = cl_data.ColorC_PurpleH;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(4);
        }

        private void LoginRegistro_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 2);
            Pen penTudo = new Pen(Color.Purple, 4);
            Rectangle rectCentro = new Rectangle(9, 42, 285, 412);
            Rectangle rectTudo = new Rectangle(0, 0, 303, 467);
            //Rectangle rectTudo = new Rectangle(0, 0, this.Width, this.Height);

            //TEXTBOX'S
            e.Graphics.DrawLine(pen, 72, 215, 270, 215);//Y = LOCAL+23
            e.Graphics.DrawLine(pen, 72, 307, 270, 307);//Y = LOCAL+23

            //ENVOLTA-CENTRO
            e.Graphics.DrawRectangle(pen, rectCentro);
            e.Graphics.DrawRectangle(penTudo, rectTudo);
        }


        //MOUSE-MOVE-DRAG-FORM
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void lblLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void lblLogo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void lblLogo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Usuário...";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuário...")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
            else if (String.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Usuário...";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Senha...")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.White;
            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Senha...";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.Text = "Senha...";
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void rbtnLogar_Click(object sender, EventArgs e)
        {
            if (ValidaUsuario(txtUser.Text, txtPass.Text))
            {
                this.DialogResult = DialogResult.OK;

                MessageBox.Show("Usuário: "+txtUser.Text+" Autenticado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Forms.FormLevelSelector fsc = new Forms.FormLevelSelector();
                fsc.ShowDialog();

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Usuário ou Senha - Incorretos.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnRegistrar_Click(object sender, EventArgs e)
        {
            Forms.FormRegister RegisterForm = new Forms.FormRegister();
            RegisterForm.ShowDialog();
        }

        private bool ValidaUsuario(string usuario, string senha)
        {
            //variável que será testada para
            //informar o retorno
            int retorno = -1;

            //comando sql que dá um count 
            //na tabela se existirem usuario e senha
            //com os dados informados
            string comando = "SELECT COUNT(*) FROM usuarios WHERE nome=@Usuario AND senha=@Senha";
            //instância do comando
            MySqlCommand cmd = new MySqlCommand(comando, objCon);
            //preenchimento dos parâmetros
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            //abro conexão
            objCon.Open();
            //retorno recebe o resultado do execute scalar
            retorno = Convert.ToInt32(cmd.ExecuteScalar());
            //fecho conexão
            objCon.Close();
            //retorno true se retorno for maior que zero
            return retorno > 0;

        }
    }
}