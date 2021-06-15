
namespace Sistema.Forms
{
    partial class LoginRegistro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegistro));
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picLogoGeral = new System.Windows.Forms.PictureBox();
            this.rbtnRegistrar = new Sistema.Forms.RoundButton();
            this.rbtnLogar = new Sistema.Forms.RoundButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGeral)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.Location = new System.Drawing.Point(72, 284);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(215, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Senha...";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Black;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Montserrat", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.LightGray;
            this.txtUser.Location = new System.Drawing.Point(72, 192);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(215, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Usuário...";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
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
            this.pnlTop.Size = new System.Drawing.Size(304, 37);
            this.pnlTop.TabIndex = 10;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(270, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(11, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(249, 19);
            this.lblLogo.TabIndex = 17;
            this.lblLogo.Text = "Edu 4 All - Software Educativo";
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseDown);
            this.lblLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseMove);
            this.lblLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblLogo_MouseUp);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(212, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(52, 32);
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.Location = new System.Drawing.Point(19, 176);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(45, 50);
            this.picUser.TabIndex = 13;
            this.picUser.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.Transparent;
            this.picPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPass.BackgroundImage")));
            this.picPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPass.Location = new System.Drawing.Point(19, 266);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(45, 50);
            this.picPass.TabIndex = 14;
            this.picPass.TabStop = false;
            // 
            // picLogoGeral
            // 
            this.picLogoGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogoGeral.BackgroundImage")));
            this.picLogoGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogoGeral.Location = new System.Drawing.Point(12, 44);
            this.picLogoGeral.Name = "picLogoGeral";
            this.picLogoGeral.Size = new System.Drawing.Size(280, 127);
            this.picLogoGeral.TabIndex = 18;
            this.picLogoGeral.TabStop = false;
            // 
            // rbtnRegistrar
            // 
            this.rbtnRegistrar.BackColor = System.Drawing.Color.Indigo;
            this.rbtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnRegistrar.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.rbtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.rbtnRegistrar.Location = new System.Drawing.Point(72, 394);
            this.rbtnRegistrar.Name = "rbtnRegistrar";
            this.rbtnRegistrar.Radius = 24;
            this.rbtnRegistrar.Size = new System.Drawing.Size(163, 32);
            this.rbtnRegistrar.TabIndex = 3;
            this.rbtnRegistrar.Text = "Registrar";
            this.rbtnRegistrar.UseVisualStyleBackColor = false;
            this.rbtnRegistrar.Click += new System.EventHandler(this.rbtnRegistrar_Click);
            // 
            // rbtnLogar
            // 
            this.rbtnLogar.BackColor = System.Drawing.Color.Indigo;
            this.rbtnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnLogar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLogar.ForeColor = System.Drawing.Color.White;
            this.rbtnLogar.Location = new System.Drawing.Point(70, 348);
            this.rbtnLogar.Name = "rbtnLogar";
            this.rbtnLogar.Radius = 24;
            this.rbtnLogar.Size = new System.Drawing.Size(165, 32);
            this.rbtnLogar.TabIndex = 2;
            this.rbtnLogar.Text = "Logar";
            this.rbtnLogar.UseVisualStyleBackColor = false;
            this.rbtnLogar.Click += new System.EventHandler(this.rbtnLogar_Click);
            // 
            // LoginRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 468);
            this.Controls.Add(this.rbtnRegistrar);
            this.Controls.Add(this.rbtnLogar);
            this.Controls.Add(this.picLogoGeral);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pnlTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login/Registro";
            this.Load += new System.EventHandler(this.LoginRegistro_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginRegistro_Paint);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoGeral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLogoGeral;
        private RoundButton rbtnRegistrar;
        private RoundButton rbtnLogar;
    }
}

