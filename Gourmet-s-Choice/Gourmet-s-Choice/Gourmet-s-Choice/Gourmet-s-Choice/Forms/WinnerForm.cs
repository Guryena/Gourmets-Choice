using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Choice.Forms
{
    public partial class WinnerForm : RootForm
    {
        public WinnerForm()
        {
            InitializeComponent();
        }

        public int WinnerIndex { get; set; }
        private string winnerName;

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            int winner = WinnerIndex;
            MemoryStream memoryStreamLeft = new MemoryStream(DataRepository.FoodImage.GetById(winner, "Image"));
            pctbWinner.Image = Image.FromStream(memoryStreamLeft);

            winnerName = DataRepository.Food.GetFoodById(winner);
            btnLink.Text = $"{winnerName} 맛집 찾기";

        }

        private void bttnRetry_Click(object sender, EventArgs e)
        {
            ModeChoiceForm choiceForm  = new ModeChoiceForm();
            this.Owner = choiceForm;
            formOnOff.HideForm(this);
            formOnOff.ShowForm(choiceForm);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            string target = "https://www.mangoplate.com/search/";    //Use no more than one assignment when you test this code. 

            string winnerUrl = target + winnerName;

            try
            {
                System.Diagnostics.Process.Start(winnerUrl);
            }
            catch
            (
                System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
