using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5laba.Objects;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _5laba.Objects
{
    class RedCircle : BaseObject
    {
        public Color color;
        int size = 20;

        public RedCircle(float x, float y, float angle) : base(x, y, angle)
        {
        }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.FromArgb(120,255,0,0)), -size/2, -size/2, size, size);
            size++;
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(-size/2, -size/2, size, size);
            return path;
        }


    }
}
