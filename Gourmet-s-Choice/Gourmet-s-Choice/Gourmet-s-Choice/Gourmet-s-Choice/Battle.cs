using System.Collections.Generic;
using Gourmet_s_Choice.Helper;

namespace Gourmet_s_Choice
{
    public class Battle
    {
        private Battle()
        {
        }

        public List<int> Foods { get; set; }

        public int Winner { get; set; }

        //각 토너먼트가 끌날 때 마다 호출되어서 반환될 리스트를 만든다

        public static List<Battle> GenerateRounds(List<int> list)
        {
            //넘어온 다음 후보 리스트를 섞어준다
            var foodList = RandomIndex.ShuffleIndex(list);

            List<Battle> Battles = new List<Battle>();

            for (int i = 0; i < foodList.Count; i += 2)
            {
                List<int> listItem = new List<int>();
                listItem.Add(foodList[i]);
                listItem.Add(foodList[i + 1]);

                Battles.Add(new Battle { Foods = listItem });
            }

            return Battles;
        }

        public static int getWinnerIndex(List<Battle> battles)
        {
            int winnerIndex = battles[0].Winner;

            return winnerIndex;
        }

        /*
                void foo()
                {
                    Marine m1, m2;


                }
            }


            class Marine
            {
                public int HP;

                public static int InitialHP;

                public void IncreseHP()
                {
                    HP++;
                    InitialHP++;
                }

                public static void IncreseInitialHP()
                {
                    InitialHP++;
                    HP++;
                }
*/

    }
}
