using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Choice.Helper
{
    class FormOnOff
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Point Location { get; set; }
        private System.Windows.Forms.FormBorderStyle borderStyle;

        public void ShowForm(Form form)
        {
            form.Visible = true;
            form.FormBorderStyle = borderStyle;
            form.Height = Height;
            form.Width = Width;
            form.Location = Location;
        }

        public void HideForm(Form form)
        {
            Height = form.Height;
            Width = form.Width;
            Location = form.Location;
            borderStyle = form.FormBorderStyle;

            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Height = 0;
            form.Width = 0;
            form.Visible = false;
        }
    }
}
