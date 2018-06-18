using Gourmet_s_Choice.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using Gourmet_s_Choice.Forms;
using Gourmet_s_Choice.Helper;

namespace Gourmet_s_Choice
{
    public enum RoundWinner
    {
        Left,
        Right
    }

    public partial class MainForm : RootForm
    {

        public MainForm()
        {
            InitializeComponent();
        }

        #region Fields
        private List<int> foodsList;
        private List<Battle> battles;
        private int gameRound;
        public int GameRound { get; set; }
        private Image roundImage;
        private int idPointer = 0;
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            //ModeChoiceForm에서 라운드를 가져온다.
            gameRound = GameRound;

            if(gameRound == 16)
                roundImage = (Image)Resources.Round_16;
            else if(gameRound == 8)
                roundImage = (Image)Resources.Round_8;

            pctbRound.Image = roundImage;

            //랜덤으로 음식을 가져올 리스트를 생성해둔다
            foodsList = RandomIndex.GenerateRandIndex(gameRound);

            battles = Battle.GenerateRounds(foodsList);
            UpdateBattleImage(idPointer);
        }

        private void ptbLeft_Click(object sender, EventArgs e)
        {
            idPointer++;
            int clickeOn = (int)RoundWinner.Left;
            UpdateBattleList(clickeOn);
        }

        private void ptbRight_Click(object sender, EventArgs e)
        {
            idPointer++;
            int clickeOn = (int)RoundWinner.Right;
            UpdateBattleList(clickeOn);
        }
        #endregion

        #region Update Battle List
        //한 토너먼트가 끝나면 idPointer를 0으로 리셋시키고, 새로운 토너먼트 id리스트를 받아와야 한다.
        public void UpdateBattleList(int clickOn)
        {
            battles[idPointer - 1].Winner = battles[idPointer - 1].Foods[clickOn];

            //포인터가 리스트의 값을 넘어서서 한 라운드가 끝나면 다음 라운드로 값을 변경시킨다.
            if (idPointer > battles.Count - 1)
            {
                battles[idPointer - 1].Winner = battles[idPointer - 1].Foods[clickOn];

                gameRound /= 2;
                
                idPointer = 0;

                //각 라운드의 승자가 저장된 Battle List를 넘겨서 다음 대전 리스트를 만든다.
                List<int> winnerList = RandomIndex.ShuffleIndex(battles.ConvertAll(x => x.Winner));

                if(gameRound > 1)
                    //각 라운드의 짝을 묶은 Battle 객체의 리스트를 받는다
                    battles = Battle.GenerateRounds(winnerList);

                //gameRound가 1이 되면(우승이 결정) WinnerForm 창으로 넘어간다
                if (gameRound == 1)
                {
                    WinnerForm winnerForm = new WinnerForm();
                    winnerForm.WinnerIndex = Battle.getWinnerIndex(battles);
                    this.Owner = winnerForm;
                    formOnOff.HideForm(this);
                    formOnOff.ShowForm(winnerForm);
                }
            }

            UpdateBattleImage(idPointer);
        }

        public void UpdateBattleImage(int idPointer)
        {
            //라운드의 인덱스를 턴마다 증가시키면서 대진 짝을 가져온다
            Battle foods = battles[idPointer];

            //다음 라운드 음식 이름과 사진으로 업데이트한다
            MemoryStream memoryStreamLeft = new MemoryStream(DataRepository.FoodImage.GetById(foods.Foods[0], "Thumbnail"));
            ptbLeft.Image = Image.FromStream(memoryStreamLeft);
            MemoryStream memoryStreamRight = new MemoryStream(DataRepository.FoodImage.GetById(foods.Foods[1], "Thumbnail"));
            ptbRight.Image = Image.FromStream(memoryStreamRight);

            UpdateRoundImage(gameRound);
            UpdateRoundImage(gameRound);
        }

        public void UpdateRoundImage(int round)
        {
            switch(round)
            {
                case 16:
                    roundImage = (Image)Resources.Round_16;
                    break;
                case 8:
                    roundImage = (Image)Resources.Round_8;
                    break;
                case 4:
                    roundImage = (Image)Resources.Round_4;
                    break;
                case 2:
                    roundImage = (Image)Resources.Round_2;
                    break;
            }

            pctbRound.Image = roundImage;
        }

    }
    #endregion 
}
