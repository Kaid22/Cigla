using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cigla
{
    class Cigla
    {
        Point o;
        int a, b;
        public void Postavi(int a, int b, Point o)
        {
            if(a>=0 && b >= 0)
            {
                this.a = a;
                this.b = b;
                this.o = o;
            }
            else
            {
                throw new Exception("BROJ JE NEGATIVAN");
            }
        }
        public void Postavi(int a, int b, int x, int y)
        {
            if(a>=0 && b >= 0)
            {
                this.a = a;
                this.b = b;
                this.o = new Point(x, y);
            }
            else
            {
                throw new Exception("BROJ JE NEGATIVAN");
            }
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(Color.Black);
            SolidBrush cetka = new SolidBrush(Color.RosyBrown);
            g.FillRectangle(cetka, o.X - a / 2, o.Y - b / 2, a, b);
            g.DrawRectangle(olovka, o.X - a / 2, o.Y - b / 2, a, b);
        }
    }
}
