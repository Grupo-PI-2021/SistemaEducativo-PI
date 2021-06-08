
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
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.roundButton1 = new Sistema.Forms.RoundButton();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(61, 180);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(165, 32);
            this.btnLog.TabIndex = 0;
            this.btnLog.Text = "Logar-se";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Transparent;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(61, 241);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(165, 32);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Criar uma Conta";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Black;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Montserrat", 13F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(64, 146);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 22);
            this.txtUser.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Montserrat", 13F);
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(64, 72);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(163, 22);
            this.txtPass.TabIndex = 3;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(250, 3);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(27, 28);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(286, 37);
            this.pnlTop.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 30);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.Transparent;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.roundButton1);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(286, 305);
            this.pnlFundo.TabIndex = 11;
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(129, 99);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(97, 31);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // LoginRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(286, 305);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.pnlFundo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login/Registro";
            this.Load += new System.EventHandler(this.LoginRegistro_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFundo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFundo;
        private RoundButton roundButton1;
    }
}

