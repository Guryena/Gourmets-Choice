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
    public partial class StartForm : RootForm
    {
        private ModeChoiceForm choiceForm;

        public StartForm()
        {
            InitializeComponent();
            
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.choiceForm = new ModeChoiceForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Owner = choiceForm;
            formOnOff.HideForm(this);
            formOnOff.ShowForm(choiceForm);

        }
        
    }
}
