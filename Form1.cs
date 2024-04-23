using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _3nWF
{
    public partial class Form1 : Form
    {
        private readonly List<Triangle> triangles = new List<Triangle>();
        private readonly List<Position> positions = new List<Position>();
        private readonly List<Position> positions2 = new List<Position>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in triangles)
            {
                item.Draw( e );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int edges = 3;
            int n = 4;
            int count = n * edges;

            for (int i = 0; i < count; i++)
            {
                positions.Add( new Position( random.Next( 0, 500 ), random.Next( 0, 500 ) ) );
            }

            positions.Sort( (pos1, pos2) => pos1.Length.CompareTo( pos2.Length ) );

            for (int i = 0; i < count;)
            {
                triangles.Add( new Triangle(
                    positions[i],
                    positions[i + 1],
                    positions[i + 2]
                ) );
                i += 3;
            }
        }
    }
}
