using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cigla
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 80, b = 40, x, y;
        int red = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point o = new Point(x, y);
            Graphics g = CreateGraphics();
            Cigla c = new Cigla();
            c.Postavi(a, b, o);
            c.Crtaj(g);
            x += a;
            if (x > ClientRectangle.Width)
            {
                if (red % 2 == 0)
                {
                    x = 0;
                    y -= b;
                }
                else
                {
                    x = a / 2;
                    y -= b;
                }
                red++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            x = a / 2;
            y = ClientRectangle.Height - b / 2;
        }
    }
}
