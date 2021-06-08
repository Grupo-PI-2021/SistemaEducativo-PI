using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Sistema.Forms
{
    public partial class RoundButton : Button
    {
        public RoundButton()
        {
            InitializeComponent();
        }
        public class RoundBtn : Button
        {
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(50, 50, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(grPath);
                base.OnPaint(e);
            }
        }
    }
}
