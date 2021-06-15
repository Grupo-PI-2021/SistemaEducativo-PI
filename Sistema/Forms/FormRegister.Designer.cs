
namespace Sistema.Forms
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbtnCadastro = new Sistema.Forms.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Controls.Add(this.lblLogo);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(334, 37);
            this.pnlTop.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(300, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(86, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(160, 19);
            this.lblLogo.TabIndex = 17;
            this.lblLogo.Text = "Edu 4 All - Registro";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(3, 1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(52, 32);
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.Transparent;
            this.picPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPass.BackgroundImage")));
            this.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPass.Location = new System.Drawing.Point(33, 112);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(45, 50);
            this.picPass.TabIndex = 25;
            this.picPass.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Location = new System.Drawing.Point(33, 49);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(45, 50);
            this.picUser.TabIndex = 24;
            this.picUser.TabStop = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Black;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtMail.ForeColor = System.Drawing.Color.LightGray;
            this.txtMail.Location = new System.Drawing.Point(86, 65);
            this.txtMail.Margin = new System.Windows.Forms.Padding(0);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(215, 20);
            this.txtMail.TabIndex = 22;
            this.txtMail.Text = "Insira seu Email...";
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.Location = new System.Drawing.Point(86, 130);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(215, 20);
            this.txtPass.TabIndex = 23;
            this.txtPass.Text = "Insira uma Senha...";
            this.toolTip1.SetToolTip(this.txtPass, "a senha deve conter mais de 4 caracteres.");
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // rbtnCadastro
            // 
            this.rbtnCadastro.BackColor = System.Drawing.Color.Indigo;
            this.rbtnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnCadastro.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCadastro.ForeColor = System.Drawing.Color.White;
            this.rbtnCadastro.Location = new System.Drawing.Point(84, 175);
            this.rbtnCadastro.Name = "rbtnCadastro";
            this.rbtnCadastro.Radius = 24;
            this.rbtnCadastro.Size = new System.Drawing.Size(165, 32);
            this.rbtnCadastro.TabIndex = 26;
            this.rbtnCadastro.Text = "Cadastrar-se";
            this.rbtnCadastro.UseVisualStyleBackColor = false;
            this.rbtnCadastro.Click += new System.EventHandler(this.rbtnCadastro_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.IsBalloon = true;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.rbtnCadastro);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormRegister_Paint);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private RoundButton rbtnCadastro;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}