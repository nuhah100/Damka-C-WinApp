using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Damka
{
    public partial class fStartScreen : Form
    {
        public fDamka form = new fDamka();
        public fAbout form1 = new fAbout();
        public bool b = true;
        public Bitmap bitstore;
        public fStartScreen()
        {
            InitializeComponent();
        }

        private void fStartScreen_Paint(object sender, PaintEventArgs e)
        {
            int Wd = e.ClipRectangle.Width, Ht = e.ClipRectangle.Height;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b = !b;
            pcbDamka.Refresh();
        }

        private void pcbDamka_Paint(object sender, PaintEventArgs e)
        {
            int Wd = pcbDamka.ClientRectangle.Width, Ht = pcbDamka.ClientRectangle.Height;
            float xScale = (float)(Wd / 100.0), yScale = (float)(Ht / 100.0);
            string st = "D A M K A";
            Font font = new Font("Ariel", 30);
            SolidBrush SBrush = new SolidBrush(Color.Purple);
            Point point = new Point((int)(20 * xScale), (int)(10 * yScale));
            if (b)
            {
                e.Graphics.DrawString(st, font, SBrush, point);
            }
            else
            {

                e.Graphics.DrawImage(bitstore,0,0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void fStartScreen_Load(object sender, EventArgs e)
        {
            bitstore = new Bitmap(pcbDamka.ClientRectangle.Width, pcbDamka.ClientRectangle.Height);
        }
    }
}
