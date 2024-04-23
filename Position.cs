using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3nWF
{
    class Position
    {
        public float x;
        public float y;
        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt( Math.Pow( x, 2 ) + Math.Pow( y, 2 ) );
            }
        }
    }
}
