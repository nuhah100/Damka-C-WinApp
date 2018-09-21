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
    public partial class fAbout : Form
    {
        public fAbout()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblAbout.Text = "Welcome To D A M K A Game!\n\n\n In this game you will play damka with your friends!!!\n hope you will enjoy!";
        }

        private void fAbout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
