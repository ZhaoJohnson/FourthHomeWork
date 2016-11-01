using FourthModel.CuisineModel;

namespace FourthCooking
{
    public class HideGardenCuisine: IBasicCookFactory
    {
        public BasicCuisine CreatedCuisine()
        {
            return new SichuanCuisineModel();
        }
    }
}
