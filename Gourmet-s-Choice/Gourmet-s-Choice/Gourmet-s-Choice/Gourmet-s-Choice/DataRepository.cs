using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gourmet_s_Choice.Data;

namespace Gourmet_s_Choice
{
    public class DataRepository
    {
        public static FoodData Food { get; } = new FoodData();
        public static FoodImageData FoodImage { get; } = new FoodImageData();

    }
}
