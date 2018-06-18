using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FlashCard.Data;

namespace Gourmet_s_Choice.Data
{
    public class FoodImageData : EntityData<FoodImage>
    {

        public void InsertWithImage(string foodName, byte[] imageBytes, byte[] thumbnailBytes)
        {
            //예외처리를 해주는 것이 정석이다.
            //transaction을 걸어주는 코드도 필요하다:모두 넣거나 모두 못 넣거나(고아 데이터를 만들지 않기 위해서)
            //두 군데에서 따로 context를 생성하므로 두 context를 묶어서 트랜젝션하는 코드가 있어야 한다.
            Food food = new Food();
            food.FoodID = food.FoodID;
            food.FoodName = foodName;
            DataRepository.Food.Insert(food); //insert 안에서 context를 별개로 만든다

            FoodImage foodImage = new FoodImage();
            foodImage.FoodID = food.FoodID; //자동증가값은 Entity Framework에서 자동으로 지정을 해준다
            foodImage.Image = imageBytes;
            foodImage.Thumbnail = thumbnailBytes;
            Insert(foodImage);

            Thread.Sleep(500);
        }

        public byte[] GetById(int index, string imageType)
        {
            FoodImage foodImage;
            using (FoodEntitie context = new FoodEntitie())
            {
                foodImage =
                context.FoodImage.FirstOrDefault(x => x.FoodID == index);

                if (foodImage == null)
                    return null;
                
            }

            if (imageType == "Image")
                return foodImage.Image;

            return foodImage.Thumbnail;
        }
    }
}
