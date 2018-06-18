using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gourmet_s_Choice.Helper;
using Gourmet_s_Choice.Properties;

namespace Gourmet_s_Choice.Controls
{
    public enum RoundWinner
    {
        Left,
        Right
    }

    public partial class MainConrtols : UserControl
    {
        public MainConrtols()
        {
            InitializeComponent();
        }

        #region Fields
        private List<int> foodCandidateList;
        private List<Battle> battles;
        private int gameRound;
        public int GameRound { get; set; }
        private Image roundImage;
        private int idPointer = -1;
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 몇 강을 할지 선택하는 창이 띄운다
            //            ModeChoiceForm modeChoice = new ModeChoiceForm();
            //            modeChoice.Show();

            gameRound = GameRound;
            //몇 강을 할 지 사용자가 선택을 하면 반환값으로 화면을 구성한다.

            if (gameRound == 16)
                roundImage = (Image)Resources.Round_16;
            else if (gameRound == 8)
                roundImage = (Image)Resources.Round_8;

            pctbRound.Image = roundImage;

            //랜덤으로 음식을 가져올 리스트를 생성해둔다
            foodCandidateList = RandomIndex.GenerateRandIndex(gameRound);
            battles = Battle.GenerateRounds(foodCandidateList);

        }

        private void ptbLeft_Click(object sender, EventArgs e)
        {
            idPointer++;
            int clickeOn = (int)Gourmet_s_Choice.RoundWinner.Left;
            UpdateNewRoundForm(clickeOn);
        }

        private void ptbRight_Click(object sender, EventArgs e)
        {
            idPointer++;
            int clickeOn = (int)Gourmet_s_Choice.RoundWinner.Right;
            UpdateNewRoundForm(clickeOn);
        }
        #endregion

        #region Set Tournament Round Teams
        //한 토너먼트가 끝나면 idPointer를 0으로 리셋시키고, 새로운 토너먼트 id리스트를 받아와야 한다.
        public void UpdateNewRoundForm(int clickOn)
        {
            //포인터가 리스트의 값을 넘어서서 한 라운드가 끝나면 다음 라운드로 값을 변경시킨다.
            if (idPointer > battles.Count - 1) //foodCandidateList.Count
            {
                gameRound /= 2;
                UpdateRoundImage(gameRound);
                idPointer = 0;

                //각 라운드의 승자가 저장된 Battle List를 넘겨서 다음 CandidateList를 만든다.
                List<int> winnerList = battles.ConvertAll(x => x.Winner);

                //각 라운드의 짝을 묶은 Battle 객체의 리스트를 받는다
                battles = Battle.GenerateRounds(winnerList);
            }

//            //gameRound가 1이 되면(우승이 결정) 새로운 창으로 넘어간다
//            if (gameRound == 1)
//            {
//                formOnOff.ShowForm(winnerForm);
//                formOnOff.HideForm(this);
//            }
//
//
//            //배틀을 한번 이상 한 후에 버튼에 따라 승자를 Battle의 Winner속성에 저장한다
//            if (idPointer != 0)
//            {
//                battles[idPointer].Winner = battles[idPointer].Foods[clickOn];
//
//                #region Update Form
//                //라운드의 인덱스를 턴마다 증가시키면서 대진 짝을 가져온다
//                Battle candidate = battles[idPointer];
//
//                //다음 라운드 음식 이름과 사진으로 업데이트한다
//                MemoryStream memoryStreamLeft = new MemoryStream(DataRepository.FoodImage.GetById(candidate.Foods[0]));
//                ptbLeft.Image = Image.FromStream(memoryStreamLeft);
//                MemoryStream memoryStreamRight = new MemoryStream(DataRepository.FoodImage.GetById(candidate.Foods[1]));
//                ptbRight.Image = Image.FromStream(memoryStreamRight);
//
//                txtbxLeft.Text = DataRepository.Food.GetFoodById(candidate.Foods[0]);
//                txtbxRight.Text = DataRepository.Food.GetFoodById(candidate.Foods[1]);
//                #endregion
//            }


            //            if (idPointer == 0)
            //            {
            //                //새 라운드의 대진표를 한번만 생성하게 한다
            //                battles = Battle.GenerateRounds(foodCandidateList);
            //            }


        }

        public void UpdateRoundImage(int round)
        {
            switch (round)
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
        #endregion
    }
}