using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3nWF
{
    class Triangle
    {
        private Position A;
        private Position B;
        private Position C;

        public Triangle(Position pos0, Position pos1, Position pos2)
        {
            A = pos0;
            B = pos1;
            C = pos2;
        }

        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen( Color.Black );
            e.Graphics.DrawLine(pen, A.x, A.y, B.x, B.y);
            e.Graphics.DrawLine(pen, C.x, C.y, A.x, A.y );
            e.Graphics.DrawLine(pen, B.x, B.y, C.x, C.y);
        }
    }
}
