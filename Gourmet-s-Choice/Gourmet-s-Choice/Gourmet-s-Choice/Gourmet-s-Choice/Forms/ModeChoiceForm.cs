using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gourmet_s_Choice.Helper;

namespace Gourmet_s_Choice.Forms
{
    public partial class ModeChoiceForm : RootForm
    {
        public ModeChoiceForm()
        {
            InitializeComponent();
        }

        MainForm mainform = new MainForm();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainform.GameRound = 8;
            this.Owner = mainform;
            formOnOff.HideForm(this);
            formOnOff.ShowForm(mainform);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mainform.GameRound = 16;
            this.Owner = mainform;
            formOnOff.HideForm(this);
            formOnOff.ShowForm(mainform);
        }
    }
}
