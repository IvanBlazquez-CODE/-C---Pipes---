using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FigurasGeometricas
{
 public class CirculoDibujable : Circulo ,  Dibujable
   
    {
     Color c;
    public CirculoDibujable(int x, int y , float r,Color c):base(x,y,r)
     {
         this.c = c;
     }

     public  void  dibujar(Graphics g)
     {
         g.DrawEllipse(new Pen(c), new Rectangle(CoordX, CoordY, (int)getRadio(),(int)getRadio()));
     }

    }
}
