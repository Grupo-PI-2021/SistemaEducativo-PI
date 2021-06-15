
namespace Sistema.Forms
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCodePrincipal = new System.Windows.Forms.TabPage();
            this.chkTema = new System.Windows.Forms.CheckBox();
            this.btnSaida = new System.Windows.Forms.Button();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.btnAvancarLicao = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlWebSharp = new System.Windows.Forms.Panel();
            this.grpCenter = new System.Windows.Forms.GroupBox();
            this.grpEsconde = new System.Windows.Forms.GroupBox();
            this.pnlEsconde = new System.Windows.Forms.Panel();
            this.lblProgressLoading = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.pageExamples = new System.Windows.Forms.TabPage();
            this.timerProgressBarLoading = new System.Windows.Forms.Timer(this.components);
            this.ofdAtividade = new System.Windows.Forms.OpenFileDialog();
            this.rbtnComecar = new Sistema.Forms.RoundButton();
            this.tabControl1.SuspendLayout();
            this.pageCodePrincipal.SuspendLayout();
            this.pnlWebSharp.SuspendLayout();
            this.grpCenter.SuspendLayout();
            this.grpEsconde.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCodePrincipal);
            this.tabControl1.Controls.Add(this.pageExamples);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 723);
            this.tabControl1.TabIndex = 0;
            // 
            // pageCodePrincipal
            // 
            this.pageCodePrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pageCodePrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageCodePrincipal.Controls.Add(this.chkTema);
            this.pageCodePrincipal.Controls.Add(this.btnSaida);
            this.pageCodePrincipal.Controls.Add(this.txtAdr);
            this.pageCodePrincipal.Controls.Add(this.btnAvancarLicao);
            this.pageCodePrincipal.Controls.Add(this.btnFinish);
            this.pageCodePrincipal.Controls.Add(this.button1);
            this.pageCodePrincipal.Controls.Add(this.pnlWebSharp);
            this.pageCodePrincipal.Location = new System.Drawing.Point(4, 22);
            this.pageCodePrincipal.Name = "pageCodePrincipal";
            this.pageCodePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.pageCodePrincipal.Size = new System.Drawing.Size(1016, 697);
            this.pageCodePrincipal.TabIndex = 0;
            this.pageCodePrincipal.Text = "Go Programar!";
            this.pageCodePrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pageCodePrincipal_MouseDown);
            this.pageCodePrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pageCodePrincipal_MouseMove);
            this.pageCodePrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pageCodePrincipal_MouseUp);
            // 
            // chkTema
            // 
            this.chkTema.AutoSize = true;
            this.chkTema.Enabled = false;
            this.chkTema.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTema.ForeColor = System.Drawing.Color.White;
            this.chkTema.Location = new System.Drawing.Point(188, 20);
            this.chkTema.Name = "chkTema";
            this.chkTema.Size = new System.Drawing.Size(118, 23);
            this.chkTema.TabIndex = 18;
            this.chkTema.Text = "Tema: Claro";
            this.chkTema.UseVisualStyleBackColor = true;
            this.chkTema.CheckedChanged += new System.EventHandler(this.chkTema_CheckedChanged);
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaida.ForeColor = System.Drawing.Color.White;
            this.btnSaida.Location = new System.Drawing.Point(877, 4);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(130, 38);
            this.btnSaida.TabIndex = 16;
            this.btnSaida.Text = "Finalizar Sessão";
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // txtAdr
            // 
            this.txtAdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdr.Location = new System.Drawing.Point(499, 15);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(183, 20);
            this.txtAdr.TabIndex = 1;
            this.txtAdr.Text = "https://dotnetfiddle.net/";
            this.txtAdr.Visible = false;
            // 
            // btnAvancarLicao
            // 
            this.btnAvancarLicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAvancarLicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancarLicao.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancarLicao.ForeColor = System.Drawing.Color.White;
            this.btnAvancarLicao.Location = new System.Drawing.Point(7, 5);
            this.btnAvancarLicao.Name = "btnAvancarLicao";
            this.btnAvancarLicao.Size = new System.Drawing.Size(116, 38);
            this.btnAvancarLicao.TabIndex = 14;
            this.btnAvancarLicao.Text = "Avançar";
            this.btnAvancarLicao.UseVisualStyleBackColor = false;
            this.btnAvancarLicao.Click += new System.EventHandler(this.btnAvancarLicao_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(713, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(116, 38);
            this.btnFinish.TabIndex = 13;
            this.btnFinish.Text = "Finalizar Nível";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnLoadSchemas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlWebSharp
            // 
            this.pnlWebSharp.Controls.Add(this.grpCenter);
            this.pnlWebSharp.Controls.Add(this.grpEsconde);
            this.pnlWebSharp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWebSharp.Location = new System.Drawing.Point(3, 45);
            this.pnlWebSharp.Name = "pnlWebSharp";
            this.pnlWebSharp.Size = new System.Drawing.Size(1008, 647);
            this.pnlWebSharp.TabIndex = 2;
            // 
            // grpCenter
            // 
            this.grpCenter.Controls.Add(this.rbtnComecar);
            this.grpCenter.Location = new System.Drawing.Point(404, 160);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(200, 100);
            this.grpCenter.TabIndex = 5;
            this.grpCenter.TabStop = false;
            // 
            // grpEsconde
            // 
            this.grpEsconde.Controls.Add(this.pnlEsconde);
            this.grpEsconde.Controls.Add(this.lblProgressLoading);
            this.grpEsconde.Controls.Add(this.progressBarLoading);
            this.grpEsconde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpEsconde.Location = new System.Drawing.Point(0, -2);
            this.grpEsconde.Name = "grpEsconde";
            this.grpEsconde.Size = new System.Drawing.Size(1008, 649);
            this.grpEsconde.TabIndex = 6;
            this.grpEsconde.TabStop = false;
            // 
            // pnlEsconde
            // 
            this.pnlEsconde.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEsconde.Location = new System.Drawing.Point(3, 386);
            this.pnlEsconde.Name = "pnlEsconde";
            this.pnlEsconde.Size = new System.Drawing.Size(1002, 260);
            this.pnlEsconde.TabIndex = 4;
            // 
            // lblProgressLoading
            // 
            this.lblProgressLoading.AutoSize = true;
            this.lblProgressLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressLoading.Font = new System.Drawing.Font("Montserrat", 23F, System.Drawing.FontStyle.Bold);
            this.lblProgressLoading.ForeColor = System.Drawing.Color.White;
            this.lblProgressLoading.Location = new System.Drawing.Point(387, 314);
            this.lblProgressLoading.Name = "lblProgressLoading";
            this.lblProgressLoading.Size = new System.Drawing.Size(235, 38);
            this.lblProgressLoading.TabIndex = 3;
            this.lblProgressLoading.Text = "Loading... 0%";
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.progressBarLoading.Location = new System.Drawing.Point(344, 355);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(320, 25);
            this.progressBarLoading.TabIndex = 0;
            // 
            // pageExamples
            // 
            this.pageExamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pageExamples.Location = new System.Drawing.Point(4, 22);
            this.pageExamples.Name = "pageExamples";
            this.pageExamples.Padding = new System.Windows.Forms.Padding(3);
            this.pageExamples.Size = new System.Drawing.Size(1016, 697);
            this.pageExamples.TabIndex = 1;
            this.pageExamples.Text = "<Exemplos>";
            // 
            // timerProgressBarLoading
            // 
            this.timerProgressBarLoading.Enabled = true;
            this.timerProgressBarLoading.Interval = 24;
            this.timerProgressBarLoading.Tick += new System.EventHandler(this.timerProgressBarLoading_Tick);
            // 
            // ofdAtividade
            // 
            this.ofdAtividade.FileName = "openFileDialog1";
            // 
            // rbtnComecar
            // 
            this.rbtnComecar.BackColor = System.Drawing.Color.SlateBlue;
            this.rbtnComecar.Enabled = false;
            this.rbtnComecar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnComecar.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnComecar.ForeColor = System.Drawing.Color.White;
            this.rbtnComecar.Location = new System.Drawing.Point(11, 23);
            this.rbtnComecar.Name = "rbtnComecar";
            this.rbtnComecar.Radius = 24;
            this.rbtnComecar.Size = new System.Drawing.Size(178, 55);
            this.rbtnComecar.TabIndex = 4;
            this.rbtnComecar.Text = "string start = \"CODAR!\";";
            this.rbtnComecar.UseVisualStyleBackColor = false;
            this.rbtnComecar.Click += new System.EventHandler(this.rbtnComecar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1024, 725);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.pageCodePrincipal.ResumeLayout(false);
            this.pageCodePrincipal.PerformLayout();
            this.pnlWebSharp.ResumeLayout(false);
            this.grpCenter.ResumeLayout(false);
            this.grpEsconde.ResumeLayout(false);
            this.grpEsconde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageCodePrincipal;
        private System.Windows.Forms.TabPage pageExamples;
        private System.Windows.Forms.Panel pnlWebSharp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdr;
        private RoundButton rbtnComecar;
        private System.Windows.Forms.GroupBox grpCenter;
        private System.Windows.Forms.GroupBox grpEsconde;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer timerProgressBarLoading;
        private System.Windows.Forms.Label lblProgressLoading;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnAvancarLicao;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.OpenFileDialog ofdAtividade;
        private System.Windows.Forms.Panel pnlEsconde;
        private System.Windows.Forms.CheckBox chkTema;
    }
}