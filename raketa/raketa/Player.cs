using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raketa
{
    public class Player
    {
        public Point point;
        public Size size;
        public Region reg;
        public Pen laser_pen;
    }
    public void New_player(Form1 F)
    {
        size = F.imageeP.Size;
        point.X = 0;
        point.Y = 0;
        Rectangle rec = new Rectangle(point, size);
        reg = new Regiom(rec);
        laser_pen = new Pen(new HatchBrush)
    }
    public void Show_player(Form1 F, int x, int y)
    {
        F.g.ResetClip();
        F.g.FillRectangle(new System.Drawing.SolidBrush(F.BackColor), reg);
        point.X = x - size.Width / 2;
        point.Y = y;
        Rectangle rec = new Rectangle(point, size);
        reg = new Region(rec);
        F.g.DrawRectangle(F.imageeP, point);
        F.g.ExcludeClip(reg);

    }

}
