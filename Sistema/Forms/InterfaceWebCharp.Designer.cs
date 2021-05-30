
namespace Sistema.Forms
{
    partial class InterfaceWebCharp
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWebSharp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlWebSharp
            // 
            this.pnlWebSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWebSharp.Location = new System.Drawing.Point(0, 0);
            this.pnlWebSharp.Name = "pnlWebSharp";
            this.pnlWebSharp.Size = new System.Drawing.Size(327, 263);
            this.pnlWebSharp.TabIndex = 0;
            // 
            // InterfaceWebCharp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlWebSharp);
            this.Name = "InterfaceWebCharp";
            this.Size = new System.Drawing.Size(327, 263);
            this.Load += new System.EventHandler(this.InterfaceWebCharp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWebSharp;
    }
}
