using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFun
{
    class GridElement : PictureBox
    {
        public static Color[] myColors = { Color.FromArgb(236, 157, 172), Color.FromArgb(97, 103, 165), Color.FromArgb(240, 202, 117), Color.FromArgb(227, 98, 35), Color.FromArgb(56, 155, 215), Color.FromArgb(123, 134, 33) };

        static Random rnd = new Random();

        public static int size = 25;

        public int row { get; set; }
        public int col { get; set; }

        public GridElement(int size2)
        {
            size = size2;
            Width = Height = size;
            int initColor = rnd.Next() % myColors.Length;
            BackColor = myColors[initColor];
        }

    }
}
