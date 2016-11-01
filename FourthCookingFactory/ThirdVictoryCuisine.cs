using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourthModel.CuisineModel;
using FourthModel.FoodModel;

namespace FourthCookingFactory
{
    public class ThirdVictoryCuisine: IBasicCookFactory
    {
        public BasicCuisine CreatedCuisine()
        {
            return new GuangdongCuisineModel();
        }
    }
}
