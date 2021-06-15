using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema.Forms
{
    public partial class FormModal : Form
    {
        public FormModal(string licaotxt)
        {
            InitializeComponent();
            rtxtDica.Text = licaotxt;
        }
        private bool mouseDown;
        private Point lastLocation;
        Pen pen = new Pen(Color.White, 3);
        private void FormModal_Load(object sender, EventArgs e)
        {
            Class.Data cl_data = new Class.Data();

            rtxtDica.BackColor = cl_data.ColorBackg;
            //pnlCenter.BackColor = cl_data.ColorBackg;
            pnlTop.BackColor = cl_data.ColorBackgDark;
            pnlBottom.BackColor = cl_data.ColorBackgDark;
            btnClose.BackColor = cl_data.ColorPurple;
            btnMore.BackColor = cl_data.ColorPurple;
        }
        private void pnlCenter_Paint(object sender, PaintEventArgs e)
        {
            Rectangle formRectangle = new Rectangle(0, 0, 419, 419);
            e.Graphics.DrawRectangle(pen, formRectangle);
        }
        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            Rectangle formRectangle = new Rectangle(0, 0, 419, 419);
            e.Graphics.DrawRectangle(pen, formRectangle);
        }
        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {
            Rectangle formRectangle = new Rectangle(0, 0, 419, 419);
            e.Graphics.DrawRectangle(pen, formRectangle);
            Point pta = new Point(0, 29);
            Point ptb = new Point(419, 29);
            e.Graphics.DrawLine(pen, pta, ptb);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
    }
}
