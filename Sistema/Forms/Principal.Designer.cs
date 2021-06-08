
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCodePrincipal = new System.Windows.Forms.TabPage();
            this.pnlWebSharp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdr = new System.Windows.Forms.TextBox();
            this.pageExamples = new System.Windows.Forms.TabPage();
            this.btnComecar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.pageCodePrincipal.SuspendLayout();
            this.pnlWebSharp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCodePrincipal);
            this.tabControl1.Controls.Add(this.pageExamples);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // pageCodePrincipal
            // 
            this.pageCodePrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pageCodePrincipal.Controls.Add(this.pnlWebSharp);
            this.pageCodePrincipal.Location = new System.Drawing.Point(4, 22);
            this.pageCodePrincipal.Name = "pageCodePrincipal";
            this.pageCodePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.pageCodePrincipal.Size = new System.Drawing.Size(1000, 655);
            this.pageCodePrincipal.TabIndex = 0;
            this.pageCodePrincipal.Text = "<Codar/>";
            // 
            // pnlWebSharp
            // 
            this.pnlWebSharp.Controls.Add(this.btnComecar);
            this.pnlWebSharp.Controls.Add(this.button1);
            this.pnlWebSharp.Controls.Add(this.txtAdr);
            this.pnlWebSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWebSharp.Location = new System.Drawing.Point(3, 3);
            this.pnlWebSharp.Name = "pnlWebSharp";
            this.pnlWebSharp.Size = new System.Drawing.Size(994, 649);
            this.pnlWebSharp.TabIndex = 2;
            this.pnlWebSharp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWebSharp_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnLoadSchemas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdr
            // 
            this.txtAdr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAdr.Location = new System.Drawing.Point(5, 504);
            this.txtAdr.Name = "txtAdr";
            this.txtAdr.Size = new System.Drawing.Size(183, 20);
            this.txtAdr.TabIndex = 1;
            this.txtAdr.Text = "https://dotnetfiddle.net/";
            this.txtAdr.Visible = false;
            this.txtAdr.TextChanged += new System.EventHandler(this.txtAdr_TextChanged);
            // 
            // pageExamples
            // 
            this.pageExamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pageExamples.Location = new System.Drawing.Point(4, 22);
            this.pageExamples.Name = "pageExamples";
            this.pageExamples.Padding = new System.Windows.Forms.Padding(3);
            this.pageExamples.Size = new System.Drawing.Size(1000, 655);
            this.pageExamples.TabIndex = 1;
            this.pageExamples.Text = "Examples";
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(423, 289);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(148, 70);
            this.btnComecar.TabIndex = 3;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Visible = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
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
            this.pnlWebSharp.ResumeLayout(false);
            this.pnlWebSharp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageCodePrincipal;
        private System.Windows.Forms.TabPage pageExamples;
        private System.Windows.Forms.Panel pnlWebSharp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdr;
        private System.Windows.Forms.Button btnComecar;
    }
}