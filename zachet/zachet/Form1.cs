using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zachet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Point click;
        Graphics g;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                click = e.Location;
                g.DrawRectangle(Pens.Black, click.X, click.Y, 200, 200);
            }
        }
    }
}