using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FigurasGeometricas
{
  public  class RectanguloDibujable:Rectangulo,Dibujable
    {
        Color c;
        public RectanguloDibujable(int x, int y, int b, int h,Color c):base(x, y ,b,h)
        {
            this.c = c;
        }
        public  void dibujar(Graphics g)
        {
            g.DrawRectangle(new Pen(c), new Rectangle(CoordX, CoordY,(int) ValorBase,(int) ValorAltura));
        }
    }
}
