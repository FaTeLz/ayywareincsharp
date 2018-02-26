using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Ayyware_Port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Created By {0}", "FaTeLz"), "Ayyware");
            this.TopMost = true;
        }
        #region movement
        private Point mouseLocation;
        private bool menumoving;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics p;
            p = e.Graphics;
            p.DrawRectangle(new Pen(new LinearGradientBrush(new Point(3, 4), new Point(Width, 4), Color.Blue, Color.Fuchsia), 2), new Rectangle(3, 4, Width - 6, 1));
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && new Rectangle(0, 0, Width, 10).Contains(e.Location))
            {
                menumoving = true;
                mouseLocation = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (menumoving)
                Location = new Point(MousePosition.X - mouseLocation.X, MousePosition.Y - mouseLocation.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) menumoving = false;
        }
        #endregion
    }
}
