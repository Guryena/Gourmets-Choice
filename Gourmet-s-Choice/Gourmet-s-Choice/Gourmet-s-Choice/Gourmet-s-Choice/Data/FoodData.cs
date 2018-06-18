using FlashCard.Data;
using System.Linq;

namespace Gourmet_s_Choice.Data
{
    public class FoodData : EntityData<Food>
    {
        public string GetFoodById(int index)
        {
            using (FoodEntitie context = new FoodEntitie())
            {
                Food food = 
                context.Food.FirstOrDefault(x => x.FoodID == index);

                if (food == null)
                    return null;

                return food.FoodName;
            }
        }
/*
        public List<FoodWithImage> GetFoodImages()
        {
            using (FoodEntities context = new FoodEntities())
            {
                var query = from x in context.Foods
                    select new {x.FoodID, Name = x.FoodName, x.FoodImage.Image};

                var list = query.ToList();

                return list.ConvertAll(x => new FoodWithImage {FoodID =  x.FoodID, Name = x.Name, FoodImage = x.Image});

                List<FoodWithImage> result = new List<FoodWithImage>();
                foreach (var x in list)
                {
                    FoodWithImage item = new FoodWithImage();
                    item.FoodID = x.FoodID;
                    item.Name = x.Name;
                    item.FoodImage = x.Image;
                    result.Add(item);
                }

                return result;
            }

        }
*/
    }

    public class FoodWithImage
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public byte[] FoodImage { get; set; }
    }
}
