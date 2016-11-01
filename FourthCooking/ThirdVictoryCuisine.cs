using FourthModel.CuisineModel;
using FourthModel.FoodModel;

namespace FourthCooking
{
    public class ThirdVictoryCuisine: IBasicCookFactory
    {
        public BasicCuisine CreatedCuisine()
        {
            return new GuangdongCuisineModel();
        }
    }
}
