using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFun
{
    class Utils
    {
        public static void AdaptSize(Size size, Form form)
        {
            form.MinimumSize = new Size(0, 0);
            form.MaximumSize = new Size(0, 0);

            form.Size = size;

            form.MinimumSize = size;
            form.MaximumSize = size;

            int screen_x = Screen.FromControl(form).WorkingArea.X;
            int screen_y = Screen.FromControl(form).WorkingArea.Y;

            form.Left = screen_x;
            form.Top = screen_y;
            form.Left += (Screen.FromControl(form).WorkingArea.Width - form.Width) / 2;
            form.Top += (Screen.FromControl(form).WorkingArea.Height - form.Height) / 2;
        }
    }
}
